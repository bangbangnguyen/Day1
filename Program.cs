using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVonglap
{
    internal class Program
    {
        //static void Main(string[] args)
        // {
        //     // Tính tổng 10 số đầu tiên nhập từ bàn phím
        //     int sum = 0;
        //     Console.WriteLine("Please fill 10 numbers");

        //     for (int i = 0; i < 10; i++)
        //     {
        //         int n;
        //         bool validInput = false;

        //         while (!validInput)
        //         {
        //             Console.Write("Nhập vào một số: ");
        //             string input = Console.ReadLine();

        //             if (int.TryParse(input, out n))
        //             {
        //                 sum += n;
        //                 validInput = true;
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
        //             }
        //         }
        //     }

        //     Console.WriteLine($"Sum = {sum}");
        //     Console.ReadKey();
        // }


        static void Main(string[] args)
        {
            Console.Write("Nhập vào một số: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} là số nguyên tố.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"{number} không phải là số nguyên tố.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                Console.ReadKey();
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            int boundary = (int)Math.Sqrt(num);

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}

