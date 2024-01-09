using System;
using assignment;

class Program
{
    public static void Main(string[] args)
    {
        Factorial fact = new Factorial();
        AlphabetTriangle alphabet = new AlphabetTriangle();
        NumberTriangle number = new NumberTriangle();
        ReverseString reverse = new ReverseString();
        NumberToString numToString = new NumberToString();

        Console.WriteLine("Pilih Program : ");
        Console.WriteLine("1. Segitiga Alfabet");
        Console.WriteLine("2. Segitiga Angka");
        Console.WriteLine("3. Factorial");
        Console.WriteLine("4. Reverse String");
        Console.WriteLine("5. Numbers to Word");
        Console.Write("Masukkan Angka : ");
        var choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Masukkan jumlah baris segitiga : ");
                alphabet.numberOfRow = int.Parse(Console.ReadLine());
                alphabet.generateTriangle(alphabet.numberOfRow);
                break;
            case 2:
                Console.Write("Masukkan jumlah baris segitiga : ");
                number.numberOfRow = int.Parse(Console.ReadLine());
                number.generateNumberTriangle(number.numberOfRow);
                break;
            case 3:
                Console.Write("Masukkan angka faktorial : ");
                fact.num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Hasil faktorial {fact.num} adalah : {fact.factorial(fact.num)}");
                break;
            case 4:
                Console.Write("Masukkan string : ");
                reverse.str = Console.ReadLine();
                reverse.Reverse(reverse.str);
                break;
            case 5:
                Console.Write("Masukkan angka : ");
                numToString.number = Console.ReadLine();
                numToString.convertNumberToString(numToString.number);
                break;
            default:
                Environment.Exit(0);
                break;
        }

    }
}