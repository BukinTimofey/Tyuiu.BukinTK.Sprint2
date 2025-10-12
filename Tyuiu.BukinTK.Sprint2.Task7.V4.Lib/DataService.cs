using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BukinTK.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return !(Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(0.3, 2)) && y >= 0 && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(1, 2));
            //(x – x1)^2 + (y – y1)^2 <= R ^ 2, где:
            //(x, y) — координаты точки;
            //(x1, y1) — координаты центра окружности;
            //R — радиус окружности.
        }
    }
}
