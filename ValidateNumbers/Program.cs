using System;
public class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número entre 1 e 10 \n");

        var input = Console.ReadLine();

        if (int.TryParse(input, out var number))
        {
            if (number < 0 || number > 10)
            {
                Console.WriteLine("Invalid input range.");
                return;
            }

            Console.WriteLine("Valid input {0}", number);
        }
        else
        {
            Console.WriteLine("Invalid input type.");
            return;
        }
    }
}