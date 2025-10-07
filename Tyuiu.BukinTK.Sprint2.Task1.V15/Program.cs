using Tyuiu.BukinTK.Sprint2.Task1.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 415;
        int b = 616;
        int c = 134;
        int d = 127;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
        Console.WriteLine("D = " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}