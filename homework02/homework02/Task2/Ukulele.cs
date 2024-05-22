using System;
namespace homework02.Task2
{
	public class Ukulele : Instrument
	{
		public Ukulele(string name, string info, string history) : base(name, info, history)
        {
		}

        public override void Sound() => Console.WriteLine("Ukulele sound...");

        public override void Show()
        {
            base.Show();
        }

        public override void Desc()
        {
            base.Desc();
        }

        public override void History()
        {
            base.History();
        }
    }
}

