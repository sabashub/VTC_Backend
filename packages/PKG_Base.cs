using Oracle.ManagedDataAccess.Client;

namespace VTC.packages
{
    public class PKG_Base
    {

        private string _connectionString;

        public PKG_Base(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected OracleConnection GetConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
