using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BukinTK.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string cardName;
            switch (value)
            {
                case 6: cardName = "шестерка"; break;
                case 7: cardName = "семерка"; break;
                case 8: cardName = "восьмерка"; break;
                case 9: cardName = "девятка"; break;
                case 10: cardName = "десятка"; break;
                case 11: cardName = "валет"; break;
                case 12: cardName = "дама"; break;
                case 13: cardName = "король"; break;
                case 14: cardName = "туз"; break;
                default: cardName = "неизвестная карта"; break;
            }
            return cardName;
        }
    }
}
