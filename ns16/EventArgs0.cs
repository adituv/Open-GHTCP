using System;

namespace ns16
{
	public class EventArgs0 : EventArgs
	{
		private string string_0;

		private int int_0;

		public EventArgs0(string string_1, int int_1)
		{
			this.string_0 = string_1;
			this.int_0 = int_1;
		}

		public string method_0()
		{
			return this.string_0;
		}

		public int method_1()
		{
			return this.int_0;
		}
	}
}
