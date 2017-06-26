using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objective1.Exercises
{
    internal class Calculadora
    {
        /// <summary>
        /// Número de iterações
        /// </summary>
        public int Iterations { get; set; }

        /// <summary>
        /// Flag que indica se o processamento deve ser paralelo
        /// </summary>
        public bool Parallelize { get; set; }

        public void Run()
        {
            TimeSpan elapsedTime = DateTime.Now.TimeOfDay;

            Console.WriteLine($"Iniciando cálculo de {Iterations} iterações");

            if (Parallelize)
            {
                Parallel.For(0, Iterations, i =>
                {
                    Calculate();
                });
            }
            else
            {
                for (int i = 0; i < Iterations; i++)
                {
                    Calculate();
                }
            }

            elapsedTime = DateTime.Now.TimeOfDay.Subtract(elapsedTime);

            Console.WriteLine($"Execução concluída em {elapsedTime.ToString("h'h 'm'm 's's'")}");
        }

        private int Calculate()
        {
            Random rd = new Random();
            Thread.Sleep(1000);
            return rd.Next() * rd.Next();
        }
    }
}