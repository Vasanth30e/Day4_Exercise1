using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pre = 60;
            int final = 55;
            int marks;

            Console.WriteLine("Enter the Pre Final Marks : ");
            marks = int.Parse(Console.ReadLine());

            if (pre < marks)
            {
                if (marks > final)
                {
                    Console.WriteLine("Selected");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }

            Console.ReadKey();
        }
    }
}
