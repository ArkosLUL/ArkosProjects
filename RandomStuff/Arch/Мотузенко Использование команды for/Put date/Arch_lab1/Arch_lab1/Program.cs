//Курс "Архитектура компьютеров"
//  Лабораторная работа № 1
//ПОСТАНОВКА ЗАДАЧИ:
//       В первую строку текстового файла вписать дату и имя его создания
//ВЫПОЛНИЛА: 
//       студентка группы ПЗ-15-1
//       Мотузенко Наталья

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Security.Permissions;


namespace Arch_lab1
{
    class Program
    {
        static int completionCode = 0;
        static string strInput;
        static int countRes = 0;

        static string path;
        static List<string> shablons;
        static FileAttributes yesAttributes;
        static FileAttributes noAttributes;
        static bool isSubdir = false;  //подсчет в подпапках
        static string [] extentions = new string[] {".apt", ".err", ".log",".pwi",".sub",".ttf",".text",".txt"};

        /*1*/
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Info();
                readInputZero(args);
            }
            else
            {
                readInput(args);
            }
            return completionCode;
        }

        /*2*/
        static void Info()
        {
            string info;
            info = "Эта утилита в первую строку текстового файла\n" + "вписывает дату и время его создания.\n";
            info = info + "Для вызова подсказки введите ключ \"/?\".\n";
            info = info + "Для выхода введите \"exit\" .\n";
            Console.WriteLine(info);
        }
        /*+*/
        static void writeHelp()
        {
            string help;
            help = "В первую строку текстового файла запись даты и времени его создания.\n\n";
            help += "PUTDATE [диск:][путь][имя файла] [/S] [/A[[:]атрибуты]] [[файл]...] \n\n";
            help += "/S  - Включить подсчет в подпапках.\n";
            help += "/A  - Подсчет файлов с указанными атрибутами.\n";
            help += "  Атрибуты:    A  - Файлы, готовые для архивирования.\n";
            help += "               H  - Скрытые файлы.\n";
            help += "               S  - Системные файлы.\n";
            help += "               R  - Файлы, доступные только для чтения.\n";
            help += "               -  - Префикс \" - \" имеет значение НЕ.\n";
            help += "Атрибуты можно установить через переменную среды PUTDATECMD.\n";
            help += "По умолчанию подсчет в подпапках не проводится.\n";
            Console.WriteLine(help);
        }

        static void readInput(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToUpper();
            }
            if (args[0] == "EXIT")
            {
                completionCode = 1;
            }
            else if (args[0] == "PUTDATE")
            {
                readInputCommand(args);
                if (completionCode == 0)
                {
                    EnvironmentVariable();
                    writeResult();
                }
            }
            else
            {
                completionCode = 2;
            }
            showInfo();
        }
        /*3*/
        static void readInputZero(string[] args)
        {
            while (true)
            {
                strInput = Console.ReadLine().Trim().ToUpper();
                if (strInput.StartsWith("EXIT"))
                {
                    completionCode = 1;
                    break;
                }
                if (strInput.StartsWith("PUTDATE"))
                {
                    args = strInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    readInputCommand(args);
                    if (completionCode == 0)
                    {
                        EnvironmentVariable();
                        writeResult();
                    }
                }
                else
                {
                    completionCode = 2;
                }
                showInfo();
            }
        }
        /*4*/
        static void readInputCommand(string[] args)
        {
            removeFirst(ref args); //удаляем первое слово строки
            completionCode = 0;
            path = "";
            shablons = new List<string>();
            yesAttributes = 0;
            noAttributes = 0;
            isSubdir = false;

            if (args.Length != 0 && Directory.Exists(args[0])) //считываем путь
            {
                path = args[0];
                removeFirst(ref args);
            }
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "/S" || args[i] == "/?" || args[i].StartsWith("/A"))
                {
                    addKey(args[i]);
                }
                else
                {
                    addShablon(args[i]);
                }
            }
        }

        /*5*/
        static void addKey(string key)
        {
            if (key == "/S")
            {
                isSubdir = true;
            }
            else if (key == "/?")
            {
                completionCode = 3;
            }
            else if (key.StartsWith("/A"))
            {
                if (key.Contains(":"))
                {
                    key = key.Substring(3);  
                }
                else
                {
                    key = key.Substring(2);  
                }

                bool noMode = false; 
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == '-')
                    {
                        noMode = true;
                    }
                    else
                    {
                        if (key[i] == 'A')
                        {
                            if (noMode)
                            {
                                noAttributes |= FileAttributes.Archive;
                            }
                            else
                            {
                                yesAttributes |= FileAttributes.Archive;
                            }
                        }
                        else if (key[i] == 'H')
                        {
                            if (noMode)
                            {
                                noAttributes |= FileAttributes.Hidden;
                            }
                            else
                            {
                                yesAttributes |= FileAttributes.Hidden;
                            }
                        }
                        else if (key[i] == 'S')
                        {
                            if (noMode)
                            {
                                noAttributes |= FileAttributes.System;
                            }
                            else
                            {
                                yesAttributes |= FileAttributes.System;
                            }
                        }
                        else if (key[i] == 'R')
                        {
                            if (noMode)
                            {
                                noAttributes |= FileAttributes.ReadOnly;
                            }
                            else
                            {
                                yesAttributes |= FileAttributes.ReadOnly;
                            }
                        }
                        else
                        {
                            completionCode = 4; //неправильный атрибут
                            break;
                        }

                        noMode = false;
                    }
                }
            }
        }
        /*6*/
        static void addShablon(string shablon)
        {
            int star = shablon.IndexOf("*");
            if (star != -1)
            {
                shablon = shablon.Remove(star, 1);
            }

            int question = shablon.IndexOf("?");
            if (question != -1)
            {
                shablon = shablon.Remove(question, 1);
            }
            shablons.Add(shablon);
        }

        /*+*/
        static void removeFirst(ref string[] args)
        {
            List<string> temp = new List<string>(args);
            temp.RemoveAt(0);
            args = temp.ToArray<string>();
        }


        /*7*/
        static void EnvironmentVariable()//работаем с переменной окружения
        {
            IDictionary environment = Environment.GetEnvironmentVariables();
            if (environment["PUTDATECMD"] as string == "/A:A")
            {
                yesAttributes |= FileAttributes.Archive;
            }
            else if (environment["PUTDATECMD"] as string == "/A:-A")
            {
                noAttributes |= FileAttributes.Archive;
            }
            else if (environment["PUTDATECMD"] as string == "/A:H")
            {
                yesAttributes |= FileAttributes.Hidden;
            }
            else if (environment["PUTDATECMD"] as string == "/A:-H")
            {
                noAttributes |= FileAttributes.Hidden;
            }
            else if (environment["PUTDATECMD"] as string == "/A:S")
            {
                yesAttributes |= FileAttributes.System;
            }
            else if (environment["PUTDATECMD"] as string == "/A:-S")
            {
                noAttributes |= FileAttributes.System;
            }
            else if (environment["PUTDATECMD"] as string == "/A:R")
            {
                yesAttributes |= FileAttributes.ReadOnly;
            }
            else if (environment["PUTDATECMD"] as string == "/A:-R")
            {
                noAttributes |= FileAttributes.ReadOnly;
            }
        }

        /*8*/
        static void writeResult()
        {
            try
            {
                countRes = changeDateFiles(path, shablons, isSubdir);
                Console.WriteLine("\nКоличество файлов, которые подверглись изменению:\t {0} \n", Convert.ToString(countRes));
            }
            catch (Exception e)
            {
                if (e.Message == "REGEX")
                {
                    completionCode = 5;  // аргумент не соответствует ни одному из параметров
                }
                else if (e.Message == "PATH")
                {
                    completionCode = 6;  // папка не существует;
                }
                else
                {
                    completionCode = 2;  //неправильное выражение
                }
            }
        }

        /*9*/
        static int changeDateFiles(string folder, List<string> masks, bool subdir)
        {
            int kolFiles = 0;
            try
            {
                foreach (string file in Directory.GetFiles(folder))
                {
                    FileInfo finfo;
                    try
                    {
                        finfo = new FileInfo(file);
                        finfo.CreationTime = new DateTime();
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    if (!isFileShablonMatch(file))
                    {
                        continue;
                    }
                    if (!isFileAttributesMatch(finfo))
                    {
                        continue;
                    }
                    bool flag = false;
                    for (int i = 0; i < extentions.Length; i++)
                    {
                        string str = Path.GetExtension(file);
                        if (extentions[i] == Path.GetExtension(file))
                            flag = true;
                    }
                    if (!flag)
                    {
                        continue;
                    }
                   StreamWriter FileWrite = null;
                    try
                    {
                        string temp;
                        using (StreamReader tempRead = new StreamReader(file))
                        {
                            temp = tempRead.ReadToEnd();
                        }
                        FileWrite = new StreamWriter(file, false);
                        FileWrite.WriteLine(finfo.CreationTime);
                        FileWrite.WriteLine(temp);
                    }
                    catch
                    {
                        continue;
                    }
                    finally
                    {
                        if (FileWrite != null)
                            FileWrite.Close();
                    }
                    kolFiles++;
                }
                if (subdir)   //   /S
                {
                    foreach (string dir in Directory.GetDirectories(folder))
                        kolFiles += changeDateFiles(dir, masks, subdir);                  
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw new ArgumentException("PATH");
            }
            catch (ArgumentException e)
            {
                if (e.Message != "REGEX")
                {
                    throw new ArgumentException("PATH");
                }

                throw;
            }

            return kolFiles;
        }

        /*10*/
        static bool isFileShablonMatch(string fileName)
        {
            foreach (string mask in shablons)
            {
                bool matches = false;
                try
                {
                    matches = Regex.IsMatch(fileName.ToUpper(), mask);
                }
                catch (Exception)
                {
                    throw new ArgumentException("REGEX");
                }
                if (matches)
                {
                    return true;
                }
            }
            return shablons.Count == 0;
        }

        /*11*/
        static bool isFileAttributesMatch(FileInfo fileInfo)
        {
            bool YesMatch = (fileInfo.Attributes & yesAttributes) == yesAttributes;
            bool NoMatch = (fileInfo.Attributes & noAttributes) != noAttributes || noAttributes == 0;

            return YesMatch && NoMatch;
        }

        /*12*/
        static void showInfo()
        {
            switch (completionCode)
            {
                case 2:
                    Console.WriteLine("Неправильное выражение!");
                    break;
                case 3:
                    writeHelp();
                    break;
                case 4:
                    Console.WriteLine("Неверный атрибут!");
                    break;
                case 5:
                    Console.WriteLine("Аргумент не соответствует ни одному из параметров!");
                    break;
                case 6:
                    Console.WriteLine("Каталог (путь) не существует!");
                    break;
            }
        }

    }

}
