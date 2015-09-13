using System;

namespace DBConnection
{
	public class OracleConnection :DbConnection
	{
		public override void Open()
		{
			Console.WriteLine ("Opening Oracle Connection");
		}

		public override void Close()
		{
			Console.WriteLine ("Closing Oracle Connection");
		}
	}
}

