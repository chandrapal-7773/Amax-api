namespace Amax.InsurancePro.Domain.Common;

public class Enums
{
    public enum DatabaseName
    {
        IPAdminDB = 0,
        AmaxDB = 1
    }

    public enum CommissionCollectionOptions
	{
        CheckToAgency = 0,
		AgencyRetainsFromDownPayment = 1,
		DirectDeposit = 2,
    }

	public enum CommissionBasedOnOptions
	{
		PremiumForEntireTerm = 0,
		MonthToMonthPayment = 1,
	}

    public enum CoPayMethodOptions
	{
		AgencyCheck = 0,
		DirectDebit = 1,
		DeductFromCommission = 2,
	}
    public enum CompanyFeeOptions
    {
		CollectedUpfront = 0,
		DividedAmongPayments = 2,
	}
}