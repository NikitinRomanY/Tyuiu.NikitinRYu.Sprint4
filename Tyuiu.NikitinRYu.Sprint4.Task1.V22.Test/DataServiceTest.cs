using Tyuiu.NikitinRYu.Sprint4.Task1.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            int wait = 5 * 3 * 9 * 9 * 9 * 3 * 9;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
