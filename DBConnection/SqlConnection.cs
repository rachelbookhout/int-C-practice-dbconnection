using System;

namespace DBConnection
{
	public class SqlConnection : DbConnection
	{

		public SqlConnection(string ConnectionString) : base(ConnectionString){}


		public override void Open()
		{
			Console.WriteLine("Opening SQl Connection");
		}

		public override void Close()
		{
			Console.WriteLine("Closing SQL Connection");
		}
	}
}

