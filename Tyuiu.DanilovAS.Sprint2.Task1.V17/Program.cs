using Tyuiu.DanilovAS.Sprint2.Task1.V17.Lib;
namespace Tyuiu.DanilovAS.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, которая *");
            Console.WriteLine("* вернет логическую последовательность(массив):True, False, True, True,   *");
            Console.WriteLine("* True, False). при a = 135, b = 123, c = 455, d = 321                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* a = 135, b = 123, c = 455, d = 321                                      *");
            Console.WriteLine("***************************************************************************");

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            bool[] result = new bool[6];

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Ответ:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}
