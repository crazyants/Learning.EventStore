﻿using System.Data;
using System.Data.SqlClient;

namespace Learning.EventStore.Common.Sql
{
    public class SqlServerConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _readConnectionString;
        private readonly string _writeConnectionString;

        public SqlServerConnectionFactory(SqlServerEventStoreSettings settings)
        {
            _readConnectionString = settings.ReadConnectionString;
            _writeConnectionString = settings.WriteConnectionString;
        }

        public IDbConnection GetReadConnection()
        {
            var conn = new SqlConnection(_readConnectionString);
            return conn;
        }

        public IDbConnection GetWriteConnection()
        {
            var conn = new SqlConnection(_writeConnectionString);
            return conn;
        }
    }
}
