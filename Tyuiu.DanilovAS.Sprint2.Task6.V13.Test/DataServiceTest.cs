using Tyuiu.DanilovAS.Sprint2.Task6.V13.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2025;
            int m = 1;
            int n = 31;
            var wait = "1.02.2025";
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
