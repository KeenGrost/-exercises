using System;
using System.Globalization;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawSnake(5);
            DrawSnake(20);
            DrawZiggurat(6);
            FizzBuzz();
        }

        private static void DrawSnake(int width)
        {
            int value = 1;
            int[,] resultMatrix = new int[width,width];
            int i = 0;
            int j = 0;
            int currentWidth = width;
            int currentCircle = 1;



            while (currentWidth > 0)
            {
                // draw ring snake tale

                // move right
                //
                while (i < currentWidth)
                {
                    resultMatrix[i++, j] = value++;
                }
                i--;
                j++;

                // move down
                //
                while (j < currentWidth)
                {
                    resultMatrix[i, j++] = value++;
                }
                j--;
                i--;

                // move left
                //
                int columnStop = currentCircle - 2;
                while (i > columnStop)
                {
                    resultMatrix[i--, j] = value++;
                }

                i++;
                j--;

                // move up
                //
                int rowStop = currentCircle-1;
                while (j > rowStop)
                {
                    resultMatrix[i, j--] = value++;
                }

                i++; // move position right
                j++; // move position down
                currentWidth -= 1; // decrease width for 2 points
                 currentCircle++;
            }

            j = 0;
            // print result matrix
            while (j < width)
            {
                i = 0;
                while (i < width)
                {
                    
                    string cell = resultMatrix[i, j].ToString();
                    while ((i != width - 1) && (cell.Length < (Math.Pow(width,2).ToString(CultureInfo.InvariantCulture).Length)+1))
                    {
                        cell += " ";
                    }
                    Console.Write(cell);
                    i++;
                }
                Console.WriteLine();
               j++;
            }

        }


        private static void DrawZiggurat(int width)
        {
            Console.WriteLine($"Hello Ziggurat! {width}");
        }



        private static void FizzBuzz()
        {
            Console.WriteLine($"Hello FizzBuzz!");
        }

    }
}
