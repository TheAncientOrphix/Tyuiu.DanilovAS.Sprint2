using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = a > b | d <= c;
            result[1] = a == b & c == d;
            result[2] = a < b || c > d;
            result[3] = a + b < c && d - a < c;
            result[4] = !(a+d<c);
            result[5] = a + b != c ^ c + b < c + d;
            return result;
        }
    }
}
