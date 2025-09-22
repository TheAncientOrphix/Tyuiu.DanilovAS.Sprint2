using Tyuiu.DanilovAS.Sprint2.Task2.V4.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 6;
            var res = ds.CheckDotInShadedArea(x, y);
            var wait = true;
            Assert.AreEqual(wait, true);
        }
    }
}
