using System;

public class Search {
        static void Main(string[] args) {
            var array = new int[6000]; // Создание массива

            var random = new Random(); // Заполнение массива
            for (var i = 0; i < array.Length; i++)
                array[i] = random.Next(int.MaxValue);

            Console.Write("Ввести элемент поиска: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int index = SimpleSearch(array, x);

            Console.WriteLine(index);
            Console.ReadKey();
        }

        static int SimpleSearch(int[] array, int x)
        {
            int i = 0;
            while (i < array.Length && array[i] != x)
                i++;
            if (i<array.Length)
                return i;
            else
                return -1;  
        }
}
