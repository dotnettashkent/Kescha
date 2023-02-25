using CalculatR.Classes;

namespace Kescha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Security security= new Security();
            security.CheckPassword();
            Calculator calculator = new Calculator();
            calculator.GetInputs();
            string massage = (calculator.IsFirstNumberPositive()) ? "1 st number is positive" : "2nd number is positive";
            Console.WriteLine(massage);
            calculator.CompareInputs();

            string result = calculator.Calculate();
            Console.WriteLine(result);
            calculator.PrintEvenNumbers();
            calculator.MultiplacationTable();
        }
    }
}