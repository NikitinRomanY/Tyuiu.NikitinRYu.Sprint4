using Tyuiu.NikitinRYu.Sprint4.Task3.V7.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {9, 6, 9, 3, 7},
                {3, 3, 3, 8, 2},
                {2, 1, 3, 5, 2},
                {6, 2, 3, 2, 5},
                {4, 5, 6, 9, 5}
            };

            int wait = 15; // Подсчитаем нечётные элементы
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
