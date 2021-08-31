using System;

namespace ex01c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int var1 = 10;
            int var2 = 20;
            int var3 = 30;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);

            Console.WriteLine(var1 < var2);
            Console.WriteLine(var1 == var3);

            var1++;
            var3--;

            Console.WriteLine(var1);
            Console.WriteLine(var3);

        }
    }
}
