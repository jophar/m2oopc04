using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator
{
    abstract internal class Calculator
    {
        internal int FirstNumber { get; set; }
        internal int SecondNumber { get; set; }
        internal int ThridNumber { get; set; }
        internal double Result { get; set; }
        internal string Operand { get; set; }

        private static Dictionary<string, string> mainCalculatorMenu = new Dictionary<string, string>
        {
            {"1", "Standard Calculator"},
            {"2", "Scientific Calculator"}
        };

        internal static void MainMenuPrint()
        {
            foreach (KeyValuePair<string,string> i in mainCalculatorMenu)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }

        internal static void PrintCalculator(CalculatorStandard c)
        {
            if (c.ThridNumber != 0)
            {
                Console.WriteLine($"Result of {c.FirstNumber} {c.Operand} {c.SecondNumber} {c.Operand} {c.ThridNumber} is {c.Result}\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Result of {c.FirstNumber} {c.Operand} {c.SecondNumber} is {c.Result}\n");
                Console.ReadKey();
            }
        }

        internal static void PrintCalculatorSci(CalculatorScientific c)
        {
            if (c.SecondNumber == 0)
            {
                Console.WriteLine($"Result of {c.Operand} on {c.FirstNumber} is {c.Result}\n");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine($"Result of {c.Operand} on {c.FirstNumber} and {c.SecondNumber} is {c.Result}\n");
                Console.ReadKey();
            }
        }

        internal static void FirstMenuChoice()
        {
            string choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    {
                        CalculatorStandard cs = new CalculatorStandard();
                        cs.StdMenuChoice();
                    } break;

                case "2":
                    {
                        CalculatorScientific cs = new CalculatorScientific();
                        cs.SciMenuChoice();

                    } break;
            }
        }

        abstract internal void Add();
        abstract internal void Subtract();
        abstract internal void Multiply();
        abstract internal void Divide();

    }
}
