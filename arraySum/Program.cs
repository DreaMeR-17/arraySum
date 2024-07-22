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

            int[,] numbers = 
            {
                { 3,5,6 },
                { 6,7,4 },
                { 9,1,1 }
            };

            Console.WriteLine("Дана исходная матрица: ");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                sum += (numbers[lineIndex, i]);
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                compositionValue *= numbers[j, columnIndex];
            }

            Console.WriteLine($"\nСумма строки {lineIndex + 1} = {sum} ");
            Console.WriteLine($"\nПроизведение столбца {columnIndex + 1} = {compositionValue}");
        }
    }
}
