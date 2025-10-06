using Tyuiu.BukinTK.Sprint2.Task0.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 333;
        int y = 324;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i<6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}