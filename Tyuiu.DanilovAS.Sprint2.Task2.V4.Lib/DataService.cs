using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool result;

            if (((x >= 3) && (x <= 5)) && ((y == 3) || (y == 4)))
            {
                result = true;
            }
            else if (((x >= 5) && (x <= 9)) && (y >= 5) || (y <= 7))
            {
                result = true;
            }
            else if ((x == 9) && (y >= 3) && (y <= 12))
            {
                result = true;
            }
            else if ((x >= 8) && (x <= 10) && (y >= 8) && (y <= 12))
            {
                result = true;
            }
            else if (x == 10 || x == 11 && (y == 11))
            {
                result = true;
            }
            else if ((y == 11) && (x == 5 || x == 6))
            {
                result = true;
            }
            else if ((x == 4) && (y >=7 && y<=13))
            {
                result = true;
            }
            else if (y == 11 && x == 3)
            {
                result = true;
            }
            else if(x == 3 && y == 7)
            {
                result = true;
            }
            else if ((x == 12) && (y >= 3) && (y <= 8))
            {
                result = true;
            }
            else if ((x == 13) && (y >= 6) && (y <= 8))
            {
                result = true;
            }
            else
            {
                result = false;
            }
                return result;
        }
    }
}
