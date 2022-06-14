using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal interface IAutentication
    {
        string UserName { get; }
        string UserPassword { get; }

        bool Validate(string userName, string userPassword);
        void Exit();
    }
}
