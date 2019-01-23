using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppForTest
{
    class Program
    {
        public delegate void ChangeHandler(object flag);
        public delegate void RandomHandler(int randomNumber, string eventType);
        public static event RandomHandler RandomNumberPrint;
        public static event ChangeHandler AccountChanged;
        static private int account;
        static int changeFlag;
        public static int Account { get => account; }
        static Random random = new Random();

        static void ChangeAccount(object changeFlag)
        {

            while (true)
            {
                if ((bool)changeFlag == true)
                {
                   // Random random1 = new Random();
                    int pause = random.Next(100, 3000);
                    Thread.Sleep(pause);
                    int buf = random.Next(1, 100);
                    account += buf;
                    AccountChanged?.Invoke(1);
                    RandomNumberPrint?.Invoke(buf, "increasing");
                }
                else
                {
                    //Random random2 = new Random();
                    int pause = random.Next(100, 3000);
                    Thread.Sleep(pause);
                    int buf = random.Next(1, 100);
                    account -= buf;
                    AccountChanged?.Invoke(2);
                    RandomNumberPrint?.Invoke(buf, "decreasing");
                }
            }
        }


        public static void PrintRandom(int randomNumber, string eventType)
        {
            Console.WriteLine(eventType + " " + randomNumber);
        }

        public static void Print(object flag)
        {
            changeFlag = (int)flag;
            if (changeFlag == 1)
            {
                Console.WriteLine("Increasing" + " " + Account);
            }
            else if (changeFlag == 2)
            {
                Console.WriteLine("Decreasing" + " " + Account);
            }

        }



        static void MainMethod()
        {
            Thread inc = new Thread(new ParameterizedThreadStart(ChangeAccount));
            Thread dec = new Thread(new ParameterizedThreadStart(ChangeAccount));
            Thread print = new Thread(new ParameterizedThreadStart(Print));
            inc.Start(true);
            inc.IsBackground = true;
            dec.Start(false);
            dec.IsBackground = true;
            print.Start(0);
            print.IsBackground = true;
            bool flag = true;
            while (flag)
            {
                Thread.Sleep(10);
                if (Account <= -200 || Account >= 200)
                    flag = false;
            }
        }

        static void Main(string[] args)
        {
            AccountChanged += Print;
           // RandomNumberPrint += PrintRandom;
            Thread mainThread = new Thread(MainMethod);
            mainThread.Start();
        }
    }
}
