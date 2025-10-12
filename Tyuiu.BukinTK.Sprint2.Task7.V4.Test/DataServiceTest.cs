using Tyuiu.BukinTK.Sprint2.Task7.V4.Lib;

namespace Tyuiu.BukinTK.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.8;
            double y = 0.3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
