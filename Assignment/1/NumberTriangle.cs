using System;

namespace assignment
{
    public class NumberTriangle
    {
        public int numberOfRow;
        public void generateNumberTriangle(int numberOfRow)
        {
            for (int i = 1; i <= numberOfRow; i++)
            {
                for (int j = 1; j <= numberOfRow - i; j++)
                {
                    Console.Write(" ");
                }

                int num = 1;
                for (int k = 1; k < i; k++)
                {
                    Console.Write(num);
                    num++;
                }

                for (int l = num; l > 0; l--)
                {
                    Console.Write(num);
                    num--;
                }

                Console.Write("\n");
            }
        }
    }
}