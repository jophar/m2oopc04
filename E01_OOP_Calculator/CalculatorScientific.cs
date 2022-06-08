using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator
{
    internal class CalculatorScientific : CalculatorStandard
    {

        private static Dictionary<string, string> sciCalculatorMenu = new Dictionary<string, string>
        {
            {"+", "Add"},
            {"-", "Subtract"},
            {"*", "Multiply"},
            {"/", "Divide" },
            {"2", "Square Root"},
            {"%", "Remaining From Division"}
        };


        internal void SciMenuChoice()
        {
            SciMenuPrint();
            string sciMenuChoice = Console.ReadLine();

            switch (sciMenuChoice)
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

                case "2":
                    {
                        GetNumbers();
                        SquareRoot();
                        PrintCalculatorSci(this);

                    } break;

                case "%":
                    {
                        GetNumbers();
                        RemFromDiv();
                        PrintCalculatorSci(this);

                    } break;

                default:
                    {
                        Console.WriteLine("Please insert a valid option\n");
                        Console.ReadLine();
                    }
                    break;
            }
        }
        internal void SciMenuPrint()
        {
            foreach (KeyValuePair<string, string> i in sciCalculatorMenu)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }

        internal void SquareRoot()
        {
            Operand = "Sqrt";
            Result = Math.Sqrt(FirstNumber);
        }

        internal void RemFromDiv()
        {
            Operand = "%";
            Math.DivRem(FirstNumber, SecondNumber, out int r);
            Result = r;
        }
    }
}
