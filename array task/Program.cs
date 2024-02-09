using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_task
{
    internal class Program
    {
        static int[] numbers = { 3, 7, 5, 6, 9, 4, 7, 2, 1, 5 };
        static void Main(string[] args)
        {
            Biggest();
            total();
            Repeating();
            
            
            Console.ReadLine();
        }
        static void Biggest()
        {
            int biggest = 0;
            for (int pos = 0; pos < numbers.Length; pos++)
            {
                
                if (numbers[pos] >= biggest)
                {
                    biggest = numbers[pos];
                }
                
            }
            Console.WriteLine($"Biggest number is: {biggest}");


        }
        static void total()
        {
            int total = 0;
            for (int pos = 0; pos < numbers.Length; pos++)
            {
                 total = total+numbers[pos];
            }
            Console.WriteLine($"Total is: {total}");

        }
        static void Repeating()
        {
            string repeatnums = "";
            for (int pos = 0; pos < numbers.Length; pos++)
            {
                for(int pos2 = pos+1; pos2 < numbers.Length; pos2++)
                {
                    if (numbers[pos] == numbers[pos2] && pos != pos2)
                    {
                        repeatnums += Convert.ToString(numbers[pos]);
                    }
                }
                
            }
            Console.Write($"Repeating number(s) is/are: {repeatnums}");
        }
    }
}
