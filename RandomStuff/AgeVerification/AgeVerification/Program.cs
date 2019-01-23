using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeVerification
{
    class Program
    {
        static int Main(string[] args)
        {
            bool myBool = false, LoopBool = false;
            int age = 0, menu = 0;


            while (LoopBool == false)
            {
                Console.WriteLine("1. Do age verification \n2. Exit");
                myBool = int.TryParse(Console.ReadLine(), out menu);
                
                    switch (menu)
                    {
                        case 1:
                            {
                                Verification(out myBool, out age);
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                return 0;
                            }
                        default:
                            {
                                Console.WriteLine("You made a wrong choice, please try again");
                                return Menu(out myBool, ref age, out menu);
                                
                            }
                    }
                }
                
            

            Console.WriteLine("MyBool = " + myBool + " age = " + age);
            Console.ReadLine();
            return 0;
        }
private static int Menu(out bool myBool, ref int age, out int menu)
        {
            Console.WriteLine("1. Continue age verification \n2. Exit");
            myBool = int.TryParse(Console.ReadLine(), out menu);
            while (myBool == true)
            {
                switch (menu)
                {
                    case 1:
                        {

                            Verification(out myBool, out age);

                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            return 0;
                        }
                    default:
                        {
                            Console.WriteLine("You made a wrong choice, please try again");
                            break;
                        }

                }
            }
            if (myBool == false)
            {
                Menu(out myBool, ref age, out menu);
                return 0;
            }

            return 0;
        }

        private static void Verification(out bool myBool, out int age)
        {
            Console.WriteLine("Enter your age (in years)");
            myBool = int.TryParse(Console.ReadLine(), out age);
            if (myBool == true)
            {
                if (age < 18)
                {
                    Console.WriteLine("You are child");
                    myBool = false;
                }
                else
                {
                    if (age < 70)
                    {
                        Console.WriteLine("You are adult");
                        myBool = false;
                    }
                    else
                    {
                        if (age < 150)
                        {
                            Console.WriteLine("You are old man");
                            myBool = false;
                        }
                        else
                        {
                            Console.WriteLine("People can't be so old");
                            myBool = false;
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("You entered wrong data, please try again");

            }
        }
    }
}
