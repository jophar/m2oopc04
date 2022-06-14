using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User usr01 = new User("Milena", "123");


            if (usr01.Validate("Milena", "123"))
                Console.WriteLine("Utilizador autenticado");
            else
            {
                usr01.Exit();
            }

            Console.ReadLine();

        }
    }
}
