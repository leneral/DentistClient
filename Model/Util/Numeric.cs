using System;
using System.Text.RegularExpressions;

namespace Model.Util
{
    public class Numeric
    {
        public static string UInt2String(UInt32 num)
        {
            if (num > 0 && num < 10)
                return "000000" + num;
            if (num >= 10 && num < 100)
                return "00000" + num;
            if (num >= 100 && num < 1000)
                return "0000" + num;
            if (num >= 1000 && num < 10000)
                return "000" + num;
            if (num >= 10000 && num < 100000)
                return "00" + num;
            if (num >= 100000 && num < 1000000)
                return "0" + num;
            if (num >= 1000000)
                return "" + num;
            return null;
        }

        public static bool IsNumber(string str)
        {
            var regNum = new Regex(@"^/d+$");

            return regNum.IsMatch(str);
        }
    }
}
