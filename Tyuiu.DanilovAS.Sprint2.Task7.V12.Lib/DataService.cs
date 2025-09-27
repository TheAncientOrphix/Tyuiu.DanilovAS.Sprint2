using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            double y1 = Math.Pow(x, 2);
            double y2 = 2 - x;

            if ((x >= 0 && x <= 1 && y >= 0 && y <= x * x) || (x <= -2 && y >= 0 && y <= 2 - x))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
