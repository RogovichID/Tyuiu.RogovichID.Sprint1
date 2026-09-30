using Tyuiu.RogovichID.Sprint1.Task5.V2.Lib;
namespace Tyuiu.RogovichID.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 68;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(20, res);
        }
    }
}
