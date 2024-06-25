using Dapper.Contrib.Extensions;

namespace Amax.InsurancePro.Domain.Entities;

[Table("agentInfo")]
public partial class AgentInfo
{
    [Key]
    public int AgentId { get; set; }

    public string? AgentName { get; set; }

    public string? AgentAddressLine1 { get; set; }

    public string? AgentAddressLine2 { get; set; }

    public string? AgentAddressCity { get; set; }

    public string? AgentAddressState { get; set; }

    public string? AgentAddressZip { get; set; }

    public string? AgentPhone1 { get; set; }

    public string? AgentPhone2 { get; set; }

    public string? AgentNotes { get; set; }

    public string? AgentPayType { get; set; }

    public int? AgentRate { get; set; }

    public double? AgentCommPercent { get; set; }

    public short? AgentActive { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public short? AdminAccess { get; set; }

    public short? AccessReport { get; set; }

    public short? AccessDeletePay { get; set; }

    public short? AccessDaily { get; set; }

    public short? AccessSetupAgency { get; set; }

    public short? AccessReconcile { get; set; }

    public short? AccessWriteCheck { get; set; }

    public string? AaAgentId { get; set; }

    public int? AgencyId { get; set; }

    public short? AccessPost { get; set; }

    public short? Logged { get; set; }

    public string? SignPic { get; set; }

    public short? Prefill { get; set; }

    public decimal? AgentFlatFee { get; set; }

    public int BLocked { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }

    public int DeletedBy { get; set; }

    public string EzlynxId { get; set; } = null!;

    public string TurboRaterId { get; set; } = null!;

    public int AgencyBuzzId { get; set; }

    public Guid? BatchId { get; set; }

    public int DefaultBankAccountId { get; set; }

    public DateTime SysUtcdateCreated { get; set; }

    public DateTime SysUtcdateModified { get; set; }

    public string? Email { get; set; }

    public string? Title { get; set; }

    public short? AccessDelPayClients { get; set; }

    public short? AccesEodreports { get; set; }

    public short? AccessAgencyFees { get; set; }

    public string? Password_Enc { get; set; }

    public DateTime PasswordUpdatedDate { get; set; }

    public short? ResetPassword { get; set; }


    //newly select locations ids
    [Write(false)]
	public List<int>? SelectedLocations { get; set; }

    //Agency entity after join
	[Write(false)]
	public List<AgencyInfo>? Agencies { get; set; }

}
