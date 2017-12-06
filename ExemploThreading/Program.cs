using System;
using System.Threading;

namespace ExemploThreading {
    class Program {
        static void Main (string[] args) {
            
            Thread thread = new Thread (new ThreadStart (Start));
            thread.Start();

            for (int i = 0; i < 5; i++) {
                Console.WriteLine ($"iteração n° {i} por thread Principal");
                Thread.Sleep(500);
            }

            thread.Join();

            Console.WriteLine("Esta linha será executada somente quando a thread paralela terminar seu processo");

            ThreadParametrizada obj = new ThreadParametrizada();
            Thread t = new Thread(new ParameterizedThreadStart(obj.EscreverValor));
            t.Start("Passando parametro para a Thread");
            Console.WriteLine("Continua alguma execução");
            t.Join();


            UtilizandoPoolDeThreads();

            Console.ReadKey();
        }

        private static void UtilizandoPoolDeThreads()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Método executado por uma thread do pool de threads");
                
            });
        }

        private static void Start () {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine ($"iteração n° {i} por thread paralela");
                Thread.Sleep(500);
            }

        }
    }
}