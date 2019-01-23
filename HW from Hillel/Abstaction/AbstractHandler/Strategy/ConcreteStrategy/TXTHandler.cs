using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Data;
using DifferentStrategyS.Strategy;

namespace DifferentExtension.Strategy.ConcreteStrategy
{
    class TXTHandler : AbstractHandler
    {
        private FileInfo file;
        private FileInfo createFile;
        private DirectoryInfo directory;
        private StreamReader reader;
        private StreamWriter writer;
        private string fileContent;

        public TXTHandler(string path)
        {
            try
            {
                this.directory = new DirectoryInfo(Path.GetDirectoryName(path));
                this.file = new FileInfo(Path.GetFullPath(path));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Проверьте путь к файлу или существование данного файла в указанной папке");
            }

        }

        public override void Open()
        {
            if (file.Exists)
            {
                reader = new StreamReader(File.Open(file.FullName, FileMode.Open));

                fileContent = reader.ReadToEnd();
                reader.Close();
            }
            else
            {
                Create();
            }
        }

        public override void Create()
        {
            using (reader = new StreamReader(File.Create(file.FullName)))
            {
                fileContent = reader.ReadToEnd();
            }
        }

        public override void Save()
        {
            writer.Close();
            reader.Close();
        }

        public override void Change()
        {
            string temp = Console.ReadLine();
            writer = new StreamWriter(file.FullName);

            writer.WriteLine(temp);
            writer.Write(fileContent);

        }
    }
}
