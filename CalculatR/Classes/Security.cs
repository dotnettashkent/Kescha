using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatR.Classes
{
    public class Security
    {
        public void CheckPassword() 
        { 
            string password = "";
            do
            {
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            }
            while(password != "pa$$word");
        }
    }
}
