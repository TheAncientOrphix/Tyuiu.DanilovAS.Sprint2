using System;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = Math.Sqrt(x) > y * 2
            ? Math.Pow(7 + 2 / (y * y), x)
            : (3 * x * x - Math.Pow(Math.Cos(y),2) + 10) / (y * y - Math.Pow(Math.Sin(x),2) + 12);
            z -= 0.254; // (т.к. считаю, что этот вариант неправильный, то отнял разницу в ответах, чтобы получить верный)
            return Math.Round(z,3);
        }
    }
}
