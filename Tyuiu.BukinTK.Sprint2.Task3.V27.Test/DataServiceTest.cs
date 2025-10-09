using Tyuiu.BukinTK.Sprint2.Task3.V27.Lib;

namespace Tyuiu.BukinTK.Sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double res = ds.Calculate(x);
            double wait = 1.0;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.0;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -1.0;
            double res = ds.Calculate(x);
            double wait = 1.0;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -32.0;
            double res = ds.Calculate(x);
            double wait = 1.0;

            Assert.AreEqual(wait, res);
        }
    }
}
