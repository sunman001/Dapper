using System;
using System.Data;
using System.Configuration;
using System.Data.Common;


namespace Infrastructure
{
    public  class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public IDbConnection GetConnection
        {
            get
            {
                var factroy = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factroy.CreateConnection();
                if (conn == null) throw new Exception("数据库连接失败");
                conn.ConnectionString = _connectionString;
                return conn;
            }
        }

        private bool _disposeValue;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposeValue) return;
            if (disposing)
            {
                
            }
            _disposeValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }


    }
}
