namespace Amax.InsurancePro.Domain.Entities.Custom;

public class AppSettings
{
    public Database Database { get; set; }
    public Keys Keys { get; set; }
    public CORS CORS { get; set; }
    public Jwt Jwt { get; set; }
}

public class Database
{
    public AmaxDB AmaxDB { get; set; }
    public IPAdminDB IPAdminDB { get; set; }
}

public class Keys
{
    public string Secret { get; set; }
    public string ApiKey { get; set; }
}

public class Jwt
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Key { get; set; }
}

public class CORS
{
    public string AllowedHosts { get; set; }
    public string AllowedHeaders { get; set; }
    public string AllowedMethods { get; set; }
}

#region DB Connection String

public class AmaxDB : DBString
{

}

public class IPAdminDB : DBString
{

}

public class DBString
{
    public string DbConnectionString { get; set; }
    public string ProviderName { get; set; }
}

#endregion