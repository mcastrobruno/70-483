using Objective1.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objective1
{
    internal class Program
    {
        private static TaskGanhadora _ganhadora = new TaskGanhadora();
        private static Calculadora _calculadora = new Calculadora();

        public static void Main(string[] args)
        {
            //_ganhadora.Run();
            _calculadora.Iterations = 10;
            _calculadora.Parallelize = true;
            _calculadora.Run();
            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.Read();
        }
    }
}