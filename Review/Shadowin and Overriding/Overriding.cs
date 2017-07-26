using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Shadowin_and_Overriding
{
    public class Overriding
    {
        public virtual void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }

    public class OverridingDerived : Overriding
    {
        public override void SayHello(string name)
        {
            Console.WriteLine($"Olá {name}");
        }
    }
}
