using System;

namespace assignment
{
    public class Factorial
    {
        public int num;

        public int factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * factorial(num - 1);
        }
    }
}