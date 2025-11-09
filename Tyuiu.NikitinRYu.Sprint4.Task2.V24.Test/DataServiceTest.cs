using Tyuiu.NikitinRYu.Sprint4.Task2.V24.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 5, 7, 4, 8, 9, 6, 5, 9, 4, 7, 8, 9 };

            int wait = 5 + 7 + 9 + 5 + 9 + 7 + 9;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
