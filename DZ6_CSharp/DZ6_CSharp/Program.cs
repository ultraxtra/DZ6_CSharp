using System;
using static System.Console;

namespace DZ6_CSharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Program1();
        }

        static void Program1()
        {
            try
            {
                Array test = new Array(10);
                test.FillRandom(10);
                WriteLine($"Arr[]: ");
                test.Output();
                WriteLine();
                int Greater = test.Greater(2);
                int Less = test.Less(8);
                WriteLine($"Amount nums less then 8: {Less}");
                WriteLine($"Amount nums greater than 2: {Greater}");
                WriteLine($"Even values: ");
                test.ShowEven();
                WriteLine();
                WriteLine($"Odd values: ");
                test.ShowOdd();
                WriteLine();
                WriteLine($"Qty uniq values: {test.CountDistinct().ToString()}");
                WriteLine();
                WriteLine($"Qty equal values (2): {test.EqualToValue(2).ToString()}");
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }

    }

}