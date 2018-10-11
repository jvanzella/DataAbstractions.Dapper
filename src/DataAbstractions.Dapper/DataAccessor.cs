﻿using System;
using System.Data;

namespace DataAbstractions.Dapper
{
    public partial class DataAccessor : IDataAccessor
    {
        private readonly IDbConnection _connection;

        public DataAccessor(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public IDbConnection GetUnderlyingConnection() => _connection;

        public void Dispose() => _connection.Dispose();
    }
}