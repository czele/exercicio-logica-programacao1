using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    public static class Util
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
                if (c < '0' || c > '9')
                    return false;
            return true;
        }

        public static int GetInt()
        {
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (IsDigitsOnly(input))
                {
                    number = Convert.ToInt32(input);
                    break;
                }
            }
            return number;
        }
    }
}
