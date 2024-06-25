using Amax.InsurancePro.Domain.Entities;
using System.Data;
using static Amax.InsurancePro.Domain.Common.Enums;

namespace Amax.InsurancePro.Domain.Interfaces
{
	public interface IRepository
    {
        /// <summary>
        /// Returns one (first) element of the result set
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        T GetFirstOrDefault<T>(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

        /// <summary>
        /// Returns one (first) element of the result set
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        Task<T> GetFirstOrDefaultAsync<T>(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

        /// <summary>
        /// Returns list of elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        IEnumerable<T> Get<T>(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

        Task<IEnumerable<dynamic>> Query(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);
        /// <summary>
        /// Returns list of elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAsync<T>(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

        //Task<IEnumerable<dynamic>> Query(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.DevDB);
        /// <summary>
        /// Inserts an entity and returns the id of the newly inserted entity
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        int Add(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

        /// <summary>
        /// Inserts an entity and returns the id of the newly inserted entity
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        Task<int> AddAsync(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

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
        Task<dynamic> GetMultipleAsync<T1, T2>(string sql, object parameters = null, int? commandTimeout = null, CommandType? commandType = null, DatabaseName databaseName = DatabaseName.AmaxDB);

        /// <summary>
        /// Registers the list of properties which you would like to map to it's corresponsing sql column name.
        /// This is usually used where your object's property name is different from the underline sql column name.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="columns">list fo columns</param>
        void RegisterColumnMappings<T>(IEnumerable<SqlColumnMapping> columns);
    }
}