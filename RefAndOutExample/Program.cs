using System;

namespace RefAndOutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            var sonuc = metod( ref num1, 51);
            Console.WriteLine(sonuc);
            Console.WriteLine(num1);

           static int metod( ref int num1,int num2)
            {
                num1 = 111;
                int sum = num1 + num2;
                return sum;

            }
           

            
        }
    }
}
