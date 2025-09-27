using Tyuiu.DanilovAS.Sprint2.Task4.V12.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 4;
            var wait = 8.822;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
