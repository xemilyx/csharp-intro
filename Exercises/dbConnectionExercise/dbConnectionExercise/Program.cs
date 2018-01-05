using System;

namespace dbConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString
        {
            get;
            set;
        }

        public TimeSpan Timeout
        {
            get;
            set;
        }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new Exception("Cannot create connection without connection string.");

            this.ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQL connection at {0} is open.", ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SQL connection is closed.");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection at {0} is open.", ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection is closed.");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("http://connectionstringforsql");
            sqlConnection.Open();
            sqlConnection.Close();

            //var oracleConnection = new OracleConnection("");
            //oracleConnection.Open();
            //oracleConnection.Close();
        }
    }

}
