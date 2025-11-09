using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NikitinRYu.Sprint4.Task2.V24.Lib
{
    public class DataService : ISprint4Task2V24
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0) // проверка на нечётность
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
