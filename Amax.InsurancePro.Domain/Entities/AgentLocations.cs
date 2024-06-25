using Dapper.Contrib.Extensions;

namespace Amax.InsurancePro.Domain.Entities;

[Table("AgentLocations")]
public partial class AgentLocations
{
    [Key]
    public int id { get; set; }

    public int AgentId { get; set; }

    public int LocationId { get; set; }

    public bool Deleted { get; set; }

    public bool defaultLocation { get; set; }


}
