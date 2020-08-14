namespace NullJsonTest.Repositories
{
    using Dapper;
    using Npgsql;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Microsoft.Extensions.Logging;
    using NullJsonTest.Models;

    public class SettingsRepository : ISettingsRepository
    {
        private readonly ILogger<SettingsRepository> _logger;
        protected IDbConnection _connection;

        public SettingsRepository(ILogger<SettingsRepository> logger, IDbConnection dbConnection)
        {
            _logger = logger;
            _connection = dbConnection;
        }

        public IEnumerable<Settings> GetSettings()
        {
            this._connection.Open();

            var settings = this._connection.Query<Settings>($"select * from settings");

            this._logger.LogInformation(JsonConvert.SerializeObject(settings));

            return settings;
        }

        public int CreateSetting(Settings setting)
        {
            string sql = "insert into settings(id, category, name, value, type_id) values(@id, @category, @name, @value, @type_id);";
            var rows = this._connection.Execute(sql, new {id = setting.Id, category = setting.Category, name = setting.Name, value = setting.Value, type_id = setting.Type_id});

            this._logger.LogInformation($"Affected rows {rows}");

            return rows;
        }
    }
}