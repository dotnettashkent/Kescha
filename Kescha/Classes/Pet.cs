using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kescha.Classes
{
    public class Pet : Animal
    {
        public Pet(string userName, int userAge)
        : base(userName, userAge)
        { }
        public override void Greet(string userName)
        {
            Console.WriteLine("Hello {0}",userName);
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine("abstract method implemented");
        }
    }
}
