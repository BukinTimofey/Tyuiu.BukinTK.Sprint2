using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BukinTK.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;
            if (x <= y && x <= 16 - y)
            {
                return true;
            }
            else if (x >= y && y <= 16 - x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
