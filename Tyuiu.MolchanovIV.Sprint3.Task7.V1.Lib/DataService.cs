using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];

            int x = startValue;

            for (int i = 0; i <= 10; i++)
            {
                result[i] = Math.Round((Math.Sin(x)/(x + 1.2)) + (7 * x * Math.Cos(x)) - 2, 2);
                x++;
            }

            return result;
        }
    }
}
