using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class User : IAutentication
    {
        // Properties
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        
        // Constructors

        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
        }

        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }


        // Methods

        public void Exit()
        {
            Console.WriteLine("A autenticação falhou\nO programa vai terminar");
            Console.ReadKey();
        }

        public void Message(string message, string startLine = "", string endLine = "")
        {

        }

        public bool Validate(string uName, string uPassword)
        {
            if (uName.Equals("Milena") && uPassword.Equals("123"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
