using Tyuiu.RogovichID.Sprint1.Task7.V10.Lib;
namespace Tyuiu.RogovichID.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            DataService ds = new DataService();
            double x = 1;
            double z = Math.Round(2 / Math.Tan(3) - Math.Log(Math.Cos(1)) / Math.Log(2), 3); 
            var res = Math.Round(ds.Calculate(x),3);
            Assert.AreEqual(z, res);

        }
    }
}
