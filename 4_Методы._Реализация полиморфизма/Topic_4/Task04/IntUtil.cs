using System;

namespace Task04
{
    public static class IntUtil
    {
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

