using Tyuiu.BukinTK.Sprint2.Task7.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (res)
        {
            Console.WriteLine("Точка находиться в окружности");
        } else
        {
            Console.WriteLine("Точка не находиться в окружности");
        }
        Console.ReadKey();
    }
}