using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolchanovIV.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string result = value;

            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    result = result.Replace(c, replacement);
                }
            }

            return result;
        }
    }
}
