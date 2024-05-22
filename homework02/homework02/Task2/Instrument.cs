using System;
namespace homework02.Task2
{
	public class Instrument
	{
		public string Name { get; set; }
		public string Info { get; set; }
		public string Story { get; set; }

        public Instrument(string name, string info, string history)
		{
			Name = name;
			Info = info;
			Story = history;
		}

		// All virtual methods
		public virtual void Sound() => Console.WriteLine("Sound...");
        public virtual void Show() => Console.WriteLine(Name);
        public virtual void Desc() => Console.WriteLine(Info);
        public virtual void History() => Console.WriteLine(Story);
    }
}

