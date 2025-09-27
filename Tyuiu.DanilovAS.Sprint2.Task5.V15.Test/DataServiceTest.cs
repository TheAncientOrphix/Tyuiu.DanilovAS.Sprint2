using Tyuiu.DanilovAS.Sprint2.Task5.V15.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDayName()
        {
            DataService ds = new DataService();
            int k = 9;
            var wait = "Вторник";
            var res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
    }
}
