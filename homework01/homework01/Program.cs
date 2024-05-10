namespace homework01
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new(12, 0);
            Console.WriteLine($"Sum = {calculator.Sum()}");
            Console.WriteLine($"Diffrence = {calculator.Diffrence()}");
            Console.WriteLine($"Product = {calculator.Product()}");
            Console.WriteLine($"Quotient = {calculator.Quotient()}");
        }
    }
}

