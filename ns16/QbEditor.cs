using System;

namespace ns16
{

    // Base class of some other classes that appear to edit qb files

	public abstract class QbEditor : IEquatable<QbEditor>
	{
		public bool method_0()
		{
			bool result;
			try
			{
				this.CreateCustomMenu();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				result = false;
			}
			return result;
		}

		public abstract void CreateCustomMenu();

		public abstract override string ToString();

		public abstract bool Equals(QbEditor other);
	}
}
