using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculator
{
    public class Validate
    {
        public bool StringIsNumber(string number)
        {
            var isNumeric = int.TryParse(number, out int n);

            if (isNumeric)
            {
                return true;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            int sum;
            int average;

            Console.WriteLine("Enter four numbers to calculate their average");
            Console.Write("Number 1: ");
            string num1 = Console.ReadLine();
            Console.Write("Number 2: ");
            string num2 = Console.ReadLine();
            Console.Write("Number 3: ");
            string num3 = Console.ReadLine();
            Console.Write("Number 4: ");
            string num4 = Console.ReadLine();

            List<string> numbersToValidate = new List<string> { num1, num2, num3, num4 };
            List<int> numbers = new List<int>();

            List<bool> validNumbers = new List<bool>();

            Validate valid = new Validate();

           foreach(string number in numbersToValidate)
            {
                if (valid.StringIsNumber(number))
                {
                    validNumbers.Add(true);
                }
                else
                {
                    validNumbers.Add(false);
                }
            }
            

            if (validNumbers.Contains(false))
            {
                Console.WriteLine("Please input numbers only!");
            } else
            {
               foreach(string number in numbersToValidate)
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                sum = numbers.Sum();

                average = sum / 4;

                Console.WriteLine("The average of {0}, {1}, {2}, and {3} is: {4}", num1, num2, num3, num4, average);
            }

        }
    }
}
