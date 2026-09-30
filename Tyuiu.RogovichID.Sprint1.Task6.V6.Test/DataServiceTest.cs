using Tyuiu.RogovichID.Sprint1.Task6.V6.Lib;
namespace Tyuiu.RogovichID.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "раз два три";
            var res = ds.DeleteFirstLetter(a);
            Assert.AreEqual("аз ва ри", res);
        }
    }
}
