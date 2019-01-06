using System;

namespace MethodOverriding
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        { }

        public override void Open()
        {
            Console.WriteLine("open sql database connection");
        }

        public override void Close()
        {
            Console.WriteLine("close sql database connection");
        }
    }
}
