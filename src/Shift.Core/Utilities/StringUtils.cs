using System.Linq;

namespace Shift.Core.Utilities
{
    public static class StringUtils
    {
        public static string OnlyNumbers(this string str, string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }
    }
}