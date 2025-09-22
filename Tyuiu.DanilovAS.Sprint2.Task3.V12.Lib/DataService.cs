using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double res;

            if (x > 1)
            {
                res = x + Math.Pow((x + 1 / (x - 1)), x);
            }

            else if (x > -16 && x < 2)
            {
                res = Math.Pow(7 + 5/x*x,x);
            }

            else if (x == 0)
            {
                res = 1 + Math.Cos(Math.Sqrt(x + 1));            
            }

            else
            {
                res = x + 10 * x - (1 / x);
            }

            return Math.Round(res,3);
        }
    }
}
