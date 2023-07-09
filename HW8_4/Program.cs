// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];

        FillSpiral(matrix);

        PrintMatrix(matrix);

    static void FillSpiral(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int value = 1;
        int topRow = 0, bottomRow = rows - 1, leftColumn = 0, rightColumn = columns - 1;

        while (value <= rows * columns)
        {
            for (int i = leftColumn; i <= rightColumn && value <= rows * columns; i++)
            {
                matrix[topRow, i] = value++;
            }
            topRow++;

            for (int i = topRow; i <= bottomRow && value <= rows * columns; i++)
            {
                matrix[i, rightColumn] = value++;
            }
            rightColumn--;

            for (int i = rightColumn; i >= leftColumn && value <= rows * columns; i--)
            {
                matrix[bottomRow, i] = value++;
            }
            bottomRow--;

            for (int i = bottomRow; i >= topRow && value <= rows * columns; i--)
            {
                matrix[i, leftColumn] = value++;
            }
            leftColumn++;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }