using Tyuiu.DanilovAS.Sprint2.Task3.V12.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(res, wait);
        }
    }
}