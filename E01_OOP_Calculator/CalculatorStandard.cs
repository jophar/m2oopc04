using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator
{
    internal class CalculatorStandard : Calculator
    {
        internal CalculatorStandard() : base()
        {
            FirstNumber = 0;
            SecondNumber = 0;  
            ThridNumber = 0;
            Operand = string.Empty;
            Result = 0;
        }


        internal CalculatorStandard(int i, int j, string k)  
        {
            FirstNumber = i;
            SecondNumber = j;
            ThridNumber = 0;
            Operand = k;
            Result = 0;
        }

        internal CalculatorStandard(int f, int s, int t, string o)
        {
            FirstNumber = f;
            SecondNumber = s;
            ThridNumber = t;
            Operand = o;
            Result = 0;
        }


        private static Dictionary<string, string> stdCalculatorMenu = new Dictionary<string, string>
        {
            {"+", "Add"},
            {"-", "Subtract"},
            {"*", "Multiply"},
            {"/", "Divide" },
            {"r", "Round"}
        };

        internal void StdMenuPrint()
        {
            foreach (KeyValuePair<string, string> i in stdCalculatorMenu)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
            Console.Write("\nEnter your option: ");
        }

        internal void StdMenuChoice()
        {
            StdMenuPrint();
            string stdMenuChoice = Console.ReadLine();

            switch (stdMenuChoice)
            {
                case "+":
                    {
                        GetNumbers();
                        Add();
                        PrintCalculator(this);

                    } break;

                case "-": 
                    { 
                        GetNumbers(); 
                        Subtract();
                        PrintCalculator(this);
                    } break;

                case "*":
                    {
                        GetNumbers();
                        Multiply();
                        PrintCalculator(this);

                    } break;

                case "/":
                    {
                        GetNumbers();
                        Divide();
                        PrintCalculator(this);

                    } break;

                case "r":
                    {
                        ToRound();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Please insert a valid option\n");
                        Console.ReadLine();

                    } break;
            }
        }

        internal static void ToRound()
        {
            double a;
            int b;
            Console.Write("Insert the number to round: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Insert the number of figures: ");
            b = int.Parse(Console.ReadLine());
            double r = Math.Round(a, b);
            Console.WriteLine($"Result: {r}");
            Console.ReadKey();
        }
        internal void GetNumbers()
        {
            string[] tempString;

            Console.Write("Insert the numbers separated by space: ");
            tempString = Console.ReadLine().Split(' ');

            if (tempString.Length == 1)
            {
                FirstNumber = int.Parse(tempString[0]);
                return;
            }

                if (tempString.Length == 2 )
            {
                FirstNumber = int.Parse(tempString[0]);
                SecondNumber = int.Parse(tempString[1]);
                return;
            }

            if(tempString.Length == 3)
            {
                FirstNumber = int.Parse(tempString[0]);
                SecondNumber = int.Parse(tempString[1]);
                ThridNumber = int.Parse(tempString[2]);
                return;
            }

            if (tempString.Length > 1 || tempString.Length < 2)
                Console.WriteLine("Erro");

        }
        internal override void Add()
        {
            Operand = "+";

            if (ThridNumber == 0)
                Result = FirstNumber + SecondNumber;
            else
                Result = FirstNumber + SecondNumber + ThridNumber;
        }

        internal override void Subtract()
        {
            Operand = "-";
            Result = FirstNumber - SecondNumber;
        }

        internal override void Multiply()
        {
            Operand = "*";
            Result = FirstNumber * SecondNumber;
        }

        internal override void Divide()
        {
            Operand = "/";
            Result = (double)FirstNumber / (double)SecondNumber;
        }
    }
}
