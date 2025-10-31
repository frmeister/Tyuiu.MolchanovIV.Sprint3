using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task5.V5.Lib
{
    public class DataService : ISprint3Task5V5
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double result = 0.0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    result += x / Math.Sin(k);
                }
            }

            return Math.Round(result, 3);
        }
    }
}
