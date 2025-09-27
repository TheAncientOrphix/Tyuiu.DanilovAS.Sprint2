using Tyuiu.DanilovAS.Sprint2.Task7.V12.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.6;
            var wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestTwoCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 2;
            var wait = false;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
