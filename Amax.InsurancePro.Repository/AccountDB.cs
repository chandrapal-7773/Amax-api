namespace Amax.InsurancePro.Repository;

public abstract class AccountDB
{
    private IConnectionString _connectionString;

    public AccountDB(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }

    public override string ToString()
    {
        return $"server={_connectionString.SQLServer};" +
            $"Initial Catalog={_connectionString.SQLDatabaseName};" +
            $"User ID={_connectionString.SQLUserId};" +
            $"Password={_connectionString.SQLUserPassword};" +
            $"Connection Timeout=0;";
    }
}

public class AmaxDB : AccountDB
{
    public AmaxDB(IConnectionString connectionString)
        : base(connectionString)
    { }
}