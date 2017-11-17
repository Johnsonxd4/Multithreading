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
        }

        private static void Start () {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine ($"iteração n° {i} por thread paralela");
                Thread.Sleep(500);
            }
        }
    }
}