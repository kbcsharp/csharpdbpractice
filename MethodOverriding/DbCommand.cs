using System;

namespace MethodOverriding
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (String.IsNullOrWhiteSpace(dbConnection.ConnectionString))
                throw new ArgumentNullException("connection string can't be null or empty");

            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentNullException("instruction string can't be null or empty");

            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine(_instruction);
            _dbConnection.Close();
        }
    }
}
