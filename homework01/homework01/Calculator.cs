namespace homework01
{
	public class Calculator
	{
		private float _value1;
		private float _value2;

		// Constructor
		public Calculator(float value1, float value2) { _value1 = value1; _value2 = value2; }

		// Methods
		public float Sum() => _value1 + _value2;
		public float Diffrence() => _value1 - _value2;
		public float Product() => _value1 * _value2;
		public float Quotient() => _value2 != 0 ? _value1 / _value2 : float.NaN;
    }
}

