using System;
namespace homework02.Task1
{
	public class Money
	{
		private int _cash = 0;
		private int _coins = 0;

		public Money(int cash, int coins)
		{
			if (cash >= 0 && coins >= 0 && coins < 100)
			{
				_cash = cash;
				_coins = coins;
			}
			else
			{
				Console.WriteLine("Error: Invalid format.");
			}
		}

		// Get/set methods for cash
		public int Cash
		{
			get => _cash;
			set { _cash = value >= 0 ? value : 0; }
		}

		// Get/set methods for coins
		public int Coins
		{
			get => _coins;
			set { _coins = value >= 0 && value < 100 ? value : 0; }
		}

		// Print method
		public void PrintSum() => Console.WriteLine($"{_cash}.{_coins}$");
	}
}

