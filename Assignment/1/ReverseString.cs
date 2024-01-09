using System;

namespace assignment
{
    public class ReverseString
    {
        public string str;
        public void Reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine($"Kebalikan dari {str.ToLower()} adalah : {new string(array).ToLower()}");
        }
    }
}