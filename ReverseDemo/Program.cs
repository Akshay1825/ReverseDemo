using ReverseDemo.Model.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse reverse = new Reverse();

            Console.WriteLine("Enter a number :");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = reverse.ReverseNumber(number);

            Console.WriteLine($"The reverse of {number} is {reversedNumber}.");
        }
    }
}
