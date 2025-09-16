using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            //x = 233. y = 122
            bool[] result = new bool[6];//True, False, True, False, True, False)
            result[0] = x == y + 111;
            result[1] = x != y + 111;
            result[2] = y < x;
            result[3] = y > x;
            result[4] = y <= x;
            result[5] = y >= x;

            return result;
        }
    }
}
