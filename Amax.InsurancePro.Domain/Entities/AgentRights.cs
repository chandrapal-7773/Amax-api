namespace Amax.InsurancePro.Domain.Entities;
public class AgentRights
{
    #region Properties
    public bool HasAccessToMail { get; set; }

    public bool IsAdmin { get; set; }

    public bool HasAccessToReports { get; set; }

    public bool HasAccessToDeletePayments { get; set; }

    public bool HasAccessToDailyReports { get; set; }

    public bool HasAccessToSetupAgency { get; set; }

    public bool HasAccessToReconcile { get; set; }

    public bool HasAccessToWriteCheck { get; set; }

    public bool HasAccessToSetupAgentsCompanies { get; set; }

    public bool HasAccessToDeleteClients { get; set; }

    public bool HasAccessToEODReport { get; set; }

    #endregion

    public AgentRights()
    { 

    }

    public void SetRights(AgentInfo info)
    {
        IsAdmin = info.AdminAccess.HasValue ? info.AdminAccess.Value != 0 : false;
        HasAccessToMail = info.AgentRate.HasValue ? info.AgentRate.Value != 0 : false;
        HasAccessToReports = info.AccessReport.HasValue ? info.AccessReport.Value != 0 : false;
        HasAccessToDeletePayments = info.AccessDeletePay.HasValue ? info.AccessDeletePay.Value != 0 : false;
        HasAccessToDailyReports = info.AccessDaily.HasValue ? info.AccessDaily.Value != 0 : false;
        HasAccessToSetupAgency = info.AccessSetupAgency.HasValue ? info.AccessSetupAgency.Value != 0 : false;
        HasAccessToReconcile = info.AccessReconcile.HasValue ? info.AccessReconcile.Value != 0 : false;
        HasAccessToWriteCheck = info.AccessWriteCheck.HasValue ? info.AccessWriteCheck.Value != 0 : false;
        HasAccessToSetupAgentsCompanies = info.AccessPost.HasValue ? info.AccessPost.Value != 0 : false;
        HasAccessToDeleteClients = info.AccessDelPayClients.HasValue ? info.AccessDelPayClients.Value != 0 : false;
        HasAccessToEODReport = info.AccesEodreports.HasValue ? info.AccesEodreports.Value != 0 : false;
    }

    public void MakeAdmin()
    {
        IsAdmin = true;
        HasAccessToDeletePayments = true;
        HasAccessToWriteCheck = true;
        HasAccessToDailyReports = true;
        HasAccessToSetupAgentsCompanies = true;
        HasAccessToReconcile = true;
        HasAccessToReports = true;
        HasAccessToSetupAgency = true;
        HasAccessToMail = true;
    }
}
