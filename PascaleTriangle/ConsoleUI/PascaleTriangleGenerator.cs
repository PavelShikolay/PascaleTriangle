using System;

namespace ConsoleUI
{
    public static class PascalTriangleGenerator
    {
        public static void ShowTriangle(int numberOfRows)
        {
            if (numberOfRows < 0)
            {
                throw new ArgumentException(nameof(numberOfRows));
            }

            for (int i = 0; i < numberOfRows; ++i)
            {
                int[] currentRow = GetRow(i);

                AddIndent(numberOfRows, i);

                for (int j = 0; j < currentRow.Length; ++j)
                {
                    Console.Write(currentRow[j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[] GetRow(int rowNumber)
        {
            if (rowNumber < 0)
            {
                throw new ArgumentException(nameof(rowNumber));
            }

            int[] elements = new int[rowNumber + 1];

            elements[0] = 1;
           
            for (int i = 1; i < elements.Length; ++i)
            {
                elements[i] = elements[i - 1] * (rowNumber + 1 - i) / i;
            }

            return elements;
        }

        private static void AddIndent(int rowsNumber, int currentRow)
        {
            if (rowsNumber < 0)
            {
                throw new ArgumentException(nameof(rowsNumber));
            }
            if (currentRow < 0)
            {
                throw new ArgumentException(nameof(currentRow));
            }

            for (int i = 0; i < rowsNumber - currentRow; ++i)
            {
                Console.Write(" ");
            }
        }
    }
}
