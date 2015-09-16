using System;
using DBConnection;

namespace DBConnection
{

	//after all of this, create a class called DbCommand, needs a constructor with connection string in it and a string which is representing the instruction
	//make sure the string is catering for a null reference or an empty string
	//needs a method caleled Execute() -> which will be be Open(), run the instruction, and Close()
	//DbCommand referencess DbConnection


	public class DbCommand
	{
		public string ConnectionString {get;set;}
		public string Instruction { get; set;}

		public DbCommand(string connectionString, string instruction)
		{
			this.ConnectionString = connectionString;
			this.Instruction = instruction;

		}

		public void Execute(DbConnection connection)
		{
			connection.Open();
			//do instruction
			connection.Close ();
		}
	}
}

