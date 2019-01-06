using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleConnection = new OracleConnection("super oracle");
            var sqlConnection = new SqlConnection("super");
            var dbCommand = new DbCommand(sqlConnection, "instruction 1");
            var dbCommand2 = new DbCommand(oracleConnection, "instruction 2");
            dbCommand.Execute();
            dbCommand2.Execute();
        }
    }
}
