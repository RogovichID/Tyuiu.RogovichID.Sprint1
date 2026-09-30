using Tyuiu.RogovichID.Sprint1.Task3.V10.Lib;
namespace Tyuiu.RogovichID.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 10.25;
            string res = ds.NumberToMoney(x);

            Assert.AreEqual("10,25 руб. - это 10 руб. 25 коп.", res);
        }
    }
}
