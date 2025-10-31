using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            int i = startValue;
            double res = 1.0;

            while (i <= stopValue)
            {

                res *= Math.Pow((1 / Math.Pow(value, i)), 3);

                i++;
            }

            return Math.Round(res, 3);
        }
    }
}
