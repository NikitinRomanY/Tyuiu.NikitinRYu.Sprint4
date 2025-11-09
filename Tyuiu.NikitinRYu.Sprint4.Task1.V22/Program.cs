using Tyuiu.NikitinRYu.Sprint4.Task1.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9. Подсчитать произведение *");
            Console.WriteLine("* нечётных элементов массива.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[12];

            Console.WriteLine("Введите 12 элементов массива (целые числа от 2 до 9):");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Введённый массив:");
            Console.WriteLine("{" + string.Join(", ", array) + "}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Произведение нечётных элементов = {result}");

            Console.ReadKey();
        }
    }
}