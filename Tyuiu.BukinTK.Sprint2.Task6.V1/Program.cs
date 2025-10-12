using Tyuiu.BukinTK.Sprint2.Task6.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер месяца:");
        int value = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((value < 1) || (value > 12))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "В этом месяце " + ds.FindMonthDaysCount(value) + " дней";
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}