using Tyuiu.DanilovAS.Sprint2.Task0.V1.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetCompareOperations()
        {
            DataService ds = new DataService();
            //x = 233. y = 122
            int x = 233; int y = 122;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true,false,true,false,true,false};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
