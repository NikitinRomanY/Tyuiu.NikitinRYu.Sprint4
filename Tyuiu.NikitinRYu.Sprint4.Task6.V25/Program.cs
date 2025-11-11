using Tyuiu.NikitinRYu.Sprint4.Task6.V25.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Теннис, Футбол, Крикет, Баскетбол,          *");
            Console.WriteLine("* Бейсбол, Регби, Хоккей], используя класс Array подсчитайте количество   *");
            Console.WriteLine("* элементов, длина которых больше 6.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = ["Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей"];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] = {array[i]} (длина: {array[i].Length})");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Количество элементов с длиной > 6 = {result}");

            Console.ReadKey();
        }
    }
}