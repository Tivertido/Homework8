// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6


Random random = new Random();

        int[,] array = new int[5, 5];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }

        Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int element = array[i, j];

                if (frequencyDictionary.ContainsKey(element))
                {
                    frequencyDictionary[element]++;
                }
                else
                {
                    frequencyDictionary[element] = 1;
                }
            }
        }

        Console.WriteLine("Частотный словарь:");
        foreach (var entry in frequencyDictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }