

namespace Amax.InsurancePro.Domain.Entities;
public class UserLoginInfo
{
    public int UserId { get; set; }
    public string UserLoginId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public string Mobile { get; set; }
    public int PreferredRoleId { get; set; }
    public int OTPRemainingAttempts { get; set; }
    public bool OTPVerified { get; set; }
    public string OTP { get; set; }
    public bool Disabled { get; set; }
    public bool Active { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime PasswordUpdatedDate { get; set; }
    public AgentRights AgentRights { get; set; }
    public UserLoginInfo()
    {
        OTPRemainingAttempts = 1;
        OTPVerified = true;
        OTP = string.Empty;
        AgentRights = new AgentRights();
    }
}