using Dapper.Contrib.Extensions;

namespace Amax.InsurancePro.Domain.Entities;

[Table("AgentLogin")]
public partial class AgentLogin
{
    public Guid AgentDB { get; set; }
    public string AgentId { get; set; }
    public string AgentPassword { get; set; }
    public bool IsActive { get; set; }
    public int LoginAttempts { get; set; }

}
