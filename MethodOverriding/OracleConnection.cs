using System;

namespace MethodOverriding
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        { }

        public override void Open()
        {
            Console.WriteLine("open oracle database connection");
        }

        public override void Close()
        {
            Console.WriteLine("close oracle database connection");
        }
    }
}
