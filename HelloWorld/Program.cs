using System;
using Calc;

namespace HelloWorld
{
    public enum Database
    {
        MySql = 1,
        Mongo = 2,
        SQLServer = 3,
    }
    public class Program
    {
        private static T convertEnum<T>(string key) => (T)Enum.Parse(typeof(T), key);
        static void Main(string[] args)
        {
            var valueA = 10;
            var valueB = valueA;
            valueB++;
            Console.WriteLine("{0}  {1}",valueA, valueB);

            var array1 = new int[3] { 1, 2, 3,};

            var array2 = [...array1];

            array2[0] = 0;

            Console.WriteLine(string.Join(",", array1));

        }
    }
}
