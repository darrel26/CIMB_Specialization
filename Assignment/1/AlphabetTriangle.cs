using System;

namespace assignment
{
    public class AlphabetTriangle
    {
        public int numberOfRow;
        public void generateTriangle(int numberOfRow)
        {
            char ch = 'A';

            int i, j, k, m;
            for (i = 1; i <= numberOfRow; i++)
            {
                for (j = numberOfRow; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }
    }
}