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
            int g = 2024;
            int m = 9;
            int n = 8;
            var wait = "09.09.2024";
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
