using System;

namespace arraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;                     
            int compositionValue = 1;
            int columnIndex = 0;
            int lineIndex = 1;

            int[,] array = new int[3, 3]
            {
                { 3,5,6 },
                { 6,7,4 },
                { 9,1,1 }
            };

            Console.WriteLine("Дана исходная матрица: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += (array[lineIndex, i]);
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                compositionValue *= array[j, columnIndex];
            }

            Console.WriteLine("\nСумма второй строки: " + sum);
            Console.WriteLine("\nПроизведение первого столбца: " + compositionValue);
        }
    }
}
