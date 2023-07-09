// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Упорядоченный массив по убыванию:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }


// второй вариант с рандомным массивом
// Random random = new Random();

//         int[,] array = new int[3, 4];
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         // Заполнение массива случайными значениями
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array[i, j] = random.Next(10, 100);
//             }
//         }

//         // Вывод неупорядоченного массива
//         Console.WriteLine("Неупорядоченный массив:");
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }

//         // Упорядочивание элементов каждой строки по убыванию
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 for (int k = j + 1; k < cols; k++)
//                 {
//                     if (array[i, k] > array[i, j])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
//             }
//         }

//         // Вывод упорядоченного массива
//         Console.WriteLine("Упорядоченный массив по убыванию:");
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }