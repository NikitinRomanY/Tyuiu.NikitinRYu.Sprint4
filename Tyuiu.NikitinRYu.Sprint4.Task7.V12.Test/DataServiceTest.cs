using Tyuiu.NikitinRYu.Sprint4.Task7.V12.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 4;
            string value = "658932125478";

            int wait = 30;
            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(wait, res);
        }
    }
}
