using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Shadowin_and_Overriding
{
    public class Shadowing
    {
        public string SayHello(string name)
        {
            string message = $"Hello {name}";
            Console.WriteLine(message);
            return message;
        }
    }

    public class ShadowingDerived : Shadowing
    {
        public new void SayHello(string name)
        {
            Console.WriteLine($"Olá {name}");
        }
    }
}
