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
        public static void Main(string[] args)
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task<int>.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task<int>.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("2");
                return 2;
            });

            tasks[2] = Task<int>.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAny(tasks);

            Console.WriteLine($"Task ganhadora:  {tasks.Where(x => x.Status == TaskStatus.RanToCompletion).FirstOrDefault().Id}");

            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.Read();
        }
    }
}