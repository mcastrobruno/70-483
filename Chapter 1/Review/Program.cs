using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Teste
    {
        public int valor;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            Console.WriteLine("** VALUE TYPE **");
            int valor = 5;
            Console.WriteLine($"Valor antes do métodos: {valor}");
            ValueType(valor);
            Console.WriteLine($"Valor após multiplicação: {valor}");

            //Reference Type
            Console.WriteLine("** REFERENCE TYPE **");
            Teste obj = new Teste();
            obj.valor = 5;
            Console.WriteLine($"Valor antes do métodos: {obj.valor}");
            ReferenceType(obj);
            Console.WriteLine($"Valor após multiplicação: {obj.valor}");

            Console.Read();
        }


        static void ValueType(int valor)
        {
            valor = valor * 2;
        }

        static void ReferenceType(Teste obj)
        {
            obj.valor = obj.valor * 2;
        }
    }
}
