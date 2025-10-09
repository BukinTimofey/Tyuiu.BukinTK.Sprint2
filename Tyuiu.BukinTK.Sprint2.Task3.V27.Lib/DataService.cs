using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BukinTK.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                y = x * Math.Pow(x + 1 / Math.Sin(Math.Pow(x, 2)) + x - 0.5, x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 4 / Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            }
            else if (x > -31 && x < 0)
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), 2);
            }
            else
            {
                y = x + Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3) - (2 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
