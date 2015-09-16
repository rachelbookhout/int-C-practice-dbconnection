using System;

namespace DBConnection
{
	public abstract class DbConnection
	{
		
			//this is the base class
			//has two properties -> ConnectionString : string, Timeout :TimeSpan
			public string ConnectionString {get;set;}
			public TimeSpan TimeoutException { get; set;}
			
			//need to pass the connection string through in the constructor for this class
		public DbConnection(string connectionString)
		{
			this.ConnectionString = connectionString;

		}	
			
			//two methods -> open and close, declare that as abstract and not definied here
			public abstract void Open();
			public abstract void Close();


			//have two derived clsses -> SqlConnection and OracleConnection and write a simple open and close connection with a Console.WriteLine


	}
}

