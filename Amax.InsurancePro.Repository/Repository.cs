
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Interfaces;
using Dapper;
using Dapper.FluentColumnMapping;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using static Amax.InsurancePro.Domain.Common.Enums;


namespace Amax.InsurancePro.Repository
{
	public class Repository : IRepository
    {
        private AppSettings _appSettings;
        private string _amaxDBConnectionString = string.Empty;
        private readonly string _ipAdminDBConnectionString = string.Empty;

        private readonly ColumnMappingCollection _mappings;

        public Repository(IOptionsMonitor<AppSettings> appSettings)
		{
            _mappings = new ColumnMappingCollection();

            _appSettings = appSettings.CurrentValue;
            appSettings.OnChange(newValue =>
            {
                _appSettings = newValue;
                _amaxDBConnectionString = _appSettings.Database.AmaxDB.DbConnectionString;
            });

            _amaxDBConnectionString = _appSettings.Database.AmaxDB.DbConnectionString;
            _ipAdminDBConnectionString = _appSettings.Database.IPAdminDB.DbConnectionString;
        }

        /// <summary>
        /// Returns the single value set based on the type of the requested object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public T ExecuteScalar<T>(string sql, object parameters, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            T result = default;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = conn.ExecuteScalar<T>(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Returns the single value set based on the type of the requested object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public async Task<T> ExecuteScalarAsync<T>(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            T result = default;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = await conn.ExecuteScalarAsync<T>(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Returns the first result set based on the type of the requested entity.
        /// Example : To get details of an address based on address id.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public T GetFirstOrDefault<T>(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            T result = default;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = conn.QueryFirstOrDefault<T>(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Returns the first result set based on the type of the requested entity.
        /// Example : To get details of an address based on address id.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public async Task<T> GetFirstOrDefaultAsync<T>(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            T? result = default;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = await conn.QueryFirstOrDefaultAsync<T>(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Returns an collection of the type of requested entity.
        /// Example: To list of all address.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public IEnumerable<T> Get<T>(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            IEnumerable<T>? result = default;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = conn.Query<T>(sql, parameters, null, true, commandTimeout, commandType);
            }

            return result;
        }

        public async Task<IEnumerable<dynamic>> Query(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            IEnumerable<dynamic> result = default;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = await conn.QueryAsync(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }
        /// <summary>
        /// Returns an collection of the type of requested entity.
        /// Example: To list of all address.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param> 
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAsync<T>(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            IEnumerable<T> result = default(IEnumerable<T>);

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = await conn.QueryAsync<T>(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Adds an entity. 
        /// The onus of getting the Id of the newly added entity is on each class that implements this API.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param> 
        /// <returns></returns>
        public int Add(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            var result = 0;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = conn.Execute(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Adds an entity. 
        /// The onus of getting the Id of the newly added entity is on each class that implements this API.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param> 
        /// <returns></returns>
        public async Task<int> AddAsync(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            var result = 0;

            using (IDbConnection conn = GetConnection(databaseName))
            {
                result = await conn.ExecuteAsync(sql, parameters, null, commandTimeout, commandType);
            }

            return result;
        }

        /// <summary>
        /// Updates an entity. 
        /// The onus of getting the Id of the newly added entity is on each class that implements this API.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>  
        /// <returns></returns>
        public async Task<int> UpdateAsync(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            return await this.AddAsync(sql, parameters, commandTimeout, commandType, databaseName);
        }

        /// <summary>
        /// Deletes an entity. 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>   
        protected async Task<int> DeleteAsync(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            var rowsCount = 0;
            using (IDbConnection conn = GetConnection(databaseName))
            {
                rowsCount = await conn.ExecuteAsync(sql, parameters, null, commandTimeout, commandType);
            }
            return rowsCount;
        }

        /// <summary>
        /// Deletes an entity. 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>   
        protected int Delete(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            var rowsCount = 0;
            using (IDbConnection conn = GetConnection(databaseName))
            {
                rowsCount = conn.Execute(sql, parameters, null, commandTimeout, commandType);
            }
            return rowsCount;
        }

        /// <summary>
        /// Returns multiple results based on the types specified.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>   
        /// <returns></returns>
        public async Task<dynamic> GetMultipleAsync<T1, T2>(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            dynamic result = new ExpandoObject();

            using (IDbConnection conn = GetConnection(databaseName))
            {
                using var multi = await conn.QueryMultipleAsync(sql, parameters, null, commandTimeout, commandType);
                var t1 = multi.Read<T1>();
                var t2 = multi.Read<T2>();

                result.Item1 = t1;
                result.Item2 = t2;
            }

            return result;
        }
        public async Task<SqlMapper.GridReader> ExecuteScalarAsync(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            SqlMapper.GridReader result;
            IDbConnection conn = GetConnection(databaseName);
            try
            {
                result = await conn.QueryMultipleAsync(sql, parameters, null, commandTimeout, commandType);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        /// <summary>
        /// Registers the list of properties which you would like to map to it's corresponsing sql column name.
        /// This is usually used where your object's property name is different from the underline sql column name.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="columns">list fo columns</param>
        public void RegisterColumnMappings<T>(IEnumerable<SqlColumnMapping> columns)
        {
            // register only if the type is not already added to the mapping collection
            if (!_mappings.Mappings.Keys.Contains(typeof(T)))
            {
                var mappedType = _mappings.RegisterType<T>();

                foreach (var item in columns)
                {
                    mappedType
                    .MapProperty(item.Source).ToColumn(item.Target);
                }

                // register with dapper
                _mappings.RegisterWithDapper();
            }
        }

        /// <summary>
        /// Returns the sql connection based on the database against which the comnection is requested for.
        /// The default is against AmaxDB database.
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        protected IDbConnection GetConnection(DatabaseName databaseName)
        {
            string connectionString = _amaxDBConnectionString;

            if (databaseName == DatabaseName.AmaxDB)
            {
                connectionString = _amaxDBConnectionString;
            }
            else if (databaseName == DatabaseName.IPAdminDB)
            {
                connectionString = _ipAdminDBConnectionString;
            }

            return new SqlConnection(connectionString);
        }
        private IDataAdapter GetAdapter(IDbConnection conn, string commandText)
        {
            return new SqlDataAdapter(commandText, (SqlConnection)conn);
        }

        public async Task<DataSet> GetDataSetAsync(string sql, object parameters, int? commandTimeout, CommandType? commandType, DatabaseName databaseName = DatabaseName.AmaxDB)
        {
            DataSet ds = new();
            IDbConnection conn = GetConnection(databaseName);
            try
            {
                var list = await SqlMapper.ExecuteReaderAsync(conn, sql: sql, param: parameters, commandTimeout: commandTimeout, commandType: commandType);
                int i = 0;
                while (!list.IsClosed)
                {
                    ds.Tables.Add();
                    ds.EnforceConstraints = false;
                    ds.Tables[i].Load(list);
                    i++;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ds;
        }

    }
}
