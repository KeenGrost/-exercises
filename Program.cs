using System;
using System.Globalization;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawSnake(5);
            DrawZigguratSpiral(5);
            DrawZigguratSquare(6);
            FizzBuzz();
        }

        private static void DrawSnake(int width)
        {
            int value = 1;
            int[,] resultMatrix = new int[width, width];
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
                int rowStop = currentCircle - 1;
                while (j > rowStop)
                {
                    resultMatrix[i, j--] = value++;
                }

                i++; // move position right
                j++; // move position down
                currentWidth -= 1; // decrease width for 2 points
                currentCircle++;
            }

            
            // print result matrix
            //
            j = 0;
            int cellLengthMax = Math.Pow(width, 2).ToString(CultureInfo.InvariantCulture).Length + 1;
            while (j < width)
            {
                i = 0;
                while (i < width)
                {

                    string cell = resultMatrix[i, j].ToString();

                    // each cell has the same length
                    while ((i != width - 1) && (cell.Length < cellLengthMax))
                    {
                        cell += " ";
                    }
                    Console.Write(cell);
                    i++;
                }
                Console.WriteLine();
                j++;
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Draw ziggurat spiral like a snake
        /// </summary>
        /// <param name="width"></param>
        private static void DrawZigguratSpiral(int width)
        {
            int[,] resultMatrix = new int[width, width];
            int i = 0;
            int j = 0;
            int currentWidth = width;
            int currentCircle = 1;

            while (currentWidth > 0)
            {
                // draw ring 
                // move right
                //
                while (i < currentWidth)
                {
                    resultMatrix[i++, j] = currentCircle;
                }
                i--;
                j++;

                // move down
                //
                while (j < currentWidth)
                {
                    resultMatrix[i, j++] = currentCircle;
                }
                j--;
                i--;

                // move left
                //
                int columnStop = currentCircle - 2;
                while (i > columnStop)
                {
                    resultMatrix[i--, j] = currentCircle;
                }
                i++;
                j--;

                // move up
                //
                int rowStop = currentCircle - 1;
                while (j > rowStop)
                {
                    resultMatrix[i, j--] = currentCircle;
                }

                i++; // move position right
                j++; // move position down
                currentWidth -= 1; // decrease width for 2 points
                currentCircle++;
            }


            // print result matrix
            //
            j = 0;
            int cellLengthMax = Math.Pow(width, 2).ToString(CultureInfo.InvariantCulture).Length + 1;
            while (j < width)
            {
                i = 0;
                while (i < width)
                {

                    string cell = resultMatrix[i, j].ToString();

                    // each cell has the same length
                    while ((i != width - 1) && (cell.Length < cellLengthMax))
                    {
                        cell += " ";
                    }
                    Console.Write(cell);
                    i++;
                }
                Console.WriteLine();
                j++;
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Draw ziggurat square
        /// </summary>
        /// <param name="width"></param>
        private static void DrawZigguratSquare(int width)
        {
            int[,] resultMatrix = new int[width, width];
            int i;
            int j;
            int currentWidth = width;
            int currentCircle = 1;

            while (currentWidth > 0)
            {
               j = currentCircle - 1;
                while (j < currentWidth)
                {
                    i = currentCircle - 1;
                    while (i < currentWidth)
                    {
                        resultMatrix[i, j] = currentCircle;
                        i++;
                    }
                    j++;
                }
                currentWidth -= 1; // decrease width for 2 points
                currentCircle++;
            }


            // print result matrix
            //
            j = 0;
            int cellLengthMax = Math.Pow(width, 2).ToString(CultureInfo.InvariantCulture).Length + 1;
            while (j < width)
            {
                i = 0;
                while (i < width)
                {

                    string cell = resultMatrix[i, j].ToString();

                    // each cell has the same length
                    while ((i != width - 1) && (cell.Length < cellLengthMax))
                    {
                        cell += " ";
                    }
                    Console.Write(cell);
                    i++;
                }
                Console.WriteLine();
                j++;
            }
            Console.WriteLine();

        }



        private static void FizzBuzz()
        {
            Console.WriteLine($"Hello FizzBuzz!");
        }

    }
}
