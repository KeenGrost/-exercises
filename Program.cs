using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawSnake(5);
            DrawZiggurat(6);
        }

        private static void DrawSnake(int width)
        {
            Console.WriteLine($"Hello Snake! {width}");
        }
        private static void DrawZiggurat(int width)
        {
            Console.WriteLine($"Hello Ziggurat! {width}");
        }
    }
}
