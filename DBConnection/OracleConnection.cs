using System;

namespace DBConnection
{
	public class OracleConnection :DbConnection
	{
		public OracleConnection(string ConnectionString) : base(ConnectionString){}
	


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

