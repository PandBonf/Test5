using System;
using System.Threading;

namespace test5
{
    class Program
    {
        static void Main(string[] args)
        {

            TransformToElephant();
            Console.WriteLine("Муха");

        }


        static void TransformToElephant()
        {
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                Console.WriteLine("Слон");
            });

            thread.Start();
        }
    

    }
}
