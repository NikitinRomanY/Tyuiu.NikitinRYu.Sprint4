using Tyuiu.NikitinRYu.Sprint4.Task0.V19.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать произведение  *");
            Console.WriteLine("* нечётных элементов массива. {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Console.WriteLine("Исходный массив: {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetMultOddArrEl(array);

            Console.WriteLine($"Произведение нечётных элементов = {result}");

            Console.ReadKey();
        }
    }
}
