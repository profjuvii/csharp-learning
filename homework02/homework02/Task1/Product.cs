using System;
namespace homework02.Task1
{
	public class Product : Money
	{
		private string _productName;

        public Product(int cash, int coins, string productName) : base(cash, coins)
		{
			_productName = productName;
		}

        // Get/set methods for product name
        public string ProductName
        {
            get => _productName;
            set { _productName = value; }
        }

        // Method for reducing price
        public void ReducePrice(int cash, int coins)
		{
            if (cash >= 0 && coins >= 0 && coins < 100)
            {
                Cash -= cash;
                Coins -= coins;
            }
            else
            {
                Console.WriteLine("Error: Invalid format.");
            }
        }

        // Print method
        public void PrintInfo() => Console.WriteLine($"{_productName}: {Cash}.{Coins}$");
	}
}

