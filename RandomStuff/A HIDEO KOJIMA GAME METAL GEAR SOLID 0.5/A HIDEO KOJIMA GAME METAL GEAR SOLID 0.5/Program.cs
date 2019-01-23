using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_HIDEO_KOJIMA_GAME_METAL_GEAR_SOLID_POLTORA
{
    class Program
    {
        public static void Matr(int[,] pole1)
        {
            for (int i = 0; i < pole1.GetLength(0); i++)
            {
                for (int j = 0; j < pole1.GetLength(1); j++)
                    Console.Write(string.Format("{0,3}", pole1[i, j]));
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            double rasst;
            int n = 0;
            int i = 0;
            int j = 0;
            int[] koordinati_k = new int[2];
            int[] klad = new int[2];
            int[] tekushie_k = new int[2];
            int[] predidushie_k = new int[2];
            Random rnd = new Random();
            Console.WriteLine("Hello my dearest friend, it's a game about founding a treasure, everyone love to find a treasure!\nSo, the rule is simple: if you laught - you lose... oops, wrong rules\nEhm... Here it is!\n You is a '1', somewhere buried a treasure and to finish a game you have to find it.\n You can move by pressing w,a,s,d buttons\n On every step you can find a clue about how far away a treasure from you\n Also you have to choose the dimention of the game board, please enter the number from keyboard!\nGood luck, have fun!");
            Console.WriteLine("Enter the dimension of the game board:\n");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] pole = new int[n, n];
            i = Zakapivanie_klada(n, klad, rnd);

            Console.WriteLine();
            i = Zapolnenie_matrici_nulyami(ref j, pole);
            pole[n - 1, 0] = 1;
            predidushie_k[0] = n - 1;
            predidushie_k[1] = 0;
            tekushie_k[0] = n - 1;
            tekushie_k[1] = 0;
            rasst = Rasstoyanie(klad, tekushie_k);
            Console.WriteLine("You can move by w, a, s, d buttons \n w - up\n a - left\n s - down\n d - right\n");
            Console.WriteLine("Press the button, please\n");
            Console.WriteLine("Only {0} steps left", rasst);
            Matr(pole);
            rasst = Samiy_dlinniy_while_v_moyey_zjizni(rasst, klad, tekushie_k, predidushie_k, pole);
            Console.Write("\nWINNER WINNER CHICKEN DINNER!");
            Console.ReadKey();
        }

        private static double Rasstoyanie(int[] klad, int[] tekushie_k)
        {
            return Convert.ToInt32(System.Math.Sqrt((klad[0] - tekushie_k[0]) * (klad[0] - tekushie_k[0]) + (klad[1] - tekushie_k[1]) * (klad[1] - tekushie_k[1])));
        }

        private static double Samiy_dlinniy_while_v_moyey_zjizni(double rasst, int[] klad, int[] tekushie_k, int[] predidushie_k, int[,] pole)
    {
        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    {

                        if (tekushie_k[0] == 0)
                            Console.WriteLine("You cannot go UP, please choose another direction");
                        else
                            {
                                Peremeshenie_w(tekushie_k, predidushie_k, pole);
                                rasst = Rasstoyanie(klad, tekushie_k);

                            }
                            break;
                    }
                case ConsoleKey.A:
                    {

                        if (tekushie_k[1] == 0)
                            Console.WriteLine("You cannot go LEFT, please choose another direction");
                        else
                            {
                                Peremeshenie_a(tekushie_k, predidushie_k, pole);
                                rasst = Rasstoyanie(klad, tekushie_k);

                            }
                        }
                    break;
                case ConsoleKey.S:
                    {
                        if (tekushie_k[0] == pole.GetLength(1) - 1)
                            Console.WriteLine("You cannot go DOWN, please choose another direction");
                        else
                            {
                                Peremeshenie_s(tekushie_k, predidushie_k, pole);
                                rasst = Rasstoyanie(klad, tekushie_k);

                            }
                            break;
                    }
                case ConsoleKey.D:
                    {
                        if (tekushie_k[1] == pole.GetLength(1))
                            Console.WriteLine("You cannot go RIGHT, please choose another direction");
                        else
                            {
                                Peremeshie_d(tekushie_k, predidushie_k, pole);
                                rasst = Rasstoyanie(klad, tekushie_k);

                            }
                            break;

                    }
                default:
                    {
                        Console.WriteLine("You chosed the wrong button, please press w,a,s,d\n");
                        break;
                    }
            }
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Only {0} steps left", rasst);
            Matr(pole);
        }
        while (tekushie_k[0] != klad[0] || tekushie_k[1] != klad[1]);
        return rasst;
    }

        private static void Peremeshie_d(int[] tekushie_k, int[] predidushie_k, int[,] pole)
        {
            tekushie_k[0] = tekushie_k[0] + 0;
            tekushie_k[1] = tekushie_k[1] + 1;
            predidushie_k[0] = tekushie_k[0] + 0;
            predidushie_k[1] = tekushie_k[1] - 1;
            pole[tekushie_k[0], tekushie_k[1]] = 1;
            pole[predidushie_k[0], predidushie_k[1]] = 0;
        }

        private static void Peremeshenie_s(int[] tekushie_k, int[] predidushie_k, int[,] pole)
        {
            tekushie_k[0] = tekushie_k[0] + 1;
            tekushie_k[1] = tekushie_k[1] + 0;
            predidushie_k[0] = tekushie_k[0] - 1;
            predidushie_k[1] = tekushie_k[1] + 0;
            pole[tekushie_k[0], tekushie_k[1]] = 1;
            pole[predidushie_k[0], predidushie_k[1]] = 0;
        }

        private static void Peremeshenie_a(int[] tekushie_k, int[] predidushie_k, int[,] pole)
        {
            tekushie_k[0] = tekushie_k[0] + 0;
            tekushie_k[1] = tekushie_k[1] - 1;
            predidushie_k[0] = tekushie_k[0] + 0;
            predidushie_k[1] = tekushie_k[1] + 1;
            pole[tekushie_k[0], tekushie_k[1]] = 1;
            pole[predidushie_k[0], predidushie_k[1]] = 0;
        }

        private static void Peremeshenie_w(int[] tekushie_k, int[] predidushie_k, int[,] pole)
        {
            tekushie_k[0] = tekushie_k[0] - 1;
            tekushie_k[1] = tekushie_k[1] + 0;
            predidushie_k[0] = tekushie_k[0] + 1;
            predidushie_k[1] = tekushie_k[1] + 0;
            pole[tekushie_k[0], tekushie_k[1]] = 1;
            pole[predidushie_k[0], predidushie_k[1]] = 0;
        }

        private static int Zapolnenie_matrici_nulyami(ref int j, int[,] pole)
    {
        int i;
        for (i = 0; i < pole.GetLength(0); i++)
        {
            for (j = 0; j < pole.GetLength(1); j++)
                pole[i, j] = 0;
        }

        return i;
    }

    private static int Zakapivanie_klada(int n, int[] klad, Random rnd)
    {
        int i;
        for (i = 0; i < klad.Length; i++)
        {
            klad[i] = rnd.Next(n);
        }

        return i;
    }
}
}
