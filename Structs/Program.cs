using System;


namespace Structs
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number num1;
            num1.Amount = 5.323422123m;
            Console.WriteLine("The Decimal Number is:" + "\n" + num1.Amount);
            Console.ReadLine();
        }
    }
}
