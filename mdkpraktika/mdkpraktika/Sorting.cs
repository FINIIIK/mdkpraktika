using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdkpraktika {
    internal class Sorting {
        static void Main(string[] args) {
            Timing timer = new Timing(); //Создание таймера на основе класса Timing


            //СОРТИРОВКА





            /*var array = new int[6000]; //Создание массива

            var random = new Random(); // Заполнение массива
            for (var i = 0; i < array.Length; i++)
                array[i] = random.Next(int.MaxValue);*/


            //var stopWatch = Stopwatch.StartNew(); //Запуск таймера
            //timer.StartTime(); //Запуск таймера

            //Тут убрать комментарий с нужного способа, и убрать комментарий
            //с метода который ему соответствует

            //SortSelection(array); //Выполнение сортировки ПРОСТЫМ ВЫБОРОМ

            //SortInsertion(array); //Выполнение сортировки ПРОСТЫМИ ВКЛЮЧЕНИЯМИ (Выполняется быстрее,
            //нужен массив в 1000 раз больше чем выбором, иначе время выполнения 0мс)

            //BubleSort(array); //Выполнение сортировки ПРОСТЫМ ОБМЕНОМ (Очень медленная, при одном размере
            //массива с сортировкой простым выбором, разница почти в 3 раза)

            //timer.StopTime(); //Завершение таймера
            //stopWatch.Stop(); //Выключение таймера

            //Console.Write($"Время выполнения: {timer.Result().ToString()} ms"); //Вывод результата работы таймера
            //Console.Write($"Время выполнения: {stopWatch.ElapsedMilliseconds.ToString()} ms"); //Вывод результата работы таймера







            //ПРЯМОЙ ПОИСК

            /* var array = new int[60000000]; //Создание массива

             var random = new Random(); // Заполнение массива
             for (var i = 0; i < array.Length; i++)
                 array[i] = random.Next(10000000);

             Console.Write("Ввести элемент поиска: ");
             int x = Convert.ToInt32(Console.ReadLine());

             Timing timer = new Timing(); //Создание таймера на основе класса Timing

             var stopWatch = Stopwatch.StartNew(); //Запуск таймера
             timer.StartTime(); //Запуск таймера

            int index = SimpleSearch(array, x); //Выполнение БИНАРНОГО ПОИСКА

            timer.StopTime(); //Завершение таймера
            stopWatch.Stop();

            Console.WriteLine(index);
            Console.Write($"Время выполнения: {stopWatch.Elapsed.ToString()} ms"); //Вывод результата работы таймера
             Console.Write($"Время выполнения: {timer.Result().ToString()} ms"); //Вывод результата работы таймера*/







            // БИНАРНЫЙ ПОИСК


            /*var array = new int[60000000]; //Создание массива

            var random = new Random(); // Заполнение массива
            for (var i = 0; i < array.Length; i++)
                array[i] = random.Next(10000);
            
            SortInsertionForSearch(array);

            Console.Write("Ввести элемент поиска: ");
            int x = Convert.ToInt32(Console.ReadLine());

            var stopWatch = Stopwatch.StartNew(); //Запуск таймера
            timer.StartTime(); //Запуск таймера

            int index = BinarySearch(array, x); //Выполнение БИНАРНОГО ПОИСКА

            timer.StopTime(); //Завершение таймера
            stopWatch.Stop();

            Console.WriteLine(index);
            Console.Write($"Время выполнения: {stopWatch.Elapsed.ToString()} ms"); //Вывод результата работы таймера
            Console.Write($"Время выполнения: {timer.Result().ToString()} ms"); //Вывод результата работы таймера

            */


            Hashtable my_hashtable = new Hashtable() { //СОЗДАНИЕ ХЭШ ТАБЛИЦЫ
            {1, 1},{2, 2},{3, 3},{4, 4},{5, 5},{6, 6},{7, 7},{8, 8}};

            var stopWatch = Stopwatch.StartNew(); //Запуск таймера
            timer.StartTime(); //Запуск таймера
            my_hashtable.Contains(7);
            timer.StopTime(); //Завершение таймера
            stopWatch.Stop();

            Console.Write($"Время выполнения: {timer.Result().ToString()} ms"); //Вывод результата работы таймера
            Console.Write($"Время выполнения: {stopWatch.Elapsed.ToString()} ms"); //Вывод результата работы таймера



            Console.ReadKey();
        }








        /*private static void SortSelection(int[] array) { //Сортировка ПРОСТЫМ ВЫБОРОМ

            int N = array.Length;
            int min = 0, imin = 0, i;
            for (i = 0; i < N - 1; i++) {
                min = array[i];
                imin = i;

                for(int j = i + 1; j < N; j++) 
                    if (array[j] < min) {
                        min = array[j]; imin = j;
                    }
                if (i != imin) {
                    array[imin] = array[i];
                    array[i] = min;
                }
            }
        }*/








        /*private static void SortInsertion(int[] array) { //Сортировка ПРОСТЫМИ ВКЛЮЧЕНИЯМИ

            int tmp = array[0];
            int N = array.Length;

            for(int i = 1; i < N; i++){
                int j = i - 1;
                while (j >= 0 && tmp < array[j])
                    array[j + 1] = array[j--];

                array[j + 1] = tmp;
            }
        }*/







        /* private static void BubleSort(int[] array) { //Сортировка ПРОСТЫМ ОБМЕНОМ

             int N = array.Length;

             for(int i = 1; i < N; i++){
                 for (int j = N - 1; j >= i; j--)
                     if (array[j - 1] > array[j]){
                         int t = array[j - 1];
                         array[j - 1] = array[j];
                         array[j] = t;
                     }
             }
         }*/






        /*static int SimpleSearch(int[] array, int x) //ПРЯМОЙ ПОИСК
        {
            int i = 0;
            while (i < array.Length && array[i] != x)
                i++;
            if (i < array.Length)
                return i;
            else
                return -1;
        }*/





        /* private static void SortInsertionForSearch(int[] array) { //Сортировка ПРОСТЫМИ ВКЛЮЧЕНИЯМИ ДЛЯ БИНАРНОГО ПОИСКА

             int tmp = array[0];
             int N = array.Length;

             for (int i = 1; i < N; i++)
             {
                 int j = i - 1;
                 while (j >= 0 && tmp < array[j])
                     array[j + 1] = array[j--];

                 array[j + 1] = tmp;
             }
         }
         static int BinarySearch(int[] array, int x) //БИНАРНЫЙ ПОИСК
         {
             int middle, left = 0, right = array.Length - 1;
             do
             {
                 middle = (left + right) / 2;
                 if (x > array[middle])
                     left = middle + 1;
                 else
                     right = middle - 1;
             }
             while ((array[middle] != x) && (left <= right));
             if (array[middle] == x)
                 return middle;
             else
                 return -1;

         }*/





    }
}