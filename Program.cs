using System;

namespace GetMiddleCharacter
{
    class Program
    {
        public static string GetMiddle(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            decimal half = s.Length / 2;
            var middle = Math.Floor(half);
            char middleCharacter = s[Decimal.ToInt32(middle) - 1];
            char middleSecond = s[Decimal.ToInt32(middle)];
            if (s.Length % 2 == 0)
            {

                return string.Concat(middleCharacter, middleSecond);
            }
            else
            {
                return middleSecond.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("test"));
            Console.WriteLine(GetMiddle("testing"));
            Console.WriteLine(GetMiddle("middle"));
            Console.WriteLine(GetMiddle("A"));

        }
    }
}
