using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string result;
            int daysInMonth;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        daysInMonth = 31;
                        break;
                    }

                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        daysInMonth = 30;
                        break;
                    }

                case 2:
                    {
                        daysInMonth = 29;
                        break;
                    }

                default:
                    {
                        return "Ошибка"; break;
                    }

            }
            daysInMonth++;

            if (n > daysInMonth)
            {
                n = 1;
                m++;
            }

            else
            {
                n++;
            }

            if (m > 12)
            {
                m = 1;
                g++;
            }

            string mounth;

            if (m < 10)
            {
                mounth = $"0{m}";
            }
            else
            {
                mounth = Convert.ToString(m); 
            }

            string days;

            if (n < 10)
            {
                days = $"0{n}";
            }
            else
            {
                days = Convert.ToString(n);
            }

            result = $"{days}.{mounth}.{g}";
            return result;
        }
    }
}
