using System;

namespace MethodOverriding
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("connection string can't be null or empty");

            ConnectionString = connectionString;
            Console.WriteLine();
        }

        public abstract void Open();
        public abstract void Close();
    }
}
