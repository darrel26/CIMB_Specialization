using System;
namespace assignment
{
    class NumberToString
    {
        public string number;
        public void convertNumberToString(string number)
        {
            string[] digitStrings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.Write("Hasilnya adalah : ");
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit))
                {
                    int index = (int)Char.GetNumericValue(digit);
                    Console.Write(digitStrings[index] + " ");
                }
            }
        }
    }
}