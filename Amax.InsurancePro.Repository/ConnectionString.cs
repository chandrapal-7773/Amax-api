namespace Amax.InsurancePro.Repository;

public interface IConnectionString
{
    public string SQLServer { get; set; }
    public string SQLDatabaseName { get; set; }
    public string SQLUserId { get; set; }
    public string SQLUserPassword { get; set; }
}

public class ConnectionString : IConnectionString
{
    public string SQLServer { get; set; }
    public string SQLDatabaseName { get; set; }
    public string SQLUserId { get; set; }
    public string SQLUserPassword { get; set; }
}