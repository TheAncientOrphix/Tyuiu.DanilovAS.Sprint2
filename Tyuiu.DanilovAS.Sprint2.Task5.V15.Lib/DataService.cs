using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DanilovAS.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            string res;
            double day = (k - 1) % 7;
            if (k < 0 || k > 365)
            {
                res = "Ошибка";
            }

            else
            {
                switch (day)
                {
                    case 0:
                        res = "Понедельник";
                        break;

                    case 1:
                        res = "Вторник";
                        break;

                    case 2:
                        res = "Среда";
                        break;

                    case 3:
                        res = "Четверг";
                        break;

                    case 4:
                        res = "Пятница";
                        break;
                    
                    case 5:
                        res = "Суббота";
                        break;

                    case 6:
                        res = "Воскресенье";
                        break;

                    default:
                        res = "Неизвестная ошибка";
                        break;
                }
            }
            return res;
        }
    }
}
