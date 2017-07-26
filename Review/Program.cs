using Review.Shadowin_and_Overriding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        #region "Shadowing"
        private static Shadowing _shadowing = new Shadowing();
        private static ShadowingDerived _shadowingDerived = new ShadowingDerived();
        private static Shadowing _shadowingExt = new ShadowingDerived();
        #endregion

        #region "Overriding"
        private static Overriding _overriding = new Overriding();
        private static OverridingDerived _overridingDerived = new OverridingDerived();
        private static Overriding _overridingExt = new OverridingDerived();


        #endregion

        static void Main(string[] args)
        {
            int option = -1;

            while (option != 0)
            {
                Console.WriteLine("1 - Shadowing");
                Console.WriteLine("2 - Overriding");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("Digite a opção desejada: ");

                if (!int.TryParse(Console.ReadLine()[0].ToString(), out option))
                {
                    Console.WriteLine("Caractere deve ser númerico [0-9]");
                    option = -1;
                }


                switch (option)
                {
                    case 1:
                        _shadowing.SayHello("Bruno Castro");
                        _shadowingDerived.SayHello("Bruno Castro");
                        var teste =_shadowingExt.SayHello("Bruno Castro");
                        break;
                    case 2:
                        _overriding.SayHello("Bruno Castro");
                        _overridingDerived.SayHello("Bruno Castro");
                        _overridingExt.SayHello("Bruno Castro");
                        break;
                    default:
                        break;
                }

                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}
