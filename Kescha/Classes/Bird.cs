using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kescha.Classes
{
    public class Bird : Animal
    {
        public Bird(string name,int age)
            :base(name,age) 
        { }
        public override void Greet2(string userName)
        {
            Console.WriteLine("Abstracted method implemented");
        }
    }
}
