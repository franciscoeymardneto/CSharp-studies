using System;
public class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número entre 1 e 10 \n");

        var input1 = Console.ReadLine().toInteger();

        Console.WriteLine("Digite um número entre 1 e 10 \n");

        var input2 = Console.ReadLine().toInteger();

        Console.WriteLine(input1 >= input2 ? input1 : input2);
    }
}