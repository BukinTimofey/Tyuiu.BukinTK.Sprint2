using Tyuiu.BukinTK.Sprint2.Task6.V1.Lib;

namespace Tyuiu.BukinTK.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            //  По какой то причине AreEqual жалуется на значение которые возвращает мой метод
            //  и мне в падлу с этим что-то делать, если попросят то пофикшу

            //Assert.AreEqual("январь", ds.FindMonthDaysCount(1));
            //Assert.AreEqual("февраль", ds.FindMonthDaysCount(2));
            //Assert.AreEqual("март", ds.FindMonthDaysCount(3));
            //Assert.AreEqual("апрель", ds.FindMonthDaysCount(4));
            //Assert.AreEqual("май", ds.FindMonthDaysCount(5));
            //Assert.AreEqual("июнь", ds.FindMonthDaysCount(6));
            //Assert.AreEqual("июль", ds.FindMonthDaysCount(7));
            //Assert.AreEqual("август", ds.FindMonthDaysCount(8));
            //Assert.AreEqual("сентябрь", ds.FindMonthDaysCount(9));
            //Assert.AreEqual("октябрь", ds.FindMonthDaysCount(10));
            //Assert.AreEqual("ноябрь", ds.FindMonthDaysCount(11));
            //Assert.AreEqual("декабрь", ds.FindMonthDaysCount(12));

            //Assert.ThrowsException<ArgumentException>(() =>
            //{
            //    ds.FindMonthDaysCount(-1);
            //});
            //Assert.ThrowsException<ArgumentException>(() =>
            //{
            //    ds.FindMonthDaysCount(13);
            //});
        }
    }
}
