using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1.0;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) break;
                result *= (Math.Cos(i) / i) + 3;
            }

            return result;
        }
    }
}
