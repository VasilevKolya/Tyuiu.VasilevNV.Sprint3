using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            char[] chars = value.ToCharArray();

            foreach (char c in chars)
            {
                if (c == replaceable)
                {
                    chars[Array.IndexOf(chars, c)] = replacement;
                }
            }

            return new string(chars);
        }
    }
}
