using Tyuiu.DanilovAS.Sprint2.Task1.V17.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            bool[] res = new bool[6];
            res[0] = true;
            res[1] = false;
            res[2] = true;
            res[3] = true;
            res[4] = true;
            res[5] = false;

            bool[] wait = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
