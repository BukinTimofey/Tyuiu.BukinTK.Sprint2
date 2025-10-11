using Tyuiu.BukinTK.Sprint2.Task5.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер карты:");
        int value = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((value < 6) || (value > 14))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "Это карта " + ds.FindCardValue(value);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}