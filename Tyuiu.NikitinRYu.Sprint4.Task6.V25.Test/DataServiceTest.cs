using Tyuiu.NikitinRYu.Sprint4.Task6.V25.Lib;

namespace Tyuiu.NikitinRYu.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = ["Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей"];

            int wait = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
