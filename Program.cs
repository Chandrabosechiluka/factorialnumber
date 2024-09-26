namespace factorialnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }

        static long CalculateFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
