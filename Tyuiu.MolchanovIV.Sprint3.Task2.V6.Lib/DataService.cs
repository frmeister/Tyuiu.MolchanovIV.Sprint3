using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {

            int i = startValue;
            double result = 1.0;

            do
            {

                result *= (Math.Pow(value, i) + 1) * Math.Cos(4);

                i++;

            } while (i <= stopValue);

            return Math.Round(result, 3);
        }
    }
}
