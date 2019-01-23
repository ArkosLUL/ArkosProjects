using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseCalculator
{
    static class EvaluatingMachine
    {
        private static string stringToParse;
        private static string postfixNotation;
        private static double result;
        public static string StringToParse
        {
            get
            {
                return stringToParse;
            }
        }

        public static string PostfixNotation
        {
            get
            {
                return postfixNotation;
            }
        }

        public static double Result
        {
            get
            {
                return result;
            }
        }

        public static string GetStringFromConsole()
        {
            string str = string.Empty;
            Console.WriteLine("Please, enter the expression to count");
            stringToParse = Console.ReadLine();
            str = StringToParse;
            return str;
        }

        private static int GetOperatorPriority(char operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case '^':
                    {
                        return 3;
                    }
                case '/':
                case '*':
                    {
                        return 2;
                    }
                case '+':
                case '-':
                    {
                        return 1;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        private static bool IsDelimeter(char ch)
        {
            if (ch == ' ' || ch == '=')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsOperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '/' || ch == '*' || ch == '(' || ch == ')' || ch == '^')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void GetPostfixNotation()
        {

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < StringToParse.Length; i++)
            {
                if (IsDelimeter(StringToParse[i]))
                {
                    continue;
                }

                if (char.IsDigit(StringToParse[i]))
                {
                    while (!IsDelimeter(StringToParse[i]) && !IsOperator(StringToParse[i]))
                    {
                        postfixNotation += StringToParse[i];
                        i++;

                        if (i == StringToParse.Length)
                        {
                            break;
                        }
                    }
                    postfixNotation += ' ';
                    i--;
                }

                if (IsOperator(StringToParse[i]))
                {
                    if (StringToParse[i] == '(' || StringToParse[i] == ')')
                    {
                        if (StringToParse[i] == '(')
                        {
                            stack.Push(StringToParse[i]);
                        }
                        else if (StringToParse[i] == ')')
                        {
                            while (stack.Peek() != '(')
                            {
                                postfixNotation += stack.Pop().ToString() + ' ';
                            }
                        }
                    }

                    else
                    {
                        if (stack.Count == 0)
                        {
                            stack.Push(StringToParse[i]);
                        }
                        else if (GetOperatorPriority(stack.Peek()) >= GetOperatorPriority(StringToParse[i]))
                        {
                            postfixNotation += stack.Pop().ToString() + ' ';
                            stack.Push(StringToParse[i]);
                        }
                        else
                        {
                            stack.Push(StringToParse[i]);
                        }
                    }
                }
            }
            while (stack.Count > 0)
            {
                if (stack.Peek() == '(')
                {
                    stack.Pop();
                    continue;
                }
                postfixNotation += stack.Pop().ToString() + ' ';
            }
        }

        public static double EvaluatePostfixExpression()
        {
            double res = 0;
            Stack<double> stack = new Stack<double>();

            for (int i = 0; i < postfixNotation.Length; i++)
            {
                if (IsDelimeter(postfixNotation[i]))
                {
                    continue;
                }

                if (char.IsDigit(postfixNotation[i]))
                {
                    string temp = string.Empty;
                    while (!IsDelimeter(postfixNotation[i]) && !IsOperator(postfixNotation[i]))
                    {
                        temp += postfixNotation[i];
                        i++;
                        if (i == postfixNotation.Length)
                        {
                            break;
                        }
                    }
                    stack.Push(double.Parse(temp));
                    i--;
                }
                else if (IsOperator(postfixNotation[i]))
                {
                    switch (postfixNotation[i])
                    {
                        case '^':
                            {
                                double a = stack.Pop();
                                double b = stack.Pop();
                                res = Math.Pow(b,a);
                                break;
                            }
                        case '*':
                            {
                                double a = stack.Pop();
                                double b = stack.Pop();
                                res = b * a;
                                break;
                            }
                        case '/':
                            {
                                double a = stack.Pop();
                                double b = stack.Pop();
                                res = b / a;
                                break;
                            }
                        case '-':
                            {
                                double a = stack.Pop();
                                double b = stack.Pop();
                                res = b - a;
                                break;
                            }
                        case '+':
                            {
                                double a = stack.Pop();
                                double b = stack.Pop();
                                res = b + a;
                                break;
                            }
                    }
                    stack.Push(res);
                }
            }
            result = stack.Peek();
            return stack.Peek();
        }
    }
}
