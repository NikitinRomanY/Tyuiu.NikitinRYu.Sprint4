using Tyuiu.NikitinRYu.Sprint4.Task5.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
               { -5, 2, -3, 7, -1 },
               { 4, -2, 6, -8, 0 },
               { -7, 9, 1, -4, 3 },
               { 8, -6, 5, -3, 2 },
               { -1, 4, -2, 9, -5 }
            };

            int wait = 12;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}
