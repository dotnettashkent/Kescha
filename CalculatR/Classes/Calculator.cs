using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatR.Classes
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation {get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Enter first number");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation : (+,-,/,*,%) -> ");
            Operation = Console.ReadLine();
            Console.WriteLine("Enter second number");
            SecondNumber = int.Parse(Console.ReadLine());
        }
        // 1 - sonni tekshirish 0 dan kattami yoqmi
        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }
        // 2 ta sonni o'zaro tekshirish
        public void CompareInputs()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("1st number is greater than 2nd number!");
            }
            else if (FirstNumber==SecondNumber) 
            {
                Console.WriteLine("1st number is equal to 2nd number");
            }
            else
            {
                Console.WriteLine("1st number is less then 2nd number");
            }
        }

        // Calculate jarayoni

        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                _ => "Operation not found"
            };
        }

        public void PrintEvenNumbers()
        {
            int count = 2;
            while (count < FirstNumber)
            {
                Console.WriteLine(count);
                count += 2;
                
            }
        }

        public void MultiplacationTable()
        {
            for (int i=1;i<9;i++)
            {
                for (int j=1;j<9;j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
