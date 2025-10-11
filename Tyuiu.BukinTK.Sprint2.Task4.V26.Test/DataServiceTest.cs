using Tyuiu.BukinTK.Sprint2.Task4.V26.Lib;

namespace Tyuiu.BukinTK.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);
            double wait = 12.0;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);
            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}
