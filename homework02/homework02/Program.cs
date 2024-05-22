using System;
using homework02.Task1;
using homework02.Task2;
using homework02.Task3;
namespace homework02
{
    public class Program
    {
        public static void Main()
        {
            // Example of the Money class
            Money money = new Money(100, 10);
            money.PrintSum();

            // Example of the Product class
            Product product = new Product(-1, -1, "iPhone 14");
            product.Cash = 1199;
            product.Coins = 99;
            product.PrintInfo();
            product.ReducePrice(100, 0);
            product.PrintInfo();

            // Example of the Instrument classes
            Violin violin = new Violin("Violin", "", "");
            Trombone trombone = new Trombone("Trombone", "", "");
            Ukulele ukulele = new Ukulele("Ukulele", "", "");
            Cello cello = new Cello("Cello", "", "");
            violin.Sound();
            trombone.Sound();
            ukulele.Sound();
            cello.Sound();

            // Example of the DecimalNumber structure
            DecimalNumber decimalNumber = new DecimalNumber(64);
            Console.WriteLine(decimalNumber.ToBinary());
            Console.WriteLine(decimalNumber.ToOctal());
            Console.WriteLine(decimalNumber.ToHexadecimal());
        }
    }
}