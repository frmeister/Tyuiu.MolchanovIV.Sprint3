using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1; // a = 0,25 k =1, 8

            for (int k = startValue; k <= stopValue; k++)
            {
                result = result * ((Math.Pow(value, k) + 4) * Math.Cos(value));
            }

            return Math.Round(result, 3);
        }
    }
}
