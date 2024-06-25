
using Amax.InsurancePro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Amax.InsurancePro.Repository;

public partial class AmaxDbContext : DbContext
{
    public AmaxDbContext(string connectionString)
        : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
    {

    }

    public IDbConnection Connection => Database.GetDbConnection();

    //public virtual DbSet<AccidentInfo> AccidentInfos { get; set; }

    //public virtual DbSet<Account> Accounts { get; set; }

    //public virtual DbSet<AgencyInfo> AgencyInfos { get; set; }

    //public virtual DbSet<AgencyInfoImport> AgencyInfoImports { get; set; }

    //public virtual DbSet<AgencyNew> AgencyNews { get; set; }

    public virtual DbSet<AgentInfo> AgentInfos { get; set; }

    //public virtual DbSet<AgentInfoBak> AgentInfoBaks { get; set; }

    //public virtual DbSet<AgentInfoImport> AgentInfoImports { get; set; }

    //public virtual DbSet<AgentLocation> AgentLocations { get; set; }

    //public virtual DbSet<ApplicantSearch> ApplicantSearches { get; set; }

    //public virtual DbSet<ArlingtonPolicy> ArlingtonPolicies { get; set; }

    //public virtual DbSet<Asof1115TblAfeesCommission> Asof1115TblAfeesCommissions { get; set; }

    //public virtual DbSet<Asof1115TblCommissionPayment> Asof1115TblCommissionPayments { get; set; }

    //public virtual DbSet<AutoPolicySearch> AutoPolicySearches { get; set; }

    //public virtual DbSet<BankAccount> BankAccounts { get; set; }

    //public virtual DbSet<BankAccountDetail> BankAccountDetails { get; set; }

    //public virtual DbSet<BankAccountDetailsbak> BankAccountDetailsbaks { get; set; }

    //public virtual DbSet<BridgeInfo> BridgeInfos { get; set; }

    //public virtual DbSet<BucknerPolice> BucknerPolices { get; set; }

    //public virtual DbSet<Carrier> Carriers { get; set; }

    //public virtual DbSet<CarrolltonPolicy> CarrolltonPolicies { get; set; }

    //public virtual DbSet<Centerville> Centervilles { get; set; }

    //public virtual DbSet<CertInfo> CertInfos { get; set; }

    //public virtual DbSet<CheckActive> CheckActives { get; set; }

    //public virtual DbSet<CheckSetting> CheckSettings { get; set; }

    //public virtual DbSet<ClientDeletion> ClientDeletions { get; set; }

    //public virtual DbSet<ClientInfo> ClientInfos { get; set; }

    //public virtual DbSet<ClientInfoimp> ClientInfoimps { get; set; }

    //public virtual DbSet<ClientInfoimp1> ClientInfoimp1s { get; set; }

    //public virtual DbSet<ClientInfoimp2> ClientInfoimp2s { get; set; }

    //public virtual DbSet<ClientInfoimp3> ClientInfoimp3s { get; set; }

    //public virtual DbSet<ClientInfoimp4> ClientInfoimp4s { get; set; }

    //public virtual DbSet<ClientSearch> ClientSearches { get; set; }

    //public virtual DbSet<Clientinfobak> Clientinfobaks { get; set; }

    //public virtual DbSet<Clientinfobak1> Clientinfobak1s { get; set; }

    //public virtual DbSet<CommFollowUp> CommFollowUps { get; set; }

    //public virtual DbSet<CommPer> CommPers { get; set; }

    //public virtual DbSet<CommercialCoverage> CommercialCoverages { get; set; }

    //public virtual DbSet<Commission> Commissions { get; set; }

    //public virtual DbSet<CommissionReport> CommissionReports { get; set; }

    //public virtual DbSet<CompanyInfo> CompanyInfos { get; set; }

    //public virtual DbSet<CompanyLog> CompanyLogs { get; set; }

    //public virtual DbSet<Companyinfobak> Companyinfobaks { get; set; }

    //public virtual DbSet<Companyinfoimport> Companyinfoimports { get; set; }

    //public virtual DbSet<Contact> Contacts { get; set; }

    //public virtual DbSet<ContactCategory> ContactCategories { get; set; }

    //public virtual DbSet<Coverage> Coverages { get; set; }

    //public virtual DbSet<DealerInfo> DealerInfos { get; set; }

    //public virtual DbSet<DownPayType> DownPayTypes { get; set; }

    //public virtual DbSet<DownloadSummary> DownloadSummaries { get; set; }

    //public virtual DbSet<DuplicateClientRemovalAgencyInfo> DuplicateClientRemovalAgencyInfos { get; set; }

    //public virtual DbSet<DuplicateClientRemovalKey> DuplicateClientRemovalKeys { get; set; }

    //public virtual DbSet<DuplicateClientRemovalLog> DuplicateClientRemovalLogs { get; set; }

    //public virtual DbSet<EmailAccount> EmailAccounts { get; set; }

    //public virtual DbSet<Endorsement> Endorsements { get; set; }

    //public virtual DbSet<Endorsementbak> Endorsementbaks { get; set; }

    //public virtual DbSet<Endorsementbak1> Endorsementbak1s { get; set; }

    //public virtual DbSet<Favorite> Favorites { get; set; }

    //public virtual DbSet<FeeType> FeeTypes { get; set; }

    //public virtual DbSet<FeeValue> FeeValues { get; set; }

    //public virtual DbSet<FeeValuesPolicy> FeeValuesPolicies { get; set; }

    //public virtual DbSet<FinCompany> FinCompanies { get; set; }

    //public virtual DbSet<Form> Forms { get; set; }

    //public virtual DbSet<HomeCoverage> HomeCoverages { get; set; }

    //public virtual DbSet<HomePolicySearch> HomePolicySearches { get; set; }

    //public virtual DbSet<Image> Images { get; set; }

    //public virtual DbSet<IrvingPolicy> IrvingPolicies { get; set; }

    //public virtual DbSet<Letter> Letters { get; set; }

    //public virtual DbSet<MailLog> MailLogs { get; set; }

    //public virtual DbSet<MakeDeposit> MakeDeposits { get; set; }

    //public virtual DbSet<MembershipType> MembershipTypes { get; set; }

    //public virtual DbSet<MesquitePolicy> MesquitePolicies { get; set; }

    //public virtual DbSet<Message> Messages { get; set; }

    //public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    //public virtual DbSet<MobileCoverage> MobileCoverages { get; set; }

    //public virtual DbSet<MonthlyPayReport> MonthlyPayReports { get; set; }

    //public virtual DbSet<MotorcyclePolicySearch> MotorcyclePolicySearches { get; set; }

    //public virtual DbSet<Naiccode> Naiccodes { get; set; }

    //public virtual DbSet<Name> Names { get; set; }

    //public virtual DbSet<NoteSearch> NoteSearches { get; set; }

    //public virtual DbSet<Option> Options { get; set; }

    //public virtual DbSet<PaymentFollowUp> PaymentFollowUps { get; set; }

    //public virtual DbSet<PaymentInfo> PaymentInfos { get; set; }

    //public virtual DbSet<PaymentInfoMrg> PaymentInfoMrgs { get; set; }

    //public virtual DbSet<PaymentSearch> PaymentSearches { get; set; }

    //public virtual DbSet<PaymentinfoBackup> PaymentinfoBackups { get; set; }

    //public virtual DbSet<PolicyCov> PolicyCovs { get; set; }

    //public virtual DbSet<PolicyField> PolicyFields { get; set; }

    //public virtual DbSet<PolicySearch> PolicySearches { get; set; }

    //public virtual DbSet<PolicyTab> PolicyTabs { get; set; }

    //public virtual DbSet<PolicyType> PolicyTypes { get; set; }

    //public virtual DbSet<PolicyValue> PolicyValues { get; set; }

    //public virtual DbSet<Polma> Polmas { get; set; }

    //public virtual DbSet<QbExport> QbExports { get; set; }

    //public virtual DbSet<Query> Queries { get; set; }

    //public virtual DbSet<Reminder> Reminders { get; set; }

    //public virtual DbSet<Remindersbak1> Remindersbak1s { get; set; }

    //public virtual DbSet<RenewFollowUp> RenewFollowUps { get; set; }

    //public virtual DbSet<Sr22> Sr22s { get; set; }

    //public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    //public virtual DbSet<TblAdditionalIncome> TblAdditionalIncomes { get; set; }

    //public virtual DbSet<TblAfeeCommRate> TblAfeeCommRates { get; set; }

    //public virtual DbSet<TblAfeesCommission> TblAfeesCommissions { get; set; }

    //public virtual DbSet<TblBankDeposit> TblBankDeposits { get; set; }

    //public virtual DbSet<TblCommissionPayment> TblCommissionPayments { get; set; }

    //public virtual DbSet<TblCompPayment> TblCompPayments { get; set; }

    //public virtual DbSet<TblCreditCardBatch> TblCreditCardBatches { get; set; }

    //public virtual DbSet<TblEodagencyFee> TblEodagencyFees { get; set; }

    //public virtual DbSet<TblEodreport> TblEodreports { get; set; }

    //public virtual DbSet<TblEodrptPayment> TblEodrptPayments { get; set; }

    //public virtual DbSet<TblIouUome> TblIouUomes { get; set; }

    //public virtual DbSet<TblMappedAgency> TblMappedAgencies { get; set; }

    //public virtual DbSet<TblRecordLock> TblRecordLocks { get; set; }

    //public virtual DbSet<TblRefund> TblRefunds { get; set; }

    //public virtual DbSet<TblSchemaChange> TblSchemaChanges { get; set; }

    //public virtual DbSet<TblSupplemental> TblSupplementals { get; set; }

    //public virtual DbSet<TblSweep> TblSweeps { get; set; }

    //public virtual DbSet<TblTitleTransfer> TblTitleTransfers { get; set; }

    //public virtual DbSet<TblVersion> TblVersions { get; set; }

    //public virtual DbSet<TempInfo> TempInfos { get; set; }

    //public virtual DbSet<TempaccidentInfo> TempaccidentInfos { get; set; }

    //public virtual DbSet<WriteCheck> WriteChecks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<AccidentInfo>(entity =>
        //{
        //    entity.HasKey(e => e.AccId);

        //    entity.ToTable("accidentInfo");

        //    entity.Property(e => e.AccId).HasColumnName("accID");
        //    entity.Property(e => e.AccDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("accDate");
        //    entity.Property(e => e.AccNotes)
        //        .HasColumnType("ntext")
        //        .HasColumnName("accNotes");
        //    entity.Property(e => e.Attr1)
        //        .HasMaxLength(20)
        //        .HasColumnName("attr1");
        //    entity.Property(e => e.Attr2)
        //        .HasMaxLength(20)
        //        .HasColumnName("attr2");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.DateDeleted)
        //        .HasColumnType("datetime")
        //        .HasColumnName("dateDeleted");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
        //    entity.Property(e => e.DriverFname)
        //        .HasMaxLength(20)
        //        .HasColumnName("driverFName");
        //    entity.Property(e => e.DriverLname)
        //        .HasMaxLength(20)
        //        .HasColumnName("driverLName");
        //    entity.Property(e => e.DriverNum).HasColumnName("driverNum");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.ViolCode).HasColumnName("violCode");
        //    entity.Property(e => e.Violation)
        //        .HasMaxLength(250)
        //        .HasColumnName("violation");
        //});

        //modelBuilder.Entity<Account>(entity =>
        //{
        //    entity.Property(e => e.AccountId).HasColumnName("accountID");
        //    entity.Property(e => e.Account1)
        //        .HasMaxLength(100)
        //        .HasColumnName("Account");
        //    entity.Property(e => e.DateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DefaultAmount)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("defaultAmount");
        //    entity.Property(e => e.DefaultFee)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("defaultFee");
        //    entity.Property(e => e.MinAmount)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("minAmount");
        //    entity.Property(e => e.MinFee)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("minFee");
        //    entity.Property(e => e.QbAccount)
        //        .HasMaxLength(100)
        //        .HasColumnName("qbAccount");
        //    entity.Property(e => e.Type).HasMaxLength(10);
        //});

        //modelBuilder.Entity<AgencyInfo>(entity =>
        //{
        //    entity.HasKey(e => e.AgencyId);

        //    entity.ToTable("agencyInfo");

        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AaLocId)
        //        .HasMaxLength(10)
        //        .HasColumnName("aaLocID");
        //    entity.Property(e => e.AgencyAddressCity)
        //        .HasMaxLength(20)
        //        .HasColumnName("agencyAddressCity");
        //    entity.Property(e => e.AgencyAddressLine1)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyAddressLine1");
        //    entity.Property(e => e.AgencyAddressLine2)
        //        .HasMaxLength(20)
        //        .HasColumnName("agencyAddressLine2");
        //    entity.Property(e => e.AgencyAddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("agencyAddressState");
        //    entity.Property(e => e.AgencyAddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("agencyAddressZip");
        //    entity.Property(e => e.AgencyBuzzLocationId).HasColumnName("AgencyBuzzLocationID");
        //    entity.Property(e => e.AgencyFax)
        //        .HasMaxLength(15)
        //        .HasColumnName("agencyFax");
        //    entity.Property(e => e.AgencyName)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyName");
        //    entity.Property(e => e.AgencyPhone1)
        //        .HasMaxLength(15)
        //        .HasColumnName("agencyPhone1");
        //    entity.Property(e => e.AgencyPhone2)
        //        .HasMaxLength(15)
        //        .HasColumnName("agencyPhone2");
        //    entity.Property(e => e.BatchId).HasColumnName("batchID");
        //    entity.Property(e => e.CodeName)
        //        .HasMaxLength(100)
        //        .HasColumnName("codeName");
        //    entity.Property(e => e.Count).HasColumnName("count");
        //    entity.Property(e => e.CurrentCheckNum).HasColumnName("currentCheckNum");
        //    entity.Property(e => e.CustomMsg)
        //        .HasMaxLength(200)
        //        .IsUnicode(false)
        //        .HasColumnName("customMsg");
        //    entity.Property(e => e.DateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DefaultBankAccountId).HasColumnName("DefaultBankAccountID");
        //    entity.Property(e => e.Demo).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.EndBalance)
        //        .HasMaxLength(50)
        //        .HasColumnName("endBalance");
        //    entity.Property(e => e.ExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("expDate");
        //    entity.Property(e => e.First)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("first");
        //    entity.Property(e => e.Logo)
        //        .HasMaxLength(200)
        //        .HasColumnName("logo");
        //    entity.Property(e => e.LogonRequired)
        //        .HasDefaultValueSql("((1))")
        //        .HasColumnName("logonRequired");
        //    entity.Property(e => e.Online).HasDefaultValueSql("((1))");
        //    entity.Property(e => e.Registered).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.StartBalance)
        //        .HasMaxLength(50)
        //        .HasColumnName("startBalance");
        //    entity.Property(e => e.StartDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("startDate");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<AgencyInfoImport>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("agencyInfoImport");

        //    entity.Property(e => e.AaLocId)
        //        .HasMaxLength(10)
        //        .HasColumnName("aaLocID");
        //    entity.Property(e => e.AgencyAddressCity)
        //        .HasMaxLength(20)
        //        .HasColumnName("agencyAddressCity");
        //    entity.Property(e => e.AgencyAddressLine1)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyAddressLine1");
        //    entity.Property(e => e.AgencyAddressLine2)
        //        .HasMaxLength(20)
        //        .HasColumnName("agencyAddressLine2");
        //    entity.Property(e => e.AgencyAddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("agencyAddressState");
        //    entity.Property(e => e.AgencyAddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("agencyAddressZip");
        //    entity.Property(e => e.AgencyBuzzLocationId).HasColumnName("AgencyBuzzLocationID");
        //    entity.Property(e => e.AgencyFax)
        //        .HasMaxLength(15)
        //        .HasColumnName("agencyFax");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgencyName)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyName");
        //    entity.Property(e => e.AgencyPhone1)
        //        .HasMaxLength(15)
        //        .HasColumnName("agencyPhone1");
        //    entity.Property(e => e.AgencyPhone2)
        //        .HasMaxLength(15)
        //        .HasColumnName("agencyPhone2");
        //    entity.Property(e => e.BatchId).HasColumnName("batchID");
        //    entity.Property(e => e.CodeName)
        //        .HasMaxLength(100)
        //        .HasColumnName("codeName");
        //    entity.Property(e => e.Count).HasColumnName("count");
        //    entity.Property(e => e.CurrentCheckNum).HasColumnName("currentCheckNum");
        //    entity.Property(e => e.CustomMsg)
        //        .HasMaxLength(200)
        //        .IsUnicode(false)
        //        .HasColumnName("customMsg");
        //    entity.Property(e => e.DateCreated).HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified).HasColumnType("datetime");
        //    entity.Property(e => e.DefaultBankAccountId).HasColumnName("DefaultBankAccountID");
        //    entity.Property(e => e.EndBalance)
        //        .HasMaxLength(50)
        //        .HasColumnName("endBalance");
        //    entity.Property(e => e.ExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("expDate");
        //    entity.Property(e => e.First).HasColumnName("first");
        //    entity.Property(e => e.Logo)
        //        .HasMaxLength(200)
        //        .HasColumnName("logo");
        //    entity.Property(e => e.LogonRequired).HasColumnName("logonRequired");
        //    entity.Property(e => e.StartBalance)
        //        .HasMaxLength(50)
        //        .HasColumnName("startBalance");
        //    entity.Property(e => e.StartDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("startDate");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<AgencyNew>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("AGENCY_New");

        //    entity.Property(e => e.Address1).HasMaxLength(255);
        //    entity.Property(e => e.Address2).HasMaxLength(255);
        //    entity.Property(e => e.AgencyId)
        //        .HasMaxLength(255)
        //        .HasColumnName("AgencyID");
        //    entity.Property(e => e.City).HasMaxLength(255);
        //    entity.Property(e => e.Dummy)
        //        .HasMaxLength(255)
        //        .HasColumnName("DUMMY");
        //    entity.Property(e => e.Email).HasMaxLength(255);
        //    entity.Property(e => e.IntConcurrentConnections)
        //        .HasMaxLength(255)
        //        .HasColumnName("intConcurrentConnections");
        //    entity.Property(e => e.Item)
        //        .HasMaxLength(255)
        //        .HasColumnName("ITEM");
        //    entity.Property(e => e.ListOrder).HasMaxLength(255);
        //    entity.Property(e => e.Phone1).HasMaxLength(255);
        //    entity.Property(e => e.Phone2).HasMaxLength(255);
        //    entity.Property(e => e.Set)
        //        .HasMaxLength(255)
        //        .HasColumnName("SET");
        //    entity.Property(e => e.StateCode).HasMaxLength(255);
        //    entity.Property(e => e.TotalIt)
        //        .HasMaxLength(255)
        //        .HasColumnName("TOTAL_IT");
        //});

        modelBuilder.Entity<AgentInfo>(entity =>
        {
            entity.HasKey(e => e.AgentId);

            entity.ToTable("agentInfo", tb => tb.HasTrigger("trg_agentInfo_AFTER_INSERT_OR_Update"));

            entity.HasIndex(e => e.UserId, "ix_AgentInfo_UserID");

            entity.HasIndex(e => e.AgencyId, "ix_FindClient_AgencyID_INCLUDE_AgentName");

            entity.HasIndex(e => e.AgentName, "ix_FindClient_AgentName");

            entity.Property(e => e.AgentId).HasColumnName("agentID");
            entity.Property(e => e.AaAgentId)
                .HasMaxLength(10)
                .HasColumnName("aaAgentID");
            entity.Property(e => e.AccesEodreports)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accesEODReports");
            entity.Property(e => e.AccessAgencyFees).HasDefaultValueSql("((1))");
            entity.Property(e => e.AccessDaily)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessDaily");
            entity.Property(e => e.AccessDelPayClients)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessDelPayClients");
            entity.Property(e => e.AccessDeletePay)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessDeletePay");
            entity.Property(e => e.AccessPost)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessPost");
            entity.Property(e => e.AccessReconcile)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessReconcile");
            entity.Property(e => e.AccessReport)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessReport");
            entity.Property(e => e.AccessSetupAgency)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessSetupAgency");
            entity.Property(e => e.AccessWriteCheck)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accessWriteCheck");
            entity.Property(e => e.AdminAccess)
                .HasDefaultValueSql("((0))")
                .HasColumnName("adminAccess");
            entity.Property(e => e.AgencyBuzzId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("AgencyBuzzID");
            entity.Property(e => e.AgencyId).HasColumnName("agencyID");
            entity.Property(e => e.AgentActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("agentActive");
            entity.Property(e => e.AgentAddressCity)
                .HasMaxLength(20)
                .HasColumnName("agentAddressCity");
            entity.Property(e => e.AgentAddressLine1)
                .HasMaxLength(50)
                .HasColumnName("agentAddressLine1");
            entity.Property(e => e.AgentAddressLine2)
                .HasMaxLength(20)
                .HasColumnName("agentAddressLine2");
            entity.Property(e => e.AgentAddressState)
                .HasMaxLength(10)
                .HasColumnName("agentAddressState");
            entity.Property(e => e.AgentAddressZip)
                .HasMaxLength(10)
                .HasColumnName("agentAddressZip");
            entity.Property(e => e.AgentCommPercent).HasColumnName("agentCommPercent");
            entity.Property(e => e.AgentFlatFee)
                .HasColumnType("money")
                .HasColumnName("agentFlatFee");
            entity.Property(e => e.AgentName)
                .HasMaxLength(60)
                .HasColumnName("agentName");
            entity.Property(e => e.AgentNotes)
                .HasMaxLength(255)
                .HasColumnName("agentNotes");
            entity.Property(e => e.AgentPayType)
                .HasMaxLength(10)
                .HasColumnName("agentPayType");
            entity.Property(e => e.AgentPhone1)
                .HasMaxLength(15)
                .HasColumnName("agentPhone1");
            entity.Property(e => e.AgentPhone2)
                .HasMaxLength(15)
                .HasColumnName("agentPhone2");
            entity.Property(e => e.AgentRate).HasColumnName("agentRate");
            entity.Property(e => e.BLocked).HasColumnName("bLocked");
            entity.Property(e => e.BatchId).HasColumnName("batchID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateDeleted).HasColumnType("datetime");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultBankAccountId).HasColumnName("DefaultBankAccountID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.EzlynxId)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("EZLynxID");
            entity.Property(e => e.Logged)
                .HasDefaultValueSql("((0))")
                .HasColumnName("logged");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Password_Enc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Password_enc");
            entity.Property(e => e.PasswordUpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("passwordUpdatedDate");
            entity.Property(e => e.Prefill)
                .HasDefaultValueSql("((1))")
                .HasColumnName("prefill");
            entity.Property(e => e.ResetPassword)
                .HasDefaultValueSql("((0))")
                .HasColumnName("resetPassword");
            entity.Property(e => e.SignPic)
                .HasMaxLength(250)
                .HasColumnName("signPic");
            entity.Property(e => e.SysUtcdateCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("sysUTCDateCreated");
            entity.Property(e => e.SysUtcdateModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("sysUTCDateModified");
            entity.Property(e => e.Title)
                .HasMaxLength(25)
                .HasColumnName("title");
            entity.Property(e => e.TurboRaterId)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("TurboRaterID");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("userID");
        });

        //modelBuilder.Entity<AgentInfoBak>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("AgentInfo_Bak");

        //    entity.Property(e => e.AaAgentId)
        //        .HasMaxLength(10)
        //        .HasColumnName("aaAgentID");
        //    entity.Property(e => e.AccesEodreports).HasColumnName("accesEODReports");
        //    entity.Property(e => e.AccessDaily).HasColumnName("accessDaily");
        //    entity.Property(e => e.AccessDelPayClients).HasColumnName("accessDelPayClients");
        //    entity.Property(e => e.AccessDeletePay).HasColumnName("accessDeletePay");
        //    entity.Property(e => e.AccessPost).HasColumnName("accessPost");
        //    entity.Property(e => e.AccessReconcile).HasColumnName("accessReconcile");
        //    entity.Property(e => e.AccessReport).HasColumnName("accessReport");
        //    entity.Property(e => e.AccessSetupAgency).HasColumnName("accessSetupAgency");
        //    entity.Property(e => e.AccessWriteCheck).HasColumnName("accessWriteCheck");
        //    entity.Property(e => e.AdminAccess).HasColumnName("adminAccess");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentActive).HasColumnName("agentActive");
        //    entity.Property(e => e.AgentAddressCity)
        //        .HasMaxLength(20)
        //        .HasColumnName("agentAddressCity");
        //    entity.Property(e => e.AgentAddressLine1)
        //        .HasMaxLength(50)
        //        .HasColumnName("agentAddressLine1");
        //    entity.Property(e => e.AgentAddressLine2)
        //        .HasMaxLength(20)
        //        .HasColumnName("agentAddressLine2");
        //    entity.Property(e => e.AgentAddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("agentAddressState");
        //    entity.Property(e => e.AgentAddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("agentAddressZip");
        //    entity.Property(e => e.AgentCommPercent).HasColumnName("agentCommPercent");
        //    entity.Property(e => e.AgentFlatFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agentFlatFee");
        //    entity.Property(e => e.AgentId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("agentID");
        //    entity.Property(e => e.AgentName)
        //        .HasMaxLength(60)
        //        .HasColumnName("agentName");
        //    entity.Property(e => e.AgentNotes)
        //        .HasMaxLength(255)
        //        .HasColumnName("agentNotes");
        //    entity.Property(e => e.AgentPayType)
        //        .HasMaxLength(10)
        //        .HasColumnName("agentPayType");
        //    entity.Property(e => e.AgentPhone1)
        //        .HasMaxLength(15)
        //        .HasColumnName("agentPhone1");
        //    entity.Property(e => e.AgentPhone2)
        //        .HasMaxLength(15)
        //        .HasColumnName("agentPhone2");
        //    entity.Property(e => e.AgentRate).HasColumnName("agentRate");
        //    entity.Property(e => e.BLocked).HasColumnName("bLocked");
        //    entity.Property(e => e.BatchId).HasColumnName("batchID");
        //    entity.Property(e => e.DateCreated).HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified).HasColumnType("datetime");
        //    entity.Property(e => e.DefaultBankAccountId).HasColumnName("DefaultBankAccountID");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.EzlynxId)
        //        .HasMaxLength(100)
        //        .HasColumnName("EZLynxID");
        //    entity.Property(e => e.Logged).HasColumnName("logged");
        //    entity.Property(e => e.Password)
        //        .HasMaxLength(50)
        //        .HasColumnName("password");
        //    entity.Property(e => e.Prefill).HasColumnName("prefill");
        //    entity.Property(e => e.SignPic)
        //        .HasMaxLength(250)
        //        .HasColumnName("signPic");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Title)
        //        .HasMaxLength(25)
        //        .HasColumnName("title");
        //    entity.Property(e => e.TurboRaterId)
        //        .HasMaxLength(100)
        //        .HasColumnName("TurboRaterID");
        //    entity.Property(e => e.UserId)
        //        .HasMaxLength(100)
        //        .HasColumnName("userID");
        //});

        //modelBuilder.Entity<AgentInfoImport>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("AgentInfo_Import");

        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentName)
        //        .HasMaxLength(255)
        //        .HasColumnName("agentName");
        //    entity.Property(e => e.CurrentEmail).HasMaxLength(255);
        //    entity.Property(e => e.NewEmail).HasMaxLength(255);
        //});

        //modelBuilder.Entity<AgentLocation>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__AgentLoc__3213E83FC03CBC00");

        //    entity.HasIndex(e => e.AgentId, "IX_AgentID_WITH_INCLUDES_Covering");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.DefaultLocation).HasColumnName("defaultLocation");
        //});

        //modelBuilder.Entity<ApplicantSearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("ApplicantSearch");

        //    entity.Property(e => e.Anniversary)
        //        .HasColumnType("datetime")
        //        .HasColumnName("anniversary");
        //    entity.Property(e => e.ApplicantId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("ApplicantID");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(101)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.Carriername)
        //        .HasMaxLength(100)
        //        .HasColumnName("carriername");
        //    entity.Property(e => e.Carrierpolicynumber)
        //        .HasMaxLength(256)
        //        .HasColumnName("carrierpolicynumber");
        //    entity.Property(e => e.Cellphone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellphone");
        //    entity.Property(e => e.Emailaddress)
        //        .HasMaxLength(100)
        //        .HasColumnName("emailaddress");
        //    entity.Property(e => e.Emailstatus)
        //        .HasMaxLength(50)
        //        .HasColumnName("emailstatus");
        //    entity.Property(e => e.Garagingaddress1)
        //        .HasMaxLength(60)
        //        .HasColumnName("garagingaddress1");
        //    entity.Property(e => e.Garagingcity)
        //        .HasMaxLength(50)
        //        .HasColumnName("garagingcity");
        //    entity.Property(e => e.Garagingstate)
        //        .HasMaxLength(10)
        //        .HasColumnName("garagingstate");
        //    entity.Property(e => e.Garagingzipcode)
        //        .HasMaxLength(10)
        //        .HasColumnName("garagingzipcode");
        //    entity.Property(e => e.Homephone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homephone");
        //    entity.Property(e => e.Mailingaddress1)
        //        .HasMaxLength(250)
        //        .HasColumnName("mailingaddress1");
        //    entity.Property(e => e.Mailingcity)
        //        .HasMaxLength(50)
        //        .HasColumnName("mailingcity");
        //    entity.Property(e => e.Mailingstate)
        //        .HasMaxLength(25)
        //        .HasColumnName("mailingstate");
        //    entity.Property(e => e.Mailingzipcode)
        //        .HasMaxLength(10)
        //        .HasColumnName("mailingzipcode");
        //    entity.Property(e => e.Monthlypayment).HasColumnName("monthlypayment");
        //    entity.Property(e => e.Nativelanguage)
        //        .HasMaxLength(50)
        //        .HasColumnName("nativelanguage");
        //    entity.Property(e => e.Ownhome).HasColumnName("ownhome");
        //    entity.Property(e => e.Paymentdueday).HasColumnName("paymentdueday");
        //    entity.Property(e => e.Policytype)
        //        .HasMaxLength(20)
        //        .HasColumnName("policytype");
        //    entity.Property(e => e.Workphone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workphone");
        //});

        //modelBuilder.Entity<ArlingtonPolicy>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Agency)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENCY");
        //    entity.Property(e => e.Agent)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENT");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Fname)
        //        .HasMaxLength(28)
        //        .IsUnicode(false)
        //        .HasColumnName("FNAME");
        //    entity.Property(e => e.Lname)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LNAME");
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.QfPid).HasColumnName("QF_PID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Asof1115TblAfeesCommission>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("asof_11_15_tblAFeesCommissions");

        //    entity.Property(e => e.AfeeAmt).HasColumnType("money");
        //    entity.Property(e => e.CommAmt).HasColumnType("money");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
        //    entity.Property(e => e.DeletedDate).HasColumnName("deletedDate");
        //    entity.Property(e => e.Id)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("id");
        //    entity.Property(e => e.PdAmount).HasColumnType("money");
        //    entity.Property(e => e.PdCheckNum)
        //        .HasMaxLength(100)
        //        .HasColumnName("pdCheckNum");
        //    entity.Property(e => e.PdDate)
        //        .HasColumnType("date")
        //        .HasColumnName("pdDate");
        //    entity.Property(e => e.Rec).HasColumnName("rec");
        //    entity.Property(e => e.SysUtcdateCreated).HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified).HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<Asof1115TblCommissionPayment>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("asof_11_15_tblCommissionPayments");

        //    entity.Property(e => e.CommissionDate).HasColumnType("datetime");
        //    entity.Property(e => e.CommissionId).HasColumnName("CommissionID");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby).HasColumnName("deletedby");
        //    entity.Property(e => e.Id)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("id");
        //    entity.Property(e => e.PayDate).HasColumnType("datetime");
        //    entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModifed)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModifed");
        //});

        //modelBuilder.Entity<AutoPolicySearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("AutoPolicySearch");

        //    entity.Property(e => e.Address1).HasMaxLength(60);
        //    entity.Property(e => e.AgentCommission).HasColumnType("money");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(101)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.BodyType1).HasMaxLength(20);
        //    entity.Property(e => e.BodyType2).HasMaxLength(20);
        //    entity.Property(e => e.BodyType3).HasMaxLength(20);
        //    entity.Property(e => e.BodyType4).HasMaxLength(20);
        //    entity.Property(e => e.BodyType5).HasMaxLength(20);
        //    entity.Property(e => e.BodyType6).HasMaxLength(20);
        //    entity.Property(e => e.BusinessName).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone).HasMaxLength(25);
        //    entity.Property(e => e.City).HasMaxLength(50);
        //    entity.Property(e => e.CollDeductible1).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible2).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible3).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible4).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible5).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible6).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible1).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible2).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible3).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible4).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible5).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible6).HasMaxLength(10);
        //    entity.Property(e => e.Companyname)
        //        .HasMaxLength(50)
        //        .HasColumnName("companyname");
        //    entity.Property(e => e.DateCancelled).HasColumnType("smalldatetime");
        //    entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");
        //    entity.Property(e => e.Dob1)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB1");
        //    entity.Property(e => e.Dob2)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB2");
        //    entity.Property(e => e.Dob3)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB3");
        //    entity.Property(e => e.Dob4)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB4");
        //    entity.Property(e => e.Dob5)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB5");
        //    entity.Property(e => e.Dob6)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB6");
        //    entity.Property(e => e.DriverLicenseNumber1)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber2)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber3)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber4)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber5)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber6)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.EmailAddress).HasMaxLength(100);
        //    entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.FaxNumber).HasMaxLength(25);
        //    entity.Property(e => e.FirstName1).HasMaxLength(50);
        //    entity.Property(e => e.FirstName2).HasMaxLength(50);
        //    entity.Property(e => e.FirstName3).HasMaxLength(50);
        //    entity.Property(e => e.FirstName4).HasMaxLength(50);
        //    entity.Property(e => e.FirstName5).HasMaxLength(50);
        //    entity.Property(e => e.FirstName6).HasMaxLength(50);
        //    entity.Property(e => e.InitialPremium).HasColumnType("money");
        //    entity.Property(e => e.LastName1).HasMaxLength(50);
        //    entity.Property(e => e.LastName2).HasMaxLength(50);
        //    entity.Property(e => e.LastName3).HasMaxLength(50);
        //    entity.Property(e => e.LastName4).HasMaxLength(50);
        //    entity.Property(e => e.LastName5).HasMaxLength(50);
        //    entity.Property(e => e.LastName6).HasMaxLength(50);
        //    entity.Property(e => e.Lastpaymentamount)
        //        .HasColumnType("money")
        //        .HasColumnName("lastpaymentamount");
        //    entity.Property(e => e.Lastpaymentdate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("lastpaymentdate");
        //    entity.Property(e => e.LiabBilimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("LiabBILimits");
        //    entity.Property(e => e.LiabPdlimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("LiabPDLimits");
        //    entity.Property(e => e.LicensePeriod1).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod2).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod3).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod4).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod5).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod6).HasMaxLength(10);
        //    entity.Property(e => e.MailingAddress1).HasMaxLength(250);
        //    entity.Property(e => e.MailingCity).HasMaxLength(50);
        //    entity.Property(e => e.MailingState).HasMaxLength(25);
        //    entity.Property(e => e.MailingZipCode).HasMaxLength(10);
        //    entity.Property(e => e.Make1).HasMaxLength(20);
        //    entity.Property(e => e.Make2).HasMaxLength(20);
        //    entity.Property(e => e.Make3).HasMaxLength(20);
        //    entity.Property(e => e.Make4).HasMaxLength(20);
        //    entity.Property(e => e.Make5).HasMaxLength(20);
        //    entity.Property(e => e.Make6).HasMaxLength(20);
        //    entity.Property(e => e.Marital1).HasMaxLength(10);
        //    entity.Property(e => e.Marital2).HasMaxLength(10);
        //    entity.Property(e => e.Marital3).HasMaxLength(10);
        //    entity.Property(e => e.Marital4).HasMaxLength(10);
        //    entity.Property(e => e.Marital5).HasMaxLength(10);
        //    entity.Property(e => e.Marital6).HasMaxLength(10);
        //    entity.Property(e => e.MedPayLimit).HasMaxLength(10);
        //    entity.Property(e => e.Model1).HasMaxLength(40);
        //    entity.Property(e => e.Model2).HasMaxLength(40);
        //    entity.Property(e => e.Model3).HasMaxLength(40);
        //    entity.Property(e => e.Model4).HasMaxLength(40);
        //    entity.Property(e => e.Model5).HasMaxLength(40);
        //    entity.Property(e => e.Model6).HasMaxLength(40);
        //    entity.Property(e => e.Phone).HasMaxLength(25);
        //    entity.Property(e => e.Piplimit)
        //        .HasMaxLength(10)
        //        .HasColumnName("PIPLimit");
        //    entity.Property(e => e.PolicyFee).HasColumnType("money");
        //    entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
        //    entity.Property(e => e.PolicyType).HasMaxLength(20);
        //    entity.Property(e => e.Policynumber)
        //        .HasMaxLength(256)
        //        .HasColumnName("policynumber");
        //    entity.Property(e => e.QuoteStatus).HasMaxLength(20);
        //    entity.Property(e => e.Relation1).HasMaxLength(10);
        //    entity.Property(e => e.Relation2).HasMaxLength(10);
        //    entity.Property(e => e.Relation3).HasMaxLength(10);
        //    entity.Property(e => e.Relation4).HasMaxLength(10);
        //    entity.Property(e => e.Relation5).HasMaxLength(10);
        //    entity.Property(e => e.Relation6).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit1).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit2).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit3).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit4).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit5).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit6).HasMaxLength(10);
        //    entity.Property(e => e.Sex1).HasMaxLength(6);
        //    entity.Property(e => e.Sex2).HasMaxLength(6);
        //    entity.Property(e => e.Sex3).HasMaxLength(6);
        //    entity.Property(e => e.Sex4).HasMaxLength(6);
        //    entity.Property(e => e.Sex5).HasMaxLength(6);
        //    entity.Property(e => e.Sex6).HasMaxLength(6);
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN6");
        //    entity.Property(e => e.State).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed1).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed2).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed3).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed4).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed5).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed6).HasMaxLength(10);
        //    entity.Property(e => e.Term).HasMaxLength(20);
        //    entity.Property(e => e.TowingLimit1).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit2).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit3).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit4).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit5).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit6).HasMaxLength(10);
        //    entity.Property(e => e.UnderinsBilimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UnderinsBIlimits");
        //    entity.Property(e => e.UnderinsPdlimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UnderinsPDlimits");
        //    entity.Property(e => e.UninsBilimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UninsBILimits");
        //    entity.Property(e => e.UninsPdlimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UninsPDLimits");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN6");
        //    entity.Property(e => e.WorkPhone).HasMaxLength(25);
        //    entity.Property(e => e.ZipCode).HasMaxLength(10);
        //});

        //modelBuilder.Entity<BankAccount>(entity =>
        //{
        //    entity.HasKey(e => e.BankId);

        //    entity.ToTable("bankAccounts");

        //    entity.Property(e => e.BankId).HasColumnName("bankID");
        //    entity.Property(e => e.AccBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("accBalance");
        //    entity.Property(e => e.AccName)
        //        .HasMaxLength(200)
        //        .HasColumnName("accName");
        //    entity.Property(e => e.AccStartBal)
        //        .HasColumnType("money")
        //        .HasColumnName("accStartBal");
        //    entity.Property(e => e.AccType)
        //        .HasMaxLength(200)
        //        .HasColumnName("accType");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.EndBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("endBalance");
        //    entity.Property(e => e.StartBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("startBalance");
        //});

        //modelBuilder.Entity<BankAccountDetail>(entity =>
        //{
        //    entity.HasKey(e => e.BankAccountId);

        //    entity.ToTable("bankAccountDetails", tb => tb.HasTrigger("trg_bankAccountDetails_AFTER_INSERT_OR_Update"));

        //    entity.Property(e => e.BankAccountId).HasColumnName("bankAccountID");
        //    entity.Property(e => e.AccountNumber)
        //        .HasMaxLength(50)
        //        .HasColumnName("accountNumber");
        //    entity.Property(e => e.AccountNumberEnc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("AccountNumber_enc");
        //    entity.Property(e => e.AccountType)
        //        .HasMaxLength(10)
        //        .HasColumnName("accountType");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.Qbaccount)
        //        .HasMaxLength(50)
        //        .HasColumnName("QBAccount");
        //    entity.Property(e => e.RoutingNumber)
        //        .HasMaxLength(50)
        //        .HasColumnName("routingNumber");
        //});

        //modelBuilder.Entity<BankAccountDetailsbak>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("bankAccountDetailsbak");

        //    entity.Property(e => e.AccountNumber)
        //        .HasMaxLength(50)
        //        .HasColumnName("accountNumber");
        //    entity.Property(e => e.AccountType)
        //        .HasMaxLength(10)
        //        .HasColumnName("accountType");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.BankAccountId).HasColumnName("bankAccountID");
        //    entity.Property(e => e.Qbaccount)
        //        .HasMaxLength(50)
        //        .HasColumnName("QBAccount");
        //    entity.Property(e => e.RoutingNumber)
        //        .HasMaxLength(50)
        //        .HasColumnName("routingNumber");
        //});

        //modelBuilder.Entity<BridgeInfo>(entity =>
        //{
        //    entity.HasKey(e => e.ClientId);

        //    entity.ToTable("bridgeInfo", tb => tb.HasTrigger("trg_bridgeInfo_AFTER_INSERT_OR_Update"));

        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentPaid)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("agentPaid");
        //    entity.Property(e => e.Anniversary).HasColumnType("smalldatetime");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(100)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.CellPhone1)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone1");
        //    entity.Property(e => e.CellPhone2)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone2");
        //    entity.Property(e => e.CellPhone3)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone3");
        //    entity.Property(e => e.CellPhone4)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone4");
        //    entity.Property(e => e.CellPhone5)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone5");
        //    entity.Property(e => e.CellPhone6)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone6");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl1Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL1_enc");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl2Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL2_enc");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl3Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL3_enc");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl4Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL4_enc");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl5Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL5_enc");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.Dl6Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL6_enc");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.EdLevel1)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel2)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel3)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel4)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel5)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel6)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.EmailStatus)
        //        .HasMaxLength(50)
        //        .HasColumnName("emailStatus");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(50)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(50)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(50)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(50)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OccIndustry1).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry2).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry3).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry4).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry5).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry6).HasMaxLength(75);
        //    entity.Property(e => e.Occup1).HasMaxLength(50);
        //    entity.Property(e => e.Occup2).HasMaxLength(50);
        //    entity.Property(e => e.Occup3).HasMaxLength(50);
        //    entity.Property(e => e.Occup4).HasMaxLength(50);
        //    entity.Property(e => e.Occup5).HasMaxLength(50);
        //    entity.Property(e => e.Occup6).HasMaxLength(50);
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn1Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN1_enc");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn2Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN2_enc");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn3Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN3_enc");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn4Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN4_enc");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn5Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN5_enc");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Ssn6Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN6_enc");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.Uimpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimpd");
        //    entity.Property(e => e.UimpdIndex).HasColumnName("uimpdIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<BucknerPolice>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Agency)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENCY");
        //    entity.Property(e => e.Agent)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENT");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Fname)
        //        .HasMaxLength(28)
        //        .IsUnicode(false)
        //        .HasColumnName("FNAME");
        //    entity.Property(e => e.Lname)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LNAME");
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.QfPid).HasColumnName("QF_PID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Carrier>(entity =>
        //{
        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Carrier1)
        //        .HasMaxLength(250)
        //        .HasColumnName("carrier");
        //});

        //modelBuilder.Entity<CarrolltonPolicy>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Agency)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENCY");
        //    entity.Property(e => e.Agent)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENT");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Fname)
        //        .HasMaxLength(28)
        //        .IsUnicode(false)
        //        .HasColumnName("FNAME");
        //    entity.Property(e => e.Lname)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LNAME");
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.QfPid).HasColumnName("QF_PID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Centerville>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Centerville");

        //    entity.Property(e => e.Agency)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENCY");
        //    entity.Property(e => e.Agent)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENT");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Fname)
        //        .HasMaxLength(28)
        //        .IsUnicode(false)
        //        .HasColumnName("FNAME");
        //    entity.Property(e => e.Lname)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LNAME");
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.QfPid).HasColumnName("QF_PID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<CertInfo>(entity =>
        //{
        //    entity.HasKey(e => e.LienId);

        //    entity.ToTable("certInfo");

        //    entity.Property(e => e.LienId).HasColumnName("lienID");
        //    entity.Property(e => e.Binder)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("binder");
        //    entity.Property(e => e.BridgeId).HasColumnName("bridgeID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.LienAddress)
        //        .HasMaxLength(200)
        //        .HasColumnName("lienAddress");
        //    entity.Property(e => e.LienDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("lienDate");
        //    entity.Property(e => e.LienFax)
        //        .HasMaxLength(100)
        //        .HasColumnName("lienFax");
        //    entity.Property(e => e.LienName)
        //        .HasMaxLength(100)
        //        .HasColumnName("lienName");
        //    entity.Property(e => e.LienNotes)
        //        .HasMaxLength(1000)
        //        .HasColumnName("lienNotes");
        //    entity.Property(e => e.LienPhone)
        //        .HasMaxLength(100)
        //        .HasColumnName("lienPhone");
        //    entity.Property(e => e.LienType)
        //        .HasMaxLength(100)
        //        .HasColumnName("lienType");
        //    entity.Property(e => e.LoanNum)
        //        .HasMaxLength(100)
        //        .HasColumnName("loanNum");
        //    entity.Property(e => e.VehDesc)
        //        .HasMaxLength(200)
        //        .HasColumnName("vehDesc");
        //});

        //modelBuilder.Entity<CheckActive>(entity =>
        //{
        //    entity.ToTable("checkActive");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.CheckBy).HasColumnName("checkBy");
        //    entity.Property(e => e.CheckFor).HasColumnName("checkFor");
        //});

        //modelBuilder.Entity<CheckSetting>(entity =>
        //{
        //    entity.HasKey(e => e.DateTop);

        //    entity.ToTable("checkSettings");

        //    entity.Property(e => e.DateTop).HasColumnName("dateTop");
        //    entity.Property(e => e.DateLeft).HasColumnName("dateLeft");
        //    entity.Property(e => e.MemoLeft).HasColumnName("memoLeft");
        //    entity.Property(e => e.MemoTop).HasColumnName("memoTop");
        //    entity.Property(e => e.NamountLeft).HasColumnName("namountLeft");
        //    entity.Property(e => e.NamountTop).HasColumnName("namountTop");
        //    entity.Property(e => e.PayeeLeft).HasColumnName("payeeLeft");
        //    entity.Property(e => e.PayeeTop).HasColumnName("payeeTop");
        //    entity.Property(e => e.WamountLeft).HasColumnName("wamountLeft");
        //    entity.Property(e => e.WamountTop).HasColumnName("wamountTop");
        //});

        //modelBuilder.Entity<ClientDeletion>(entity =>
        //{
        //    entity.ToTable("clientDeletions");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(255)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.DeletedBy)
        //        .HasMaxLength(255)
        //        .HasColumnName("deletedBy");
        //    entity.Property(e => e.DeletedById).HasColumnName("deletedByID");
        //    entity.Property(e => e.DeletedOn)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedOn");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(255)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(255)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(255)
        //        .HasColumnName("quoteStatus");
        //});

        //modelBuilder.Entity<ClientInfo>(entity =>
        //{
        //    entity.HasKey(e => e.ClientId);

        //    entity.ToTable("clientInfo", tb => tb.HasTrigger("trg_clientInfo_AFTER_INSERT_OR_Update"));

        //    entity.HasIndex(e => e.Deleted, "ClientsDeleted");

        //    entity.HasIndex(e => e.QuoteStatus, "IX_FindClient");

        //    entity.HasIndex(e => e.PolicyType, "IX_HoSearchView_Support");

        //    entity.HasIndex(e => e.ClientId, "IX_clientInfo");

        //    entity.HasIndex(e => e.FileNum, "IX_clientInfo_FileNum");

        //    entity.HasIndex(e => e.PolicyEffDate, "IX_clientInfo_PolicyEffDate");

        //    entity.HasIndex(e => e.PolicyExpDate, "IX_clientInfo_PolicyExpDate");

        //    entity.HasIndex(e => e.ApplicantName, "IX_clientInfo_applicantName");

        //    entity.HasIndex(e => e.ApplicantName, "IX_clientInfo_applicantName_WITH_INCLUDES_Client_Search_Covering");

        //    entity.HasIndex(e => e.PolicyNum, "IX_clientInfo_policyNum");

        //    entity.HasIndex(e => e.PolicyType, "IX_clientInfo_policyType");

        //    entity.HasIndex(e => e.QuoteStatus, "IX_clientInfo_quoteStatus");

        //    entity.HasIndex(e => e.Assoc, "IX_dbo_clientInfo_Assoc");

        //    entity.HasIndex(e => new { e.AgentId, e.AgencyId, e.Deleted, e.PolicyEffDate, e.QuoteStatus }, "ix_ClientInfo_agentID_agencyID_Deleted_policyEffDate_quoteStatus");

        //    entity.HasIndex(e => new { e.ApplicantName, e.PolicyNum }, "ix_ClientInfo_applicantname_policynum");

        //    entity.HasIndex(e => new { e.ClientId, e.Assoc }, "ix_ClientInfo_clientID_Assoc");

        //    entity.HasIndex(e => e.ClientId, "ix_ClientSearchView_Support");

        //    entity.HasIndex(e => e.CompanyId, "ix_FindClient_CompanyID_WITH_INCLUDES");

        //    entity.HasIndex(e => e.ClientId, "ix_PolicySearchView_Support");

        //    entity.HasIndex(e => e.Dl1, "ix_PolicySearch_DLNUmber");

        //    entity.HasIndex(e => new { e.AgencyId, e.Deleted, e.QuoteStatus, e.PmtDueDay }, "ix_clientInfo_AgencyID_Deleted_Quotestatus_PmtDueDate");

        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.Anniversary).HasColumnType("smalldatetime");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(101)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Assoc).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.CellPhone1)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone1");
        //    entity.Property(e => e.CellPhone2)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone2");
        //    entity.Property(e => e.CellPhone3)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone3");
        //    entity.Property(e => e.CellPhone4)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone4");
        //    entity.Property(e => e.CellPhone5)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone5");
        //    entity.Property(e => e.CellPhone6)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone6");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl1Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL1_enc");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl2Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL2_enc");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl3Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL3_enc");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl4Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL4_enc");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl5Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL5_enc");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.Dl6Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL6_enc");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.EdLevel1).HasMaxLength(40);
        //    entity.Property(e => e.EdLevel2).HasMaxLength(40);
        //    entity.Property(e => e.EdLevel3).HasMaxLength(40);
        //    entity.Property(e => e.EdLevel4).HasMaxLength(40);
        //    entity.Property(e => e.EdLevel5).HasMaxLength(40);
        //    entity.Property(e => e.EdLevel6).HasMaxLength(40);
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.EmailStatus)
        //        .HasMaxLength(50)
        //        .HasColumnName("emailStatus");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(50)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(50)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(50)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(50)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OccIndustry1).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry2).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry3).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry4).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry5).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry6).HasMaxLength(75);
        //    entity.Property(e => e.Occup1).HasMaxLength(50);
        //    entity.Property(e => e.Occup2).HasMaxLength(50);
        //    entity.Property(e => e.Occup3).HasMaxLength(50);
        //    entity.Property(e => e.Occup4).HasMaxLength(50);
        //    entity.Property(e => e.Occup5).HasMaxLength(50);
        //    entity.Property(e => e.Occup6).HasMaxLength(50);
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn1Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN1_enc");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn2Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN2_enc");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn3Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN3_enc");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn4Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN4_enc");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn5Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN5_enc");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Ssn6Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN6_enc");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.Uimpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimpd");
        //    entity.Property(e => e.UimpdIndex).HasColumnName("uimpdIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<ClientInfoimp>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientInfoimp");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.NewClientId).HasColumnName("NewClientID");
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.UimPd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimPD");
        //    entity.Property(e => e.UimPdindex).HasColumnName("uimPDIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<ClientInfoimp1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientInfoimp1");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.Newclientid).HasColumnName("newclientid");
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.UimPd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimPD");
        //    entity.Property(e => e.UimPdindex).HasColumnName("uimPDIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<ClientInfoimp2>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientInfoimp2");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.Newclientid).HasColumnName("newclientid");
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.UimPd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimPD");
        //    entity.Property(e => e.UimPdindex).HasColumnName("uimPDIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<ClientInfoimp3>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientInfoimp3");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.Newclientid).HasColumnName("newclientid");
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.UimPd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimPD");
        //    entity.Property(e => e.UimPdindex).HasColumnName("uimPDIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<ClientInfoimp4>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientInfoimp4");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.Newclientid).HasColumnName("newclientid");
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.UimPd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimPD");
        //    entity.Property(e => e.UimPdindex).HasColumnName("uimPDIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<ClientSearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("ClientSearch");

        //    entity.Property(e => e.Address1)
        //        .HasMaxLength(60)
        //        .HasColumnName("address1");
        //    entity.Property(e => e.Businessname)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessname");
        //    entity.Property(e => e.Cellphone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellphone");
        //    entity.Property(e => e.City)
        //        .HasMaxLength(50)
        //        .HasColumnName("city");
        //    entity.Property(e => e.Dob)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB");
        //    entity.Property(e => e.DriverLicenseNumber)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Emailaddress)
        //        .HasMaxLength(100)
        //        .HasColumnName("emailaddress");
        //    entity.Property(e => e.Faxnumber)
        //        .HasMaxLength(25)
        //        .HasColumnName("faxnumber");
        //    entity.Property(e => e.Firstname)
        //        .HasMaxLength(50)
        //        .HasColumnName("firstname");
        //    entity.Property(e => e.Lastname)
        //        .HasMaxLength(50)
        //        .HasColumnName("lastname");
        //    entity.Property(e => e.Licenseperiod)
        //        .HasMaxLength(10)
        //        .HasColumnName("licenseperiod");
        //    entity.Property(e => e.Mailingaddress1)
        //        .HasMaxLength(250)
        //        .HasColumnName("mailingaddress1");
        //    entity.Property(e => e.Mailingcity)
        //        .HasMaxLength(50)
        //        .HasColumnName("mailingcity");
        //    entity.Property(e => e.Mailingstate)
        //        .HasMaxLength(25)
        //        .HasColumnName("mailingstate");
        //    entity.Property(e => e.Mailingzipcode)
        //        .HasMaxLength(10)
        //        .HasColumnName("mailingzipcode");
        //    entity.Property(e => e.Marital)
        //        .HasMaxLength(10)
        //        .HasColumnName("marital");
        //    entity.Property(e => e.Phone)
        //        .HasMaxLength(25)
        //        .HasColumnName("phone");
        //    entity.Property(e => e.Policyid)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("policyid");
        //    entity.Property(e => e.Relation)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation");
        //    entity.Property(e => e.Sex)
        //        .HasMaxLength(6)
        //        .HasColumnName("sex");
        //    entity.Property(e => e.Ssn)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN");
        //    entity.Property(e => e.State)
        //        .HasMaxLength(10)
        //        .HasColumnName("STATE");
        //    entity.Property(e => e.Statelicensed)
        //        .HasMaxLength(10)
        //        .HasColumnName("statelicensed");
        //    entity.Property(e => e.Workphone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workphone");
        //    entity.Property(e => e.Zipcode)
        //        .HasMaxLength(10)
        //        .HasColumnName("zipcode");
        //});

        //modelBuilder.Entity<Clientinfobak>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientinfobak");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.Uimpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimpd");
        //    entity.Property(e => e.UimpdIndex).HasColumnName("uimpdIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<Clientinfobak1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("clientinfobak1");

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2).HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid).HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.DirectDebit).HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DrExclude1).HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2).HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3).HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4).HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5).HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6).HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221).HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222).HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223).HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224).HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225).HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226).HasColumnName("drSR22_6");
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(20)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(20)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.OwnHome).HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance).HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.Uimpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimpd");
        //    entity.Property(e => e.UimpdIndex).HasColumnName("uimpdIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //});

        //modelBuilder.Entity<CommFollowUp>(entity =>
        //{
        //    entity.ToTable("CommFollowUp");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.FollowDate).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<CommPer>(entity =>
        //{
        //    entity.HasKey(e => e.ComId);

        //    entity.ToTable("CommPer");

        //    entity.Property(e => e.ComId).HasColumnName("comID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.NewPercent).HasColumnName("newPercent");
        //    entity.Property(e => e.RenewPercent).HasColumnName("renewPercent");
        //    entity.Property(e => e.Type).HasMaxLength(250);
        //});

        //modelBuilder.Entity<CommercialCoverage>(entity =>
        //{
        //    entity.HasKey(e => e.CommId);

        //    entity.ToTable("commercialCoverage");

        //    entity.Property(e => e.CommId).HasColumnName("commID");
        //    entity.Property(e => e.Alarm)
        //        .HasMaxLength(10)
        //        .HasColumnName("alarm");
        //    entity.Property(e => e.AnnRec)
        //        .HasColumnType("money")
        //        .HasColumnName("annRec");
        //    entity.Property(e => e.Bpp)
        //        .HasColumnType("money")
        //        .HasColumnName("bpp");
        //    entity.Property(e => e.Building)
        //        .HasColumnType("money")
        //        .HasColumnName("building");
        //    entity.Property(e => e.Businc)
        //        .HasColumnType("money")
        //        .HasColumnName("businc");
        //    entity.Property(e => e.Business)
        //        .HasMaxLength(100)
        //        .HasColumnName("business");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Const).HasMaxLength(10);
        //    entity.Property(e => e.CurIns)
        //        .HasMaxLength(200)
        //        .HasColumnName("curIns");
        //    entity.Property(e => e.Ded)
        //        .HasColumnType("money")
        //        .HasColumnName("ded");
        //    entity.Property(e => e.Eachocc)
        //        .HasColumnType("money")
        //        .HasColumnName("eachocc");
        //    entity.Property(e => e.Extraexp)
        //        .HasColumnType("money")
        //        .HasColumnName("extraexp");
        //    entity.Property(e => e.Fire)
        //        .HasColumnType("money")
        //        .HasColumnName("fire");
        //    entity.Property(e => e.Genagg)
        //        .HasColumnType("money")
        //        .HasColumnName("genagg");
        //    entity.Property(e => e.Gl)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("gl");
        //    entity.Property(e => e.Glass)
        //        .HasColumnType("money")
        //        .HasColumnName("glass");
        //    entity.Property(e => e.Loe)
        //        .HasColumnType("money")
        //        .HasColumnName("loe");
        //    entity.Property(e => e.Med)
        //        .HasColumnType("money")
        //        .HasColumnName("med");
        //    entity.Property(e => e.NumEmp)
        //        .HasMaxLength(200)
        //        .HasColumnName("numEmp");
        //    entity.Property(e => e.OwnLease)
        //        .HasMaxLength(200)
        //        .HasColumnName("ownLease");
        //    entity.Property(e => e.Payroll)
        //        .HasColumnType("money")
        //        .HasColumnName("payroll");
        //    entity.Property(e => e.Personal)
        //        .HasColumnType("money")
        //        .HasColumnName("personal");
        //    entity.Property(e => e.Proagg)
        //        .HasColumnType("money")
        //        .HasColumnName("proagg");
        //    entity.Property(e => e.Prop)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("prop");
        //    entity.Property(e => e.Pump)
        //        .HasColumnType("money")
        //        .HasColumnName("pump");
        //    entity.Property(e => e.Roof)
        //        .HasMaxLength(15)
        //        .HasColumnName("roof");
        //    entity.Property(e => e.Sign)
        //        .HasColumnType("money")
        //        .HasColumnName("sign");
        //    entity.Property(e => e.SpcLic)
        //        .HasMaxLength(200)
        //        .HasColumnName("spcLic");
        //    entity.Property(e => e.Sqft)
        //        .HasMaxLength(10)
        //        .HasColumnName("sqft");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(50)
        //        .HasColumnName("type");
        //    entity.Property(e => e.YrBuilt)
        //        .HasMaxLength(10)
        //        .HasColumnName("yrBuilt");
        //    entity.Property(e => e.YrsBuss)
        //        .HasMaxLength(200)
        //        .HasColumnName("yrsBuss");
        //});

        //modelBuilder.Entity<Commission>(entity =>
        //{
        //    entity.HasKey(e => e.ComId);

        //    entity.Property(e => e.ComId).HasColumnName("comID");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Commission1)
        //        .HasColumnType("money")
        //        .HasColumnName("commission");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Date)
        //        .HasColumnType("datetime")
        //        .HasColumnName("date");
        //    entity.Property(e => e.Deleted)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("deleted");
        //    entity.Property(e => e.DeletedBy).HasMaxLength(50);
        //    entity.Property(e => e.EndId).HasColumnName("endID");
        //    entity.Property(e => e.InitialCommission).HasColumnName("initialCommission");
        //    entity.Property(e => e.Notes).HasColumnType("ntext");
        //    entity.Property(e => e.Paid)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("paid");
        //    entity.Property(e => e.PdAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("pdAmount");
        //    entity.Property(e => e.PdCheckNum)
        //        .HasMaxLength(200)
        //        .HasColumnName("pdCheckNum");
        //    entity.Property(e => e.PdDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("pdDate");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.Rec)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("rec");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Transaction).HasMaxLength(200);
        //});

        //modelBuilder.Entity<CommissionReport>(entity =>
        //{
        //    entity.ToTable("commissionReport");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(50)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Commission)
        //        .HasColumnType("money")
        //        .HasColumnName("commission");
        //    entity.Property(e => e.EffectiveDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("effectiveDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.Premium)
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.Status)
        //        .HasMaxLength(50)
        //        .HasColumnName("status");
        //});

        //modelBuilder.Entity<CompanyInfo>(entity =>
        //{
        //    entity.HasKey(e => e.CompanyId);

        //    entity.ToTable("companyInfo");

        //    entity.HasIndex(e => e.CoName, "ix_CoName");

        //    entity.HasIndex(e => e.CompanyId, "ix_CompanyID_INCLUDE_coName_coWeb");

        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.AaCoId)
        //        .HasMaxLength(10)
        //        .HasColumnName("aaCoID");
        //    entity.Property(e => e.AbcompanyId)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("ABCompanyId");
        //    entity.Property(e => e.AgencyCode)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyCode");
        //    entity.Property(e => e.CoAddressCity)
        //        .HasColumnType("ntext")
        //        .HasColumnName("coAddressCity");
        //    entity.Property(e => e.CoAddressLine1)
        //        .HasMaxLength(50)
        //        .HasColumnName("coAddressLine1");
        //    entity.Property(e => e.CoAddressLine2)
        //        .HasMaxLength(50)
        //        .HasColumnName("coAddressLine2");
        //    entity.Property(e => e.CoAddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("coAddressState");
        //    entity.Property(e => e.CoAddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("coAddressZip");
        //    entity.Property(e => e.CoContact)
        //        .HasMaxLength(25)
        //        .HasColumnName("coContact");
        //    entity.Property(e => e.CoDirectDebit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("coDirectDebit");
        //    entity.Property(e => e.CoEmail1)
        //        .HasMaxLength(100)
        //        .HasColumnName("coEmail1");
        //    entity.Property(e => e.CoFax)
        //        .HasMaxLength(20)
        //        .HasColumnName("coFax");
        //    entity.Property(e => e.CoName)
        //        .HasMaxLength(50)
        //        .HasColumnName("coName");
        //    entity.Property(e => e.CoPayMethod).HasColumnName("coPayMethod");
        //    entity.Property(e => e.CoPhone1)
        //        .HasMaxLength(20)
        //        .HasColumnName("coPhone1");
        //    entity.Property(e => e.CoPhone2)
        //        .HasMaxLength(20)
        //        .HasColumnName("coPhone2");
        //    entity.Property(e => e.CoType)
        //        .HasMaxLength(50)
        //        .HasColumnName("coType");
        //    entity.Property(e => e.CoWeb)
        //        .HasMaxLength(100)
        //        .HasColumnName("coWeb");
        //    entity.Property(e => e.CommBase).HasColumnName("commBase");
        //    entity.Property(e => e.CommColl).HasColumnName("commColl");
        //    entity.Property(e => e.CommissionPercent).HasColumnName("commissionPercent");
        //    entity.Property(e => e.CompFeeOptions).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.CompanyNote)
        //        .HasMaxLength(100)
        //        .HasColumnName("companyNote");
        //    entity.Property(e => e.DateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Mga)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("MGA");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Web)
        //        .HasMaxLength(100)
        //        .HasColumnName("web");
        //});

        //modelBuilder.Entity<CompanyLog>(entity =>
        //{
        //    entity.HasKey(e => e.LogId);

        //    entity.ToTable("companyLog");

        //    entity.Property(e => e.LogId).HasColumnName("LogID");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.CompanyMemo).HasColumnType("ntext");
        //    entity.Property(e => e.CreateDate).HasColumnType("datetime");
        //    entity.Property(e => e.LastLogId).HasColumnName("LastLogID");
        //    entity.Property(e => e.ModifyDate).HasColumnType("datetime");
        //    entity.Property(e => e.NextLogId).HasColumnName("NextLogID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<Companyinfobak>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("companyinfobak");

        //    entity.Property(e => e.AaCoId)
        //        .HasMaxLength(10)
        //        .HasColumnName("aaCoID");
        //    entity.Property(e => e.AbcompanyId).HasColumnName("ABCompanyId");
        //    entity.Property(e => e.AgencyCode)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyCode");
        //    entity.Property(e => e.CoAddressCity)
        //        .HasColumnType("ntext")
        //        .HasColumnName("coAddressCity");
        //    entity.Property(e => e.CoAddressLine1)
        //        .HasMaxLength(50)
        //        .HasColumnName("coAddressLine1");
        //    entity.Property(e => e.CoAddressLine2)
        //        .HasMaxLength(50)
        //        .HasColumnName("coAddressLine2");
        //    entity.Property(e => e.CoAddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("coAddressState");
        //    entity.Property(e => e.CoAddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("coAddressZip");
        //    entity.Property(e => e.CoContact)
        //        .HasMaxLength(25)
        //        .HasColumnName("coContact");
        //    entity.Property(e => e.CoDirectDebit).HasColumnName("coDirectDebit");
        //    entity.Property(e => e.CoEmail1)
        //        .HasMaxLength(100)
        //        .HasColumnName("coEmail1");
        //    entity.Property(e => e.CoFax)
        //        .HasMaxLength(20)
        //        .HasColumnName("coFax");
        //    entity.Property(e => e.CoName)
        //        .HasMaxLength(50)
        //        .HasColumnName("coName");
        //    entity.Property(e => e.CoPayMethod).HasColumnName("coPayMethod");
        //    entity.Property(e => e.CoPhone1)
        //        .HasMaxLength(20)
        //        .HasColumnName("coPhone1");
        //    entity.Property(e => e.CoPhone2)
        //        .HasMaxLength(20)
        //        .HasColumnName("coPhone2");
        //    entity.Property(e => e.CoType)
        //        .HasMaxLength(50)
        //        .HasColumnName("coType");
        //    entity.Property(e => e.CoWeb)
        //        .HasMaxLength(100)
        //        .HasColumnName("coWeb");
        //    entity.Property(e => e.CommBase).HasColumnName("commBase");
        //    entity.Property(e => e.CommColl).HasColumnName("commColl");
        //    entity.Property(e => e.CommissionPercent).HasColumnName("commissionPercent");
        //    entity.Property(e => e.CompanyId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("companyID");
        //    entity.Property(e => e.CompanyNote)
        //        .HasMaxLength(100)
        //        .HasColumnName("companyNote");
        //    entity.Property(e => e.DateCreated).HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified).HasColumnType("datetime");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Mga).HasColumnName("MGA");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Web)
        //        .HasMaxLength(100)
        //        .HasColumnName("web");
        //});

        //modelBuilder.Entity<Companyinfoimport>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("companyinfoimport");

        //    entity.Property(e => e.AaCoId)
        //        .HasMaxLength(10)
        //        .HasColumnName("aaCoID");
        //    entity.Property(e => e.AbcompanyId).HasColumnName("ABCompanyId");
        //    entity.Property(e => e.AgencyCode)
        //        .HasMaxLength(50)
        //        .HasColumnName("agencyCode");
        //    entity.Property(e => e.CoAddressCity)
        //        .HasColumnType("ntext")
        //        .HasColumnName("coAddressCity");
        //    entity.Property(e => e.CoAddressLine1)
        //        .HasMaxLength(50)
        //        .HasColumnName("coAddressLine1");
        //    entity.Property(e => e.CoAddressLine2)
        //        .HasMaxLength(50)
        //        .HasColumnName("coAddressLine2");
        //    entity.Property(e => e.CoAddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("coAddressState");
        //    entity.Property(e => e.CoAddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("coAddressZip");
        //    entity.Property(e => e.CoContact)
        //        .HasMaxLength(25)
        //        .HasColumnName("coContact");
        //    entity.Property(e => e.CoDirectDebit).HasColumnName("coDirectDebit");
        //    entity.Property(e => e.CoEmail1)
        //        .HasMaxLength(100)
        //        .HasColumnName("coEmail1");
        //    entity.Property(e => e.CoFax)
        //        .HasMaxLength(20)
        //        .HasColumnName("coFax");
        //    entity.Property(e => e.CoName)
        //        .HasMaxLength(50)
        //        .HasColumnName("coName");
        //    entity.Property(e => e.CoPayMethod).HasColumnName("coPayMethod");
        //    entity.Property(e => e.CoPhone1)
        //        .HasMaxLength(20)
        //        .HasColumnName("coPhone1");
        //    entity.Property(e => e.CoPhone2)
        //        .HasMaxLength(20)
        //        .HasColumnName("coPhone2");
        //    entity.Property(e => e.CoType)
        //        .HasMaxLength(50)
        //        .HasColumnName("coType");
        //    entity.Property(e => e.CoWeb)
        //        .HasMaxLength(100)
        //        .HasColumnName("coWeb");
        //    entity.Property(e => e.CommBase).HasColumnName("commBase");
        //    entity.Property(e => e.CommColl).HasColumnName("commColl");
        //    entity.Property(e => e.CommissionPercent).HasColumnName("commissionPercent");
        //    entity.Property(e => e.CompanyId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("companyID");
        //    entity.Property(e => e.CompanyNote)
        //        .HasMaxLength(100)
        //        .HasColumnName("companyNote");
        //    entity.Property(e => e.DateCreated).HasColumnType("datetime");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified).HasColumnType("datetime");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Mga).HasColumnName("MGA");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Web)
        //        .HasMaxLength(100)
        //        .HasColumnName("web");
        //});

        //modelBuilder.Entity<Contact>(entity =>
        //{
        //    entity.ToTable("contacts");

        //    entity.Property(e => e.ContactId).HasColumnName("contactID");
        //    entity.Property(e => e.CCategory)
        //        .HasMaxLength(100)
        //        .HasColumnName("cCategory");
        //    entity.Property(e => e.Category).HasMaxLength(50);
        //    entity.Property(e => e.ContactAdd)
        //        .HasMaxLength(50)
        //        .HasColumnName("contactAdd");
        //    entity.Property(e => e.ContactCell)
        //        .HasMaxLength(20)
        //        .HasColumnName("contactCell");
        //    entity.Property(e => e.ContactCity)
        //        .HasMaxLength(25)
        //        .HasColumnName("contactCity");
        //    entity.Property(e => e.ContactEmail1)
        //        .HasMaxLength(100)
        //        .HasColumnName("contactEmail1");
        //    entity.Property(e => e.ContactEmail2)
        //        .HasMaxLength(100)
        //        .HasColumnName("contactEmail2");
        //    entity.Property(e => e.ContactName)
        //        .HasMaxLength(50)
        //        .HasColumnName("contactName");
        //    entity.Property(e => e.ContactNotes)
        //        .HasColumnType("ntext")
        //        .HasColumnName("contactNotes");
        //    entity.Property(e => e.ContactPhone1)
        //        .HasMaxLength(20)
        //        .HasColumnName("contactPhone1");
        //    entity.Property(e => e.ContactPhone2)
        //        .HasMaxLength(20)
        //        .HasColumnName("contactPhone2");
        //    entity.Property(e => e.ContactState)
        //        .HasMaxLength(10)
        //        .HasColumnName("contactState");
        //    entity.Property(e => e.ContactWeb)
        //        .HasMaxLength(100)
        //        .HasColumnName("contactWeb");
        //    entity.Property(e => e.ContactWork)
        //        .HasMaxLength(20)
        //        .HasColumnName("contactWork");
        //    entity.Property(e => e.ContactZip)
        //        .HasMaxLength(15)
        //        .HasColumnName("contactZip");
        //});

        //modelBuilder.Entity<ContactCategory>(entity =>
        //{
        //    entity.HasKey(e => e.CatId);

        //    entity.ToTable("contactCategory");

        //    entity.Property(e => e.CatId).HasColumnName("catID");
        //    entity.Property(e => e.ContactCategory1)
        //        .HasMaxLength(50)
        //        .HasColumnName("contactCategory");
        //});

        //modelBuilder.Entity<Coverage>(entity =>
        //{
        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Cov)
        //        .HasMaxLength(255)
        //        .HasColumnName("cov");
        //});

        //modelBuilder.Entity<DealerInfo>(entity =>
        //{
        //    entity.ToTable("dealerInfo");

        //    entity.Property(e => e.Id).HasColumnName("ID");
        //    entity.Property(e => e.Dealer)
        //        .HasMaxLength(200)
        //        .HasColumnName("dealer");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<DownPayType>(entity =>
        //{
        //    entity.ToTable("DownPayType");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(255)
        //        .HasColumnName("type");
        //});

        //modelBuilder.Entity<DownloadSummary>(entity =>
        //{
        //    entity.HasKey(e => e.Supplementalid);

        //    entity.Property(e => e.Supplementalid)
        //        .ValueGeneratedNever()
        //        .HasColumnName("supplementalid");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.Clientid).HasColumnName("clientid");
        //    entity.Property(e => e.DownloadSummary1)
        //        .IsUnicode(false)
        //        .HasColumnName("DownloadSummary");
        //    entity.Property(e => e.MachineName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("machineName");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //});

        //modelBuilder.Entity<DuplicateClientRemovalAgencyInfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("duplicateClientRemoval_AgencyInfo");

        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AssignedAgencyId).HasColumnName("AssignedAgencyID");
        //    entity.Property(e => e.AssignedAgentId).HasColumnName("AssignedAgentID");
        //    entity.Property(e => e.AssignedClientId).HasColumnName("AssignedClientID");
        //    entity.Property(e => e.DuplicateGroupId).HasColumnName("DuplicateGroupID");
        //});

        //modelBuilder.Entity<DuplicateClientRemovalKey>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("duplicateClientRemoval_Key");

        //    entity.Property(e => e.Addresscity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addresscity");
        //    entity.Property(e => e.Addressstate)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressstate");
        //    entity.Property(e => e.Addressstreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressstreet");
        //    entity.Property(e => e.Addresszip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addresszip");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.Count).HasColumnName("count");
        //    entity.Property(e => e.Homephone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homephone");
        //    entity.Property(e => e.Policyeffdate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyeffdate");
        //    entity.Property(e => e.Policynum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policynum");
        //    entity.Property(e => e.RecordId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("RecordID");
        //    entity.Property(e => e.Workphone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workphone");
        //});

        //modelBuilder.Entity<DuplicateClientRemovalLog>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("duplicateClientRemovalLog");

        //    entity.Property(e => e.Addresscity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addresscity");
        //    entity.Property(e => e.Addressstate)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressstate");
        //    entity.Property(e => e.Addressstreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressstreet");
        //    entity.Property(e => e.Addresszip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addresszip");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(40)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.AssignedClientId).HasColumnName("AssignedClientID");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.DuplicateGroupId).HasColumnName("DuplicateGroupID");
        //    entity.Property(e => e.Homephone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homephone");
        //    entity.Property(e => e.LastModified).HasColumnType("datetime");
        //    entity.Property(e => e.Policyeffdate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyeffdate");
        //    entity.Property(e => e.Policynum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policynum");
        //    entity.Property(e => e.RecordId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("RecordID");
        //    entity.Property(e => e.Workphone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workphone");
        //});

        //modelBuilder.Entity<EmailAccount>(entity =>
        //{
        //    entity.ToTable("emailAccounts", tb => tb.HasTrigger("trg_emailAccounts_AFTER_INSERT_OR_Update"));

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.AccountName)
        //        .HasMaxLength(100)
        //        .HasColumnName("accountName");
        //    entity.Property(e => e.Del)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("del");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.Notes)
        //        .HasMaxLength(250)
        //        .HasColumnName("notes");
        //    entity.Property(e => e.Password)
        //        .HasMaxLength(100)
        //        .HasColumnName("password");
        //    entity.Property(e => e.PasswordEnc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("Password_enc");
        //    entity.Property(e => e.Pop)
        //        .HasMaxLength(100)
        //        .HasColumnName("pop");
        //    entity.Property(e => e.PopEncryptType)
        //        .HasMaxLength(10)
        //        .HasColumnName("popEncryptType");
        //    entity.Property(e => e.PopPort).HasMaxLength(10);
        //    entity.Property(e => e.PopUseEncrypt).HasColumnName("popUseEncrypt");
        //    entity.Property(e => e.Smtp)
        //        .HasMaxLength(100)
        //        .HasColumnName("smtp");
        //    entity.Property(e => e.SmtpAuthPassword)
        //        .HasMaxLength(50)
        //        .HasColumnName("smtpAuthPassword");
        //    entity.Property(e => e.SmtpAuthPasswordEnc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("smtpAuthPassword_enc");
        //    entity.Property(e => e.SmtpAuthUserId)
        //        .HasMaxLength(50)
        //        .HasColumnName("smtpAuthUserID");
        //    entity.Property(e => e.SmtpEncryptType)
        //        .HasMaxLength(10)
        //        .HasColumnName("smtpEncryptType");
        //    entity.Property(e => e.SmtpPort).HasMaxLength(10);
        //    entity.Property(e => e.SmtpUseEncrypt).HasColumnName("smtpUseEncrypt");
        //    entity.Property(e => e.SmtpUsesAuth).HasColumnName("smtpUsesAuth");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.UseSmtpAuthLogonUsing).HasColumnName("useSmtpAuthLogonUsing");
        //    entity.Property(e => e.UseSmtpAuthSameAsPop).HasColumnName("useSmtpAuthSameAsPop");
        //    entity.Property(e => e.UserId)
        //        .HasMaxLength(100)
        //        .HasColumnName("userID");
        //});

        //modelBuilder.Entity<Endorsement>(entity =>
        //{
        //    entity.HasKey(e => e.EndId);

        //    entity.ToTable("Endorsement");

        //    entity.HasIndex(e => e.EndDate, "ix_Endorsement_EndDate_INCLUDE_ClientID");

        //    entity.Property(e => e.EndId).HasColumnName("endID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.EndDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("endDate");
        //    entity.Property(e => e.EndType)
        //        .HasMaxLength(100)
        //        .HasColumnName("endType");
        //    entity.Property(e => e.First)
        //        .HasMaxLength(25)
        //        .HasColumnName("first");
        //    entity.Property(e => e.Last)
        //        .HasMaxLength(25)
        //        .HasColumnName("last");
        //    entity.Property(e => e.Make)
        //        .HasMaxLength(50)
        //        .HasColumnName("make");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Model)
        //        .HasMaxLength(100)
        //        .HasColumnName("model");
        //    entity.Property(e => e.PremiumChange)
        //        .HasColumnType("money")
        //        .HasColumnName("premiumChange");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Vin)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(10)
        //        .HasColumnName("year");
        //});

        //modelBuilder.Entity<Endorsementbak>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("endorsementbak");

        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.EndDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("endDate");
        //    entity.Property(e => e.EndId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("endID");
        //    entity.Property(e => e.EndType)
        //        .HasMaxLength(100)
        //        .HasColumnName("endType");
        //    entity.Property(e => e.First)
        //        .HasMaxLength(25)
        //        .HasColumnName("first");
        //    entity.Property(e => e.Last)
        //        .HasMaxLength(25)
        //        .HasColumnName("last");
        //    entity.Property(e => e.Make)
        //        .HasMaxLength(50)
        //        .HasColumnName("make");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Model)
        //        .HasMaxLength(100)
        //        .HasColumnName("model");
        //    entity.Property(e => e.PremiumChange)
        //        .HasColumnType("money")
        //        .HasColumnName("premiumChange");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Vin)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(10)
        //        .HasColumnName("year");
        //});

        //modelBuilder.Entity<Endorsementbak1>(entity =>
        //{
        //    entity.HasKey(e => e.EndId);

        //    entity.ToTable("Endorsementbak1");

        //    entity.Property(e => e.EndId).HasColumnName("endID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.EndDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("endDate");
        //    entity.Property(e => e.EndType)
        //        .HasMaxLength(100)
        //        .HasColumnName("endType");
        //    entity.Property(e => e.First)
        //        .HasMaxLength(25)
        //        .HasColumnName("first");
        //    entity.Property(e => e.Last)
        //        .HasMaxLength(25)
        //        .HasColumnName("last");
        //    entity.Property(e => e.Make)
        //        .HasMaxLength(50)
        //        .HasColumnName("make");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Model)
        //        .HasMaxLength(100)
        //        .HasColumnName("model");
        //    entity.Property(e => e.PremiumChange)
        //        .HasColumnType("money")
        //        .HasColumnName("premiumChange");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Vin)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(10)
        //        .HasColumnName("year");
        //});

        //modelBuilder.Entity<Favorite>(entity =>
        //{
        //    entity.HasKey(e => e.FavId);

        //    entity.Property(e => e.FavId).HasColumnName("favID");
        //    entity.Property(e => e.DtCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("dtCreated");
        //    entity.Property(e => e.FileName).HasMaxLength(255);
        //    entity.Property(e => e.Form).HasMaxLength(255);
        //    entity.Property(e => e.FormDesc).HasMaxLength(255);
        //});

        //modelBuilder.Entity<FeeType>(entity =>
        //{
        //    entity.HasKey(e => e.FeeId);

        //    entity.Property(e => e.FeeId).HasColumnName("feeID");
        //    entity.Property(e => e.Def)
        //        .HasColumnType("money")
        //        .HasColumnName("def");
        //    entity.Property(e => e.Fee).HasMaxLength(150);
        //    entity.Property(e => e.Max)
        //        .HasColumnType("money")
        //        .HasColumnName("max");
        //    entity.Property(e => e.Min)
        //        .HasColumnType("money")
        //        .HasColumnName("min");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<FeeValue>(entity =>
        //{
        //    entity.HasIndex(e => e.PaymentId, "ix_PaymentID");

        //    entity.Property(e => e.FeeValueId).HasColumnName("feeValueID");
        //    entity.Property(e => e.Amount).HasColumnType("money");
        //    entity.Property(e => e.Fee).HasMaxLength(150);
        //    entity.Property(e => e.FeeId).HasColumnName("feeID");
        //    entity.Property(e => e.PaymentId).HasColumnName("paymentID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<FeeValuesPolicy>(entity =>
        //{
        //    entity.HasKey(e => e.FeeValueId);

        //    entity.ToTable("FeeValuesPolicy");

        //    entity.Property(e => e.FeeValueId).HasColumnName("feeValueID");
        //    entity.Property(e => e.Amount).HasColumnType("money");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Fee).HasMaxLength(150);
        //    entity.Property(e => e.FeeId).HasColumnName("feeID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<FinCompany>(entity =>
        //{
        //    entity.HasKey(e => e.FinId);

        //    entity.ToTable("finCompany");

        //    entity.Property(e => e.FinId).HasColumnName("finID");
        //    entity.Property(e => e.Address1)
        //        .HasMaxLength(200)
        //        .HasColumnName("address1");
        //    entity.Property(e => e.Address2)
        //        .HasMaxLength(200)
        //        .HasColumnName("address2");
        //    entity.Property(e => e.City)
        //        .HasMaxLength(200)
        //        .HasColumnName("city");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.State)
        //        .HasMaxLength(2)
        //        .HasColumnName("state");
        //    entity.Property(e => e.Zip)
        //        .HasMaxLength(10)
        //        .HasColumnName("zip");
        //});

        //modelBuilder.Entity<Form>(entity =>
        //{
        //    entity.Property(e => e.FormId).HasColumnName("formID");
        //    entity.Property(e => e.BatchId).HasColumnName("batchID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Del)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("del");
        //    entity.Property(e => e.Desc).HasMaxLength(255);
        //    entity.Property(e => e.Download)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("download");
        //    entity.Property(e => e.EDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("eDate");
        //    entity.Property(e => e.EIn)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("eIn");
        //    entity.Property(e => e.ESent)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("eSent");
        //    entity.Property(e => e.Email)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("email");
        //    entity.Property(e => e.FileName).HasMaxLength(255);
        //    entity.Property(e => e.FormName).HasMaxLength(255);
        //    entity.Property(e => e.Letter)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("letter");
        //    entity.Property(e => e.Uidl)
        //        .HasMaxLength(100)
        //        .HasColumnName("UIDL");
        //});

        //modelBuilder.Entity<HomeCoverage>(entity =>
        //{
        //    entity.HasKey(e => e.HomeId);

        //    entity.ToTable("homeCoverage");

        //    entity.Property(e => e.HomeId).HasColumnName("homeID");
        //    entity.Property(e => e.AddLiv).HasColumnType("money");
        //    entity.Property(e => e.Alarm)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("alarm");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Const)
        //        .HasMaxLength(50)
        //        .HasColumnName("const");
        //    entity.Property(e => e.Ded)
        //        .HasMaxLength(100)
        //        .HasColumnName("ded");
        //    entity.Property(e => e.Dwelling)
        //        .HasColumnType("money")
        //        .HasColumnName("dwelling");
        //    entity.Property(e => e.Fire)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("fire");
        //    entity.Property(e => e.HoForm).HasMaxLength(50);
        //    entity.Property(e => e.Liab)
        //        .HasColumnType("money")
        //        .HasColumnName("liab");
        //    entity.Property(e => e.Loss)
        //        .HasColumnType("money")
        //        .HasColumnName("loss");
        //    entity.Property(e => e.Med)
        //        .HasColumnType("money")
        //        .HasColumnName("med");
        //    entity.Property(e => e.Otherstruc)
        //        .HasColumnType("money")
        //        .HasColumnName("otherstruc");
        //    entity.Property(e => e.Prop)
        //        .HasColumnType("money")
        //        .HasColumnName("prop");
        //    entity.Property(e => e.Replace)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("replace");
        //    entity.Property(e => e.Roof)
        //        .HasMaxLength(50)
        //        .HasColumnName("roof");
        //    entity.Property(e => e.Room)
        //        .HasMaxLength(50)
        //        .HasColumnName("room");
        //    entity.Property(e => e.Sqft)
        //        .HasMaxLength(50)
        //        .HasColumnName("sqft");
        //    entity.Property(e => e.Swim)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("swim");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Usage).HasColumnName("usage");
        //    entity.Property(e => e.Yrbuilt)
        //        .HasMaxLength(50)
        //        .HasColumnName("yrbuilt");
        //});

        //modelBuilder.Entity<HomePolicySearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("HomePolicySearch");

        //    entity.Property(e => e.AdditionalStructureAmount).HasColumnType("money");
        //    entity.Property(e => e.AgeOfRoof).HasMaxLength(50);
        //    entity.Property(e => e.AgentCommission).HasColumnType("money");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(101)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.AreaSqareFootage).HasMaxLength(50);
        //    entity.Property(e => e.Companyname)
        //        .HasMaxLength(50)
        //        .HasColumnName("companyname");
        //    entity.Property(e => e.ContentsAmount).HasColumnType("money");
        //    entity.Property(e => e.DateCancelled).HasColumnType("smalldatetime");
        //    entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");
        //    entity.Property(e => e.Deductible).HasMaxLength(100);
        //    entity.Property(e => e.DwellingAmount).HasColumnType("money");
        //    entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.Form).HasMaxLength(50);
        //    entity.Property(e => e.InitialPremium).HasColumnType("money");
        //    entity.Property(e => e.Lastpaymentamount)
        //        .HasColumnType("money")
        //        .HasColumnName("lastpaymentamount");
        //    entity.Property(e => e.Lastpaymentdate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("lastpaymentdate");
        //    entity.Property(e => e.LiabilityLimit).HasColumnType("money");
        //    entity.Property(e => e.LossOfUseAmount).HasColumnType("money");
        //    entity.Property(e => e.MedicalPayLimit).HasColumnType("money");
        //    entity.Property(e => e.PolicyFee).HasColumnType("money");
        //    entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
        //    entity.Property(e => e.PolicyType).HasMaxLength(20);
        //    entity.Property(e => e.Policynumber)
        //        .HasMaxLength(256)
        //        .HasColumnName("policynumber");
        //    entity.Property(e => e.QuoteStatus).HasMaxLength(20);
        //    entity.Property(e => e.RoomLayout).HasMaxLength(50);
        //    entity.Property(e => e.Term).HasMaxLength(20);
        //    entity.Property(e => e.YearBuilt).HasMaxLength(50);
        //});

        //modelBuilder.Entity<Image>(entity =>
        //{
        //    entity.Property(e => e.ImageId).HasColumnName("imageID");
        //    entity.Property(e => e.BatchId).HasColumnName("batchID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(255)
        //        .HasColumnName("description");
        //    entity.Property(e => e.Img)
        //        .HasMaxLength(255)
        //        .HasColumnName("img");
        //    entity.Property(e => e.ScanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("scanDate");
        //});

        //modelBuilder.Entity<IrvingPolicy>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Agency)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENCY");
        //    entity.Property(e => e.Agent)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENT");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Fname)
        //        .HasMaxLength(28)
        //        .IsUnicode(false)
        //        .HasColumnName("FNAME");
        //    entity.Property(e => e.Lname)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LNAME");
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.QfPid).HasColumnName("QF_PID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Letter>(entity =>
        //{
        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.BatchId).HasColumnName("batchID");
        //    entity.Property(e => e.FileName)
        //        .HasMaxLength(100)
        //        .HasColumnName("fileName");
        //    entity.Property(e => e.LtrName)
        //        .HasMaxLength(255)
        //        .HasColumnName("ltrName");
        //});

        //modelBuilder.Entity<MailLog>(entity =>
        //{
        //    entity.HasKey(e => e.MailId);

        //    entity.ToTable("MailLog");

        //    entity.Property(e => e.MailId).HasColumnName("mailID");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.Amount).HasColumnName("amount");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(100)
        //        .HasColumnName("checkNum");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.MailType)
        //        .HasMaxLength(100)
        //        .HasColumnName("mailType");
        //    entity.Property(e => e.Memo)
        //        .HasMaxLength(250)
        //        .HasColumnName("memo");
        //    entity.Property(e => e.RecBy)
        //        .HasMaxLength(100)
        //        .HasColumnName("recBy");
        //    entity.Property(e => e.RecDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("recDate");
        //    entity.Property(e => e.SentDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sentDate");
        //    entity.Property(e => e.SentFromLoc)
        //        .HasMaxLength(100)
        //        .HasColumnName("sentFromLoc");
        //    entity.Property(e => e.SentTo)
        //        .HasMaxLength(100)
        //        .HasColumnName("sentTo");
        //});

        //modelBuilder.Entity<MakeDeposit>(entity =>
        //{
        //    entity.HasKey(e => e.DepId);

        //    entity.ToTable("makeDeposit");

        //    entity.Property(e => e.DepId).HasColumnName("depID");
        //    entity.Property(e => e.DepAccount)
        //        .HasMaxLength(100)
        //        .HasColumnName("depAccount");
        //    entity.Property(e => e.DepAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("depAmount");
        //    entity.Property(e => e.DepDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("depDate");
        //    entity.Property(e => e.DepMemo)
        //        .HasMaxLength(255)
        //        .HasColumnName("depMemo");
        //    entity.Property(e => e.DepName)
        //        .HasMaxLength(100)
        //        .HasColumnName("depName");
        //    entity.Property(e => e.RecCheck)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("recCheck");
        //    entity.Property(e => e.RecConfirm)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("recConfirm");
        //});

        //modelBuilder.Entity<MembershipType>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK_membershipType");

        //    entity.ToTable("membershipTypes");

        //    entity.Property(e => e.Id).HasColumnName("ID");
        //    entity.Property(e => e.MembershipType1)
        //        .HasMaxLength(200)
        //        .HasColumnName("membershipType");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<MesquitePolicy>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Agency)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENCY");
        //    entity.Property(e => e.Agent)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENT");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Fname)
        //        .HasMaxLength(28)
        //        .IsUnicode(false)
        //        .HasColumnName("FNAME");
        //    entity.Property(e => e.Lname)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LNAME");
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.QfPid).HasColumnName("QF_PID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Message>(entity =>
        //{
        //    entity.ToTable("Message");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Msg)
        //        .HasColumnType("ntext")
        //        .HasColumnName("msg");
        //    entity.Property(e => e.MsgRead).HasColumnName("msgRead");
        //    entity.Property(e => e.MsgTime)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("msgTime");
        //    entity.Property(e => e.SentBy).HasColumnName("sentBy");
        //    entity.Property(e => e.SentByName)
        //        .HasMaxLength(100)
        //        .HasColumnName("sentByName");
        //    entity.Property(e => e.SentTo).HasColumnName("sentTo");
        //});

        //modelBuilder.Entity<MigrationHistory>(entity =>
        //{
        //    entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

        //    entity.ToTable("__MigrationHistory");

        //    entity.Property(e => e.MigrationId).HasMaxLength(150);
        //    entity.Property(e => e.ContextKey).HasMaxLength(300);
        //    entity.Property(e => e.ProductVersion).HasMaxLength(32);
        //});

        //modelBuilder.Entity<MobileCoverage>(entity =>
        //{
        //    entity.HasKey(e => e.MobileId);

        //    entity.ToTable("MobileCoverage");

        //    entity.Property(e => e.MobileId).HasColumnName("mobileID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Contents).HasMaxLength(50);
        //    entity.Property(e => e.Ded).HasMaxLength(50);
        //    entity.Property(e => e.FirePlace).HasMaxLength(50);
        //    entity.Property(e => e.Flood).HasMaxLength(50);
        //    entity.Property(e => e.InsideCity)
        //        .HasDefaultValueSql("((1))")
        //        .HasColumnName("insideCity");
        //    entity.Property(e => e.Length).HasMaxLength(200);
        //    entity.Property(e => e.Liability).HasMaxLength(50);
        //    entity.Property(e => e.Make).HasMaxLength(200);
        //    entity.Property(e => e.Model).HasMaxLength(200);
        //    entity.Property(e => e.Park).HasMaxLength(200);
        //    entity.Property(e => e.Replace).HasMaxLength(50);
        //    entity.Property(e => e.Siding).HasMaxLength(200);
        //    entity.Property(e => e.Skirted).HasMaxLength(50);
        //    entity.Property(e => e.Struct).HasMaxLength(50);
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Theft).HasMaxLength(50);
        //    entity.Property(e => e.Tied).HasMaxLength(50);
        //    entity.Property(e => e.Value).HasMaxLength(50);
        //    entity.Property(e => e.Year).HasMaxLength(50);
        //});

        //modelBuilder.Entity<MonthlyPayReport>(entity =>
        //{
        //    entity.ToTable("MonthlyPayReport");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.DueDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dueDate");
        //    entity.Property(e => e.First)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("first");
        //    entity.Property(e => e.Memo)
        //        .HasMaxLength(250)
        //        .HasColumnName("memo");
        //    entity.Property(e => e.Paid1).HasColumnName("paid1");
        //    entity.Property(e => e.Paid10).HasColumnName("paid10");
        //    entity.Property(e => e.Paid11).HasColumnName("paid11");
        //    entity.Property(e => e.Paid12).HasColumnName("paid12");
        //    entity.Property(e => e.Paid2).HasColumnName("paid2");
        //    entity.Property(e => e.Paid3).HasColumnName("paid3");
        //    entity.Property(e => e.Paid4).HasColumnName("paid4");
        //    entity.Property(e => e.Paid5).HasColumnName("paid5");
        //    entity.Property(e => e.Paid6).HasColumnName("paid6");
        //    entity.Property(e => e.Paid7).HasColumnName("paid7");
        //    entity.Property(e => e.Paid8).HasColumnName("paid8");
        //    entity.Property(e => e.Paid9).HasColumnName("paid9");
        //    entity.Property(e => e.PdMemo1)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo1");
        //    entity.Property(e => e.PdMemo10)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo10");
        //    entity.Property(e => e.PdMemo11)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo11");
        //    entity.Property(e => e.PdMemo12)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo12");
        //    entity.Property(e => e.PdMemo2)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo2");
        //    entity.Property(e => e.PdMemo3)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo3");
        //    entity.Property(e => e.PdMemo4)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo4");
        //    entity.Property(e => e.PdMemo5)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo5");
        //    entity.Property(e => e.PdMemo6)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo6");
        //    entity.Property(e => e.PdMemo7)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo7");
        //    entity.Property(e => e.PdMemo8)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo8");
        //    entity.Property(e => e.PdMemo9)
        //        .HasMaxLength(250)
        //        .HasColumnName("pdMemo9");
        //    entity.Property(e => e.PdType1).HasColumnName("pdType1");
        //    entity.Property(e => e.PdType10).HasColumnName("pdType10");
        //    entity.Property(e => e.PdType11).HasColumnName("pdType11");
        //    entity.Property(e => e.PdType12).HasColumnName("pdType12");
        //    entity.Property(e => e.PdType2).HasColumnName("pdType2");
        //    entity.Property(e => e.PdType3).HasColumnName("pdType3");
        //    entity.Property(e => e.PdType4).HasColumnName("pdType4");
        //    entity.Property(e => e.PdType5).HasColumnName("pdType5");
        //    entity.Property(e => e.PdType6).HasColumnName("pdType6");
        //    entity.Property(e => e.PdType7).HasColumnName("pdType7");
        //    entity.Property(e => e.PdType8).HasColumnName("pdType8");
        //    entity.Property(e => e.PdType9).HasColumnName("pdType9");
        //    entity.Property(e => e.RefreshDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("refreshDate");
        //});

        //modelBuilder.Entity<MotorcyclePolicySearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("MotorcyclePolicySearch");

        //    entity.Property(e => e.Address1).HasMaxLength(60);
        //    entity.Property(e => e.AgentCommission).HasColumnType("money");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(101)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.BodyType1).HasMaxLength(20);
        //    entity.Property(e => e.BodyType2).HasMaxLength(20);
        //    entity.Property(e => e.BodyType3).HasMaxLength(20);
        //    entity.Property(e => e.BodyType4).HasMaxLength(20);
        //    entity.Property(e => e.BodyType5).HasMaxLength(20);
        //    entity.Property(e => e.BodyType6).HasMaxLength(20);
        //    entity.Property(e => e.BusinessName).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone).HasMaxLength(25);
        //    entity.Property(e => e.City).HasMaxLength(50);
        //    entity.Property(e => e.CollDeductible1).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible2).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible3).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible4).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible5).HasMaxLength(10);
        //    entity.Property(e => e.CollDeductible6).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible1).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible2).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible3).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible4).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible5).HasMaxLength(10);
        //    entity.Property(e => e.CompDeductible6).HasMaxLength(10);
        //    entity.Property(e => e.Companyname)
        //        .HasMaxLength(50)
        //        .HasColumnName("companyname");
        //    entity.Property(e => e.DateCancelled).HasColumnType("smalldatetime");
        //    entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");
        //    entity.Property(e => e.Dob1)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB1");
        //    entity.Property(e => e.Dob2)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB2");
        //    entity.Property(e => e.Dob3)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB3");
        //    entity.Property(e => e.Dob4)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB4");
        //    entity.Property(e => e.Dob5)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB5");
        //    entity.Property(e => e.Dob6)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DOB6");
        //    entity.Property(e => e.DriverLicenseNumber1)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber2)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber3)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber4)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber5)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DriverLicenseNumber6)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //    entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.EmailAddress).HasMaxLength(100);
        //    entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.FaxNumber).HasMaxLength(25);
        //    entity.Property(e => e.FirstName1).HasMaxLength(50);
        //    entity.Property(e => e.FirstName2).HasMaxLength(50);
        //    entity.Property(e => e.FirstName3).HasMaxLength(50);
        //    entity.Property(e => e.FirstName4).HasMaxLength(50);
        //    entity.Property(e => e.FirstName5).HasMaxLength(50);
        //    entity.Property(e => e.FirstName6).HasMaxLength(50);
        //    entity.Property(e => e.InitialPremium).HasColumnType("money");
        //    entity.Property(e => e.LastName1).HasMaxLength(50);
        //    entity.Property(e => e.LastName2).HasMaxLength(50);
        //    entity.Property(e => e.LastName3).HasMaxLength(50);
        //    entity.Property(e => e.LastName4).HasMaxLength(50);
        //    entity.Property(e => e.LastName5).HasMaxLength(50);
        //    entity.Property(e => e.LastName6).HasMaxLength(50);
        //    entity.Property(e => e.Lastpaymentamount)
        //        .HasColumnType("money")
        //        .HasColumnName("lastpaymentamount");
        //    entity.Property(e => e.Lastpaymentdate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("lastpaymentdate");
        //    entity.Property(e => e.LiabBilimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("LiabBILimits");
        //    entity.Property(e => e.LiabPdlimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("LiabPDLimits");
        //    entity.Property(e => e.LicensePeriod1).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod2).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod3).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod4).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod5).HasMaxLength(10);
        //    entity.Property(e => e.LicensePeriod6).HasMaxLength(10);
        //    entity.Property(e => e.MailingAddress1).HasMaxLength(250);
        //    entity.Property(e => e.MailingCity).HasMaxLength(50);
        //    entity.Property(e => e.MailingState).HasMaxLength(25);
        //    entity.Property(e => e.MailingZipCode).HasMaxLength(10);
        //    entity.Property(e => e.Make1).HasMaxLength(20);
        //    entity.Property(e => e.Make2).HasMaxLength(20);
        //    entity.Property(e => e.Make3).HasMaxLength(20);
        //    entity.Property(e => e.Make4).HasMaxLength(20);
        //    entity.Property(e => e.Make5).HasMaxLength(20);
        //    entity.Property(e => e.Make6).HasMaxLength(20);
        //    entity.Property(e => e.Marital1).HasMaxLength(10);
        //    entity.Property(e => e.Marital2).HasMaxLength(10);
        //    entity.Property(e => e.Marital3).HasMaxLength(10);
        //    entity.Property(e => e.Marital4).HasMaxLength(10);
        //    entity.Property(e => e.Marital5).HasMaxLength(10);
        //    entity.Property(e => e.Marital6).HasMaxLength(10);
        //    entity.Property(e => e.MedPayLimit).HasMaxLength(10);
        //    entity.Property(e => e.Model1).HasMaxLength(40);
        //    entity.Property(e => e.Model2).HasMaxLength(40);
        //    entity.Property(e => e.Model3).HasMaxLength(40);
        //    entity.Property(e => e.Model4).HasMaxLength(40);
        //    entity.Property(e => e.Model5).HasMaxLength(40);
        //    entity.Property(e => e.Model6).HasMaxLength(40);
        //    entity.Property(e => e.Phone).HasMaxLength(25);
        //    entity.Property(e => e.Piplimit)
        //        .HasMaxLength(10)
        //        .HasColumnName("PIPLimit");
        //    entity.Property(e => e.PolicyFee).HasColumnType("money");
        //    entity.Property(e => e.PolicyType).HasMaxLength(20);
        //    entity.Property(e => e.Policynumber)
        //        .HasMaxLength(256)
        //        .HasColumnName("policynumber");
        //    entity.Property(e => e.QuoteStatus).HasMaxLength(20);
        //    entity.Property(e => e.Relation1).HasMaxLength(10);
        //    entity.Property(e => e.Relation2).HasMaxLength(10);
        //    entity.Property(e => e.Relation3).HasMaxLength(10);
        //    entity.Property(e => e.Relation4).HasMaxLength(10);
        //    entity.Property(e => e.Relation5).HasMaxLength(10);
        //    entity.Property(e => e.Relation6).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit1).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit2).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit3).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit4).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit5).HasMaxLength(10);
        //    entity.Property(e => e.RentalLimit6).HasMaxLength(10);
        //    entity.Property(e => e.Sex1).HasMaxLength(6);
        //    entity.Property(e => e.Sex2).HasMaxLength(6);
        //    entity.Property(e => e.Sex3).HasMaxLength(6);
        //    entity.Property(e => e.Sex4).HasMaxLength(6);
        //    entity.Property(e => e.Sex5).HasMaxLength(6);
        //    entity.Property(e => e.Sex6).HasMaxLength(6);
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN1");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN2");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN3");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN4");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN5");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN6");
        //    entity.Property(e => e.State).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed1).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed2).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed3).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed4).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed5).HasMaxLength(10);
        //    entity.Property(e => e.StateLicensed6).HasMaxLength(10);
        //    entity.Property(e => e.Term).HasMaxLength(20);
        //    entity.Property(e => e.TowingLimit1).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit2).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit3).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit4).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit5).HasMaxLength(10);
        //    entity.Property(e => e.TowingLimit6).HasMaxLength(10);
        //    entity.Property(e => e.UnderinsBilimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UnderinsBIlimits");
        //    entity.Property(e => e.UnderinsPdlimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UnderinsPDlimits");
        //    entity.Property(e => e.UninsBilimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UninsBILimits");
        //    entity.Property(e => e.UninsPdlimits)
        //        .HasMaxLength(10)
        //        .HasColumnName("UninsPDLimits");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("VIN6");
        //    entity.Property(e => e.WorkPhone).HasMaxLength(25);
        //    entity.Property(e => e.ZipCode).HasMaxLength(10);
        //});

        //modelBuilder.Entity<Naiccode>(entity =>
        //{
        //    entity.ToTable("NAICcodes");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Naic)
        //        .HasMaxLength(100)
        //        .HasColumnName("NAIC");
        //    entity.Property(e => e.Name).HasMaxLength(250);
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<Name>(entity =>
        //{
        //    entity.ToTable("Name");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Name1)
        //        .HasMaxLength(100)
        //        .HasColumnName("Name");
        //});

        //modelBuilder.Entity<NoteSearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("NoteSearch");

        //    entity.Property(e => e.Agent).HasMaxLength(250);
        //    entity.Property(e => e.CompletedDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.ImportDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.PaymentFollowUpDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.PostDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.QuoteFollowUpDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.RecordId).ValueGeneratedOnAdd();
        //    entity.Property(e => e.ReminderDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.RenewalFollowUpDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.Text).HasColumnType("ntext");
        //});

        //modelBuilder.Entity<Option>(entity =>
        //{
        //    entity.ToTable("options");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.AddRem).HasColumnName("addRem");
        //    entity.Property(e => e.AgencyFeeBasedCommission).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.AgentCopy).HasColumnName("agentCopy");
        //    entity.Property(e => e.AllowVoid).HasColumnName("allowVoid");
        //    entity.Property(e => e.AskEnterInContact).HasColumnName("askEnterInContact");
        //    entity.Property(e => e.CarrierSelectionRequired).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.ChangeRec).HasColumnName("changeRec");
        //    entity.Property(e => e.CustomPaymentFields).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.DisplayAgencyFee)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("displayAgencyFee");
        //    entity.Property(e => e.DisplayAgencyName).HasColumnName("displayAgencyName");
        //    entity.Property(e => e.DisplayPrintAutoId).HasColumnName("displayPrintAutoID");
        //    entity.Property(e => e.EnterDownpayment).HasColumnName("enterDownpayment");
        //    entity.Property(e => e.EnterInContact).HasColumnName("enterInContact");
        //    entity.Property(e => e.EnterMonthly).HasColumnName("enterMonthly");
        //    entity.Property(e => e.MakeClientFieldsRequired).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.MakePolicyNumberRequired).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.MerlinHelpAll).HasColumnName("merlinHelpAll");
        //    entity.Property(e => e.MerlinShow).HasColumnName("merlinShow");
        //    entity.Property(e => e.OnlyAdminsCanUpdate).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.PrintReceipt).HasColumnName("printReceipt");
        //    entity.Property(e => e.RecordCheck).HasColumnName("recordCheck");
        //    entity.Property(e => e.RemDays).HasColumnName("remDays");
        //    entity.Property(e => e.SaveForm).HasColumnName("saveForm");
        //    entity.Property(e => e.ScanFolder)
        //        .HasMaxLength(250)
        //        .HasColumnName("scanFolder");
        //});

        //modelBuilder.Entity<PaymentFollowUp>(entity =>
        //{
        //    entity.ToTable("PaymentFollowUp");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.FollowDate).HasColumnType("smalldatetime");
        //});

        //modelBuilder.Entity<PaymentInfo>(entity =>
        //{
        //    entity.HasKey(e => e.PaymentId);

        //    entity.ToTable("paymentInfo", tb =>
        //        {
        //            tb.HasTrigger("trg_paymentInfo_AFTER_Insert");
        //            tb.HasTrigger("trg_paymentInfo_AFTER_UPDATE");
        //        });

        //    entity.HasIndex(e => e.WithdrawalId, "IDX_WithdrawalID");

        //    entity.HasIndex(e => new { e.AgencyId, e.PayDate, e.Void, e.BDeleted }, "IX_AgencyID_PayDate_Void_Deleted_INCLUDE_PAYTYPE_PAYAMOUNT");

        //    entity.HasIndex(e => new { e.Void, e.AgencyId, e.BDeleted, e.PayDate, e.PayType, e.PayMethod }, "IX_Void_AgencyID_Deleted_PayDate_PayType_PayMethod_WITH_INCLUDEs");

        //    entity.HasIndex(e => e.BDeleted, "PaymentsSoftDelete");

        //    entity.HasIndex(e => new { e.ClientId, e.PayType, e.BDeleted }, "iX_Deleted_Paytype_ClientID");

        //    entity.HasIndex(e => e.ClientId, "ix_ClientID_WITH_INCLUDES_Exp");

        //    entity.HasIndex(e => new { e.PayDate, e.PayMethod, e.Void, e.AgencyId, e.BDeleted }, "ix_PayDate_PayMethod_Void_AgencyID_Deleted_WITH_INCLUDES");

        //    entity.HasIndex(e => new { e.Void, e.BDeleted, e.PayDate }, "ix_PaymentInfo_Void_bDeleted_PayDate_INCLUDE");

        //    entity.HasIndex(e => e.ClientId, "ix_paymentInfo_ClientID_INCLUDE_WithdrawalID");

        //    entity.HasIndex(e => e.PayDate, "ix_paymentInfo_paydate_INCLUDE_ClientID");

        //    entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
        //    entity.Property(e => e.Adjustment).HasColumnType("money");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentId).HasColumnName("AgentID");
        //    entity.Property(e => e.BDeleted).HasColumnName("bDeleted");
        //    entity.Property(e => e.BankId)
        //        .HasDefaultValueSql("((1))")
        //        .HasColumnName("bankID");
        //    entity.Property(e => e.Card)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("card");
        //    entity.Property(e => e.Cash)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("cash");
        //    entity.Property(e => e.Check1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("check1");
        //    entity.Property(e => e.Check2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("check2");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(10)
        //        .HasColumnName("checkNum");
        //    entity.Property(e => e.ChkNum2)
        //        .HasMaxLength(10)
        //        .HasColumnName("chkNum2");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.DateDeleted)
        //        .HasColumnType("datetime")
        //        .HasColumnName("dateDeleted");
        //    entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
        //    entity.Property(e => e.EftAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("eftAmount");
        //    entity.Property(e => e.MembershipType)
        //        .HasMaxLength(255)
        //        .HasColumnName("membershipType");
        //    entity.Property(e => e.Nsf)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("nsf");
        //    entity.Property(e => e.OptionalAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("optionalAmount");
        //    entity.Property(e => e.OptionalNotes)
        //        .HasMaxLength(255)
        //        .HasColumnName("optionalNotes");
        //    entity.Property(e => e.PayAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("payAmount");
        //    entity.Property(e => e.PayBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("payBalance");
        //    entity.Property(e => e.PayDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("payDate");
        //    entity.Property(e => e.PayFee)
        //        .HasColumnType("money")
        //        .HasColumnName("payFee");
        //    entity.Property(e => e.PayMethod)
        //        .HasMaxLength(50)
        //        .HasColumnName("payMethod");
        //    entity.Property(e => e.PayName)
        //        .HasMaxLength(100)
        //        .HasColumnName("payName");
        //    entity.Property(e => e.PayNotes)
        //        .HasMaxLength(255)
        //        .HasColumnName("payNotes");
        //    entity.Property(e => e.PayPaid)
        //        .HasColumnType("money")
        //        .HasColumnName("payPaid");
        //    entity.Property(e => e.PayTotal)
        //        .HasColumnType("money")
        //        .HasColumnName("payTotal");
        //    entity.Property(e => e.PayType)
        //        .HasMaxLength(50)
        //        .HasColumnName("payType");
        //    entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
        //    entity.Property(e => e.QbExport)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("qbExport");
        //    entity.Property(e => e.RecCheck)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("recCheck");
        //    entity.Property(e => e.RecConfirm)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("recConfirm");
        //    entity.Property(e => e.SentCo)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("sentCo");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Void)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("void");
        //    entity.Property(e => e.WithdrawalId).HasColumnName("WithdrawalID");
        //});

        //modelBuilder.Entity<PaymentInfoMrg>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("paymentInfo_mrg");

        //    entity.Property(e => e.Adjustment).HasColumnType("money");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentId).HasColumnName("AgentID");
        //    entity.Property(e => e.BDeleted).HasColumnName("bDeleted");
        //    entity.Property(e => e.BankId).HasColumnName("bankID");
        //    entity.Property(e => e.Card)
        //        .HasColumnType("money")
        //        .HasColumnName("card");
        //    entity.Property(e => e.Cash)
        //        .HasColumnType("money")
        //        .HasColumnName("cash");
        //    entity.Property(e => e.Check1)
        //        .HasColumnType("money")
        //        .HasColumnName("check1");
        //    entity.Property(e => e.Check2)
        //        .HasColumnType("money")
        //        .HasColumnName("check2");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(10)
        //        .HasColumnName("checkNum");
        //    entity.Property(e => e.ChkNum2)
        //        .HasMaxLength(10)
        //        .HasColumnName("chkNum2");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.DateDeleted)
        //        .HasColumnType("datetime")
        //        .HasColumnName("dateDeleted");
        //    entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
        //    entity.Property(e => e.Nsf).HasColumnName("nsf");
        //    entity.Property(e => e.PayAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("payAmount");
        //    entity.Property(e => e.PayBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("payBalance");
        //    entity.Property(e => e.PayDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("payDate");
        //    entity.Property(e => e.PayFee)
        //        .HasColumnType("money")
        //        .HasColumnName("payFee");
        //    entity.Property(e => e.PayMethod)
        //        .HasMaxLength(50)
        //        .HasColumnName("payMethod");
        //    entity.Property(e => e.PayName)
        //        .HasMaxLength(100)
        //        .HasColumnName("payName");
        //    entity.Property(e => e.PayNotes)
        //        .HasMaxLength(255)
        //        .HasColumnName("payNotes");
        //    entity.Property(e => e.PayPaid)
        //        .HasColumnType("money")
        //        .HasColumnName("payPaid");
        //    entity.Property(e => e.PayTotal)
        //        .HasColumnType("money")
        //        .HasColumnName("payTotal");
        //    entity.Property(e => e.PayType)
        //        .HasMaxLength(50)
        //        .HasColumnName("payType");
        //    entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
        //    entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
        //    entity.Property(e => e.QbExport).HasColumnName("qbExport");
        //    entity.Property(e => e.RecCheck).HasColumnName("recCheck");
        //    entity.Property(e => e.RecConfirm).HasColumnName("recConfirm");
        //    entity.Property(e => e.SentCo).HasColumnName("sentCo");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Void).HasColumnName("void");
        //    entity.Property(e => e.WithdrawalId).HasColumnName("WithdrawalID");
        //});

        //modelBuilder.Entity<PaymentSearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("PaymentSearch");

        //    entity.Property(e => e.Adjustment).HasColumnType("money");
        //    entity.Property(e => e.Agency).HasMaxLength(50);
        //    entity.Property(e => e.Agent).HasMaxLength(60);
        //    entity.Property(e => e.Applicant).HasMaxLength(101);
        //    entity.Property(e => e.Bank).HasMaxLength(200);
        //    entity.Property(e => e.Card)
        //        .HasColumnType("money")
        //        .HasColumnName("card");
        //    entity.Property(e => e.Cash)
        //        .HasColumnType("money")
        //        .HasColumnName("cash");
        //    entity.Property(e => e.Check1)
        //        .HasColumnType("money")
        //        .HasColumnName("check1");
        //    entity.Property(e => e.Check2)
        //        .HasColumnType("money")
        //        .HasColumnName("check2");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(10)
        //        .HasColumnName("checkNum");
        //    entity.Property(e => e.Company).HasMaxLength(50);
        //    entity.Property(e => e.DeletedBy).HasMaxLength(60);
        //    entity.Property(e => e.DeletedDate).HasColumnType("datetime");
        //    entity.Property(e => e.Nsf).HasColumnName("nsf");
        //    entity.Property(e => e.PayAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("payAmount");
        //    entity.Property(e => e.PayBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("payBalance");
        //    entity.Property(e => e.PayDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("payDate");
        //    entity.Property(e => e.PayFee)
        //        .HasColumnType("money")
        //        .HasColumnName("payFee");
        //    entity.Property(e => e.PayMethod)
        //        .HasMaxLength(50)
        //        .HasColumnName("payMethod");
        //    entity.Property(e => e.PayName)
        //        .HasMaxLength(100)
        //        .HasColumnName("payName");
        //    entity.Property(e => e.PayNotes)
        //        .HasMaxLength(255)
        //        .HasColumnName("payNotes");
        //    entity.Property(e => e.PayPaid)
        //        .HasColumnType("money")
        //        .HasColumnName("payPaid");
        //    entity.Property(e => e.PayTotal)
        //        .HasColumnType("money")
        //        .HasColumnName("payTotal");
        //    entity.Property(e => e.PayType)
        //        .HasMaxLength(50)
        //        .HasColumnName("payType");
        //    entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
        //    entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
        //    entity.Property(e => e.RecCheck).HasColumnName("recCheck");
        //    entity.Property(e => e.RecConfirm).HasColumnName("recConfirm");
        //    entity.Property(e => e.SentCo).HasColumnName("sentCo");
        //    entity.Property(e => e.Void).HasColumnName("void");
        //});

        //modelBuilder.Entity<PaymentinfoBackup>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("paymentinfo_backup");

        //    entity.Property(e => e.Adjustment).HasColumnType("money");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentId).HasColumnName("AgentID");
        //    entity.Property(e => e.BDeleted).HasColumnName("bDeleted");
        //    entity.Property(e => e.BankId).HasColumnName("bankID");
        //    entity.Property(e => e.Card)
        //        .HasColumnType("money")
        //        .HasColumnName("card");
        //    entity.Property(e => e.Cash)
        //        .HasColumnType("money")
        //        .HasColumnName("cash");
        //    entity.Property(e => e.Check1)
        //        .HasColumnType("money")
        //        .HasColumnName("check1");
        //    entity.Property(e => e.Check2)
        //        .HasColumnType("money")
        //        .HasColumnName("check2");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(10)
        //        .HasColumnName("checkNum");
        //    entity.Property(e => e.ChkNum2)
        //        .HasMaxLength(10)
        //        .HasColumnName("chkNum2");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.DateDeleted)
        //        .HasColumnType("datetime")
        //        .HasColumnName("dateDeleted");
        //    entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
        //    entity.Property(e => e.EftAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("eftAmount");
        //    entity.Property(e => e.Nsf).HasColumnName("nsf");
        //    entity.Property(e => e.PayAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("payAmount");
        //    entity.Property(e => e.PayBalance)
        //        .HasColumnType("money")
        //        .HasColumnName("payBalance");
        //    entity.Property(e => e.PayDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("payDate");
        //    entity.Property(e => e.PayFee)
        //        .HasColumnType("money")
        //        .HasColumnName("payFee");
        //    entity.Property(e => e.PayMethod)
        //        .HasMaxLength(50)
        //        .HasColumnName("payMethod");
        //    entity.Property(e => e.PayName)
        //        .HasMaxLength(100)
        //        .HasColumnName("payName");
        //    entity.Property(e => e.PayNotes)
        //        .HasMaxLength(255)
        //        .HasColumnName("payNotes");
        //    entity.Property(e => e.PayPaid)
        //        .HasColumnType("money")
        //        .HasColumnName("payPaid");
        //    entity.Property(e => e.PayTotal)
        //        .HasColumnType("money")
        //        .HasColumnName("payTotal");
        //    entity.Property(e => e.PayType)
        //        .HasMaxLength(50)
        //        .HasColumnName("payType");
        //    entity.Property(e => e.PaymentId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("PaymentID");
        //    entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
        //    entity.Property(e => e.QbExport).HasColumnName("qbExport");
        //    entity.Property(e => e.RecCheck).HasColumnName("recCheck");
        //    entity.Property(e => e.RecConfirm).HasColumnName("recConfirm");
        //    entity.Property(e => e.SentCo).HasColumnName("sentCo");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Void).HasColumnName("void");
        //    entity.Property(e => e.WithdrawalId).HasColumnName("WithdrawalID");
        //});

        //modelBuilder.Entity<PolicyCov>(entity =>
        //{
        //    entity.HasKey(e => e.CovId);

        //    entity.ToTable("policyCov");

        //    entity.HasIndex(e => new { e.ClientId, e.Value }, "IX_dbo_policyCov_clientIDValue");

        //    entity.Property(e => e.CovId).HasColumnName("covID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Coverage).HasMaxLength(200);
        //    entity.Property(e => e.FieldId).HasColumnName("FieldID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Value).HasMaxLength(200);
        //});

        //modelBuilder.Entity<PolicyField>(entity =>
        //{
        //    entity.HasKey(e => e.FieldId);

        //    entity.ToTable("policyFields");

        //    entity.Property(e => e.FieldId).HasColumnName("fieldID");
        //    entity.Property(e => e.FieldFormat)
        //        .HasMaxLength(200)
        //        .HasColumnName("fieldFormat");
        //    entity.Property(e => e.PolicyField1)
        //        .HasMaxLength(200)
        //        .HasColumnName("policyField");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.TabId).HasColumnName("tabID");
        //    entity.Property(e => e.TypeId).HasColumnName("typeID");
        //});

        //modelBuilder.Entity<PolicySearch>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("PolicySearch");

        //    entity.Property(e => e.Agencycommissionrate).HasColumnName("agencycommissionrate");
        //    entity.Property(e => e.Agentcommission)
        //        .HasColumnType("money")
        //        .HasColumnName("agentcommission");
        //    entity.Property(e => e.Applicantname)
        //        .HasMaxLength(101)
        //        .HasColumnName("applicantname");
        //    entity.Property(e => e.Companyname)
        //        .HasMaxLength(50)
        //        .HasColumnName("companyname");
        //    entity.Property(e => e.Datecancelled)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("datecancelled");
        //    entity.Property(e => e.Datecreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("datecreated");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.Effectivedate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("effectivedate");
        //    entity.Property(e => e.Expirationdate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("expirationdate");
        //    entity.Property(e => e.Initialpremium)
        //        .HasColumnType("money")
        //        .HasColumnName("initialpremium");
        //    entity.Property(e => e.Insuredlinkid).HasColumnName("insuredlinkid");
        //    entity.Property(e => e.Lastpaymentamount)
        //        .HasColumnType("money")
        //        .HasColumnName("lastpaymentamount");
        //    entity.Property(e => e.Lastpaymentdate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("lastpaymentdate");
        //    entity.Property(e => e.Policyfee)
        //        .HasColumnType("money")
        //        .HasColumnName("policyfee");
        //    entity.Property(e => e.Policyid).HasColumnName("policyid");
        //    entity.Property(e => e.Policynumber)
        //        .HasMaxLength(256)
        //        .HasColumnName("policynumber");
        //    entity.Property(e => e.Policytype)
        //        .HasMaxLength(20)
        //        .HasColumnName("policytype");
        //    entity.Property(e => e.Quotestatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quotestatus");
        //    entity.Property(e => e.Term)
        //        .HasMaxLength(20)
        //        .HasColumnName("term");
        //});

        //modelBuilder.Entity<PolicyTab>(entity =>
        //{
        //    entity.HasKey(e => e.TabId);

        //    entity.ToTable("policyTabs");

        //    entity.Property(e => e.TabId).HasColumnName("tabID");
        //    entity.Property(e => e.Heading).HasMaxLength(200);
        //    entity.Property(e => e.Multi)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("multi");
        //    entity.Property(e => e.Name).HasMaxLength(200);
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.TypeId).HasColumnName("typeID");
        //});

        //modelBuilder.Entity<PolicyType>(entity =>
        //{
        //    entity.HasKey(e => e.TypeId);

        //    entity.ToTable("policyTypes");

        //    entity.Property(e => e.TypeId).HasColumnName("typeID");
        //    entity.Property(e => e.Comm).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.PolicyType1)
        //        .HasMaxLength(200)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<PolicyValue>(entity =>
        //{
        //    entity.HasKey(e => e.ValueId);

        //    entity.ToTable("policyValues");

        //    entity.Property(e => e.ValueId).HasColumnName("valueID");
        //    entity.Property(e => e.FieldId).HasColumnName("fieldID");
        //    entity.Property(e => e.PolicyValue1)
        //        .HasMaxLength(200)
        //        .HasColumnName("policyValue");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<Polma>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("POLMAS");

        //    entity.Property(e => e.AddAmt)
        //        .HasColumnType("money")
        //        .HasColumnName("ADD_AMT");
        //    entity.Property(e => e.AddCom)
        //        .HasColumnType("money")
        //        .HasColumnName("ADD_COM");
        //    entity.Property(e => e.AddContractNum)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("Add_Contract_Num");
        //    entity.Property(e => e.AddCov)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ADD_COV");
        //    entity.Property(e => e.AddCrate).HasColumnName("ADD_CRATE");
        //    entity.Property(e => e.AddDesc)
        //        .HasMaxLength(25)
        //        .IsUnicode(false)
        //        .HasColumnName("Add_Desc");
        //    entity.Property(e => e.AddDown)
        //        .HasColumnType("money")
        //        .HasColumnName("ADD_DOWN");
        //    entity.Property(e => e.AddInfo)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("ADD_INFO");
        //    entity.Property(e => e.AgRnlSrc)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("AG_RNL_SRC");
        //    entity.Property(e => e.AgencyFee)
        //        .HasColumnType("money")
        //        .HasColumnName("AGENCY_FEE");
        //    entity.Property(e => e.AgentComm)
        //        .HasColumnType("money")
        //        .HasColumnName("AGENT_COMM");
        //    entity.Property(e => e.AgentPolmas)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("Agent_Polmas");
        //    entity.Property(e => e.Agentlevel)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("AGENTLEVEL");
        //    entity.Property(e => e.AmtFin)
        //        .HasColumnType("money")
        //        .HasColumnName("AMT_FIN");
        //    entity.Property(e => e.BillMgee)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("BILL_MGEE");
        //    entity.Property(e => e.BillingType)
        //        .HasMaxLength(1)
        //        .IsUnicode(false);
        //    entity.Property(e => e.BinderDat)
        //        .HasColumnType("datetime")
        //        .HasColumnName("BINDER_DAT");
        //    entity.Property(e => e.BinderNum)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("BINDER_NUM");
        //    entity.Property(e => e.BolFromRater).HasColumnName("bolFromRater");
        //    entity.Property(e => e.Broker)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CancelDat)
        //        .HasColumnType("datetime")
        //        .HasColumnName("CANCEL_DAT");
        //    entity.Property(e => e.CashCheck)
        //        .HasMaxLength(25)
        //        .IsUnicode(false)
        //        .HasColumnName("CASH_CHECK");
        //    entity.Property(e => e.Cearned)
        //        .HasColumnType("money")
        //        .HasColumnName("CEARNED");
        //    entity.Property(e => e.Cful).HasColumnName("CFUL");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("CHECK_NUM");
        //    entity.Property(e => e.Cinc).HasColumnName("CINC");
        //    entity.Property(e => e.Cissued)
        //        .HasColumnType("money")
        //        .HasColumnName("CISSUED");
        //    entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");
        //    entity.Property(e => e.CommPaid)
        //        .HasColumnType("money")
        //        .HasColumnName("COMM_PAID");
        //    entity.Property(e => e.Company)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COMPANY");
        //    entity.Property(e => e.Contractno)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("CONTRACTNO");
        //    entity.Property(e => e.CovDesc)
        //        .HasMaxLength(75)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Coverage)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("COVERAGE");
        //    entity.Property(e => e.Cpay1)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_1");
        //    entity.Property(e => e.Cpay10)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_10");
        //    entity.Property(e => e.Cpay11)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_11");
        //    entity.Property(e => e.Cpay12)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_12");
        //    entity.Property(e => e.Cpay2)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_2");
        //    entity.Property(e => e.Cpay3)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_3");
        //    entity.Property(e => e.Cpay4)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_4");
        //    entity.Property(e => e.Cpay5)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_5");
        //    entity.Property(e => e.Cpay6)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_6");
        //    entity.Property(e => e.Cpay7)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_7");
        //    entity.Property(e => e.Cpay8)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_8");
        //    entity.Property(e => e.Cpay9)
        //        .HasColumnType("money")
        //        .HasColumnName("CPAY_9");
        //    entity.Property(e => e.Cquoted)
        //        .HasColumnType("money")
        //        .HasColumnName("CQUOTED");
        //    entity.Property(e => e.Crate).HasColumnName("CRATE");
        //    entity.Property(e => e.CreditSecurityCode)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("credit_security_code");
        //    entity.Property(e => e.Csr)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CSR");
        //    entity.Property(e => e.Cstatus)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("CSTATUS");
        //    entity.Property(e => e.Ctax).HasColumnName("CTAX");
        //    entity.Property(e => e.CurBaseNonComPremium)
        //        .HasColumnType("money")
        //        .HasColumnName("curBaseNonComPremium");
        //    entity.Property(e => e.CurTowingRental)
        //        .HasColumnType("money")
        //        .HasColumnName("curTowingRental");
        //    entity.Property(e => e.CustNum)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("CUST_NUM");
        //    entity.Property(e => e.DateEntered).HasColumnType("datetime");
        //    entity.Property(e => e.Descofrisk)
        //        .HasMaxLength(750)
        //        .IsUnicode(false)
        //        .HasColumnName("DESCOFRISK");
        //    entity.Property(e => e.DirBill)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("DIR_BILL");
        //    entity.Property(e => e.DnPayment)
        //        .HasColumnType("money")
        //        .HasColumnName("DN_PAYMENT");
        //    entity.Property(e => e.DraftNum)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("DRAFT_NUM");
        //    entity.Property(e => e.Dummy1)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("DUMMY1");
        //    entity.Property(e => e.Dummy2)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("DUMMY2");
        //    entity.Property(e => e.Dummy3)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("DUMMY3");
        //    entity.Property(e => e.Dummy4)
        //        .HasMaxLength(25)
        //        .IsUnicode(false)
        //        .HasColumnName("DUMMY4");
        //    entity.Property(e => e.Dummy5).HasColumnName("DUMMY5");
        //    entity.Property(e => e.Dummy6)
        //        .HasColumnType("money")
        //        .HasColumnName("DUMMY6");
        //    entity.Property(e => e.Dummy7)
        //        .HasColumnType("datetime")
        //        .HasColumnName("DUMMY7");
        //    entity.Property(e => e.Effective)
        //        .HasColumnType("datetime")
        //        .HasColumnName("EFFECTIVE");
        //    entity.Property(e => e.EndFrom)
        //        .HasMaxLength(4)
        //        .IsUnicode(false)
        //        .HasColumnName("END_FROM");
        //    entity.Property(e => e.Endorse)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("ENDORSE");
        //    entity.Property(e => e.EndorsementPolicyId).HasColumnName("Endorsement_policy_id");
        //    entity.Property(e => e.Endorsersn)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("ENDORSERSN");
        //    entity.Property(e => e.EscrowBillRnl).HasColumnName("Escrow_Bill_Rnl");
        //    entity.Property(e => e.Expiration)
        //        .HasColumnType("datetime")
        //        .HasColumnName("EXPIRATION");
        //    entity.Property(e => e.Fee2)
        //        .HasColumnType("money")
        //        .HasColumnName("FEE2");
        //    entity.Property(e => e.Fee3)
        //        .HasColumnType("money")
        //        .HasColumnName("FEE3");
        //    entity.Property(e => e.Feedesc2)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("FEEDESC2");
        //    entity.Property(e => e.Feedesc3)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("FEEDESC3");
        //    entity.Property(e => e.Fincompany)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("FINCOMPANY");
        //    entity.Property(e => e.Flag)
        //        .HasMaxLength(8)
        //        .IsUnicode(false)
        //        .HasColumnName("FLAG");
        //    entity.Property(e => e.GAddress1)
        //        .HasMaxLength(40)
        //        .IsUnicode(false)
        //        .HasColumnName("G_ADDRESS1");
        //    entity.Property(e => e.GAddress2)
        //        .HasMaxLength(31)
        //        .IsUnicode(false)
        //        .HasColumnName("G_ADDRESS2");
        //    entity.Property(e => e.GCity)
        //        .HasMaxLength(30)
        //        .IsUnicode(false)
        //        .HasColumnName("G_CITY");
        //    entity.Property(e => e.GState)
        //        .HasMaxLength(3)
        //        .IsUnicode(false)
        //        .HasColumnName("G_STATE");
        //    entity.Property(e => e.GZip)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("G_ZIP");
        //    entity.Property(e => e.IntAddressId).HasColumnName("intAddressID");
        //    entity.Property(e => e.IntBasePremium)
        //        .HasColumnType("money")
        //        .HasColumnName("intBasePremium");
        //    entity.Property(e => e.IntCommPremium)
        //        .HasColumnType("money")
        //        .HasColumnName("intCommPremium");
        //    entity.Property(e => e.IntLastPage).HasColumnName("intLastPage");
        //    entity.Property(e => e.IntMga).HasColumnName("intMGA");
        //    entity.Property(e => e.IntPackage).HasColumnName("intPackage");
        //    entity.Property(e => e.Iou)
        //        .HasColumnType("money")
        //        .HasColumnName("IOU");
        //    entity.Property(e => e.Ioureason)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("IOUREASON");
        //    entity.Property(e => e.Lastfunc)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("LASTFUNC");
        //    entity.Property(e => e.Lastupdate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("LASTUPDATE");
        //    entity.Property(e => e.Lob)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("LOB");
        //    entity.Property(e => e.Mga)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("MGA");
        //    entity.Property(e => e.Mpay1)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_1");
        //    entity.Property(e => e.Mpay10)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_10");
        //    entity.Property(e => e.Mpay11)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_11");
        //    entity.Property(e => e.Mpay12)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_12");
        //    entity.Property(e => e.Mpay13)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_13");
        //    entity.Property(e => e.Mpay14)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_14");
        //    entity.Property(e => e.Mpay15)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_15");
        //    entity.Property(e => e.Mpay16)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_16");
        //    entity.Property(e => e.Mpay2)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_2");
        //    entity.Property(e => e.Mpay3)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_3");
        //    entity.Property(e => e.Mpay4)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_4");
        //    entity.Property(e => e.Mpay5)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_5");
        //    entity.Property(e => e.Mpay6)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_6");
        //    entity.Property(e => e.Mpay7)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_7");
        //    entity.Property(e => e.Mpay8)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_8");
        //    entity.Property(e => e.Mpay9)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_9");
        //    entity.Property(e => e.MpayAmt)
        //        .HasColumnType("money")
        //        .HasColumnName("MPAY_AMT");
        //    entity.Property(e => e.MpayDue)
        //        .HasColumnType("datetime")
        //        .HasColumnName("MPAY_DUE");
        //    entity.Property(e => e.MpayNum).HasColumnName("MPAY_NUM");
        //    entity.Property(e => e.MvrComm).HasColumnType("money");
        //    entity.Property(e => e.MvrCost).HasColumnType("money");
        //    entity.Property(e => e.MvrFee)
        //        .HasColumnType("money")
        //        .HasColumnName("MVR_FEE");
        //    entity.Property(e => e.Naic)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("NAIC");
        //    entity.Property(e => e.NetGross)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("NET_GROSS");
        //    entity.Property(e => e.OldClientId).HasColumnName("Old_Client_ID");
        //    entity.Property(e => e.OldEndorsementPolicyId).HasColumnName("old_endorsement_policy_ID");
        //    entity.Property(e => e.OldPolicyId).HasColumnName("Old_Policy_ID");
        //    entity.Property(e => e.OldSplitPolicyId).HasColumnName("old_split_policy_ID");
        //    entity.Property(e => e.OptAmt)
        //        .HasColumnType("money")
        //        .HasColumnName("OPT_AMT");
        //    entity.Property(e => e.OptCom)
        //        .HasColumnType("money")
        //        .HasColumnName("OPT_COM");
        //    entity.Property(e => e.OptContractNum)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("Opt_Contract_Num");
        //    entity.Property(e => e.OptCov)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("OPT_COV");
        //    entity.Property(e => e.OptCrate).HasColumnName("OPT_CRATE");
        //    entity.Property(e => e.OptDesc)
        //        .HasMaxLength(25)
        //        .IsUnicode(false)
        //        .HasColumnName("Opt_Desc");
        //    entity.Property(e => e.OptDown)
        //        .HasColumnType("money")
        //        .HasColumnName("OPT_DOWN");
        //    entity.Property(e => e.OptInfo)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("OPT_INFO");
        //    entity.Property(e => e.Pearned)
        //        .HasColumnType("money")
        //        .HasColumnName("PEARNED");
        //    entity.Property(e => e.Period)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("PERIOD");
        //    entity.Property(e => e.PersComm)
        //        .HasMaxLength(1)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Pfee)
        //        .HasColumnType("money")
        //        .HasColumnName("PFEE");
        //    entity.Property(e => e.Pissued)
        //        .HasColumnType("money")
        //        .HasColumnName("PISSUED");
        //    entity.Property(e => e.Plan)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(35)
        //        .IsUnicode(false)
        //        .HasColumnName("POLICY_NUM");
        //    entity.Property(e => e.Power10)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("POWER10");
        //    entity.Property(e => e.Ppos)
        //        .HasMaxLength(4)
        //        .IsUnicode(false)
        //        .HasColumnName("PPOS");
        //    entity.Property(e => e.Pquoted)
        //        .HasColumnType("money")
        //        .HasColumnName("PQUOTED");
        //    entity.Property(e => e.ProShort)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("PRO_SHORT");
        //    entity.Property(e => e.Psource)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("PSource");
        //    entity.Property(e => e.Pstatus)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("PSTATUS");
        //    entity.Property(e => e.Qqc)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("QQC");
        //    entity.Property(e => e.ReceiptNo)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("RECEIPT_NO");
        //    entity.Property(e => e.Reconcile)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("RECONCILE");
        //    entity.Property(e => e.ReinstAmout)
        //        .HasColumnType("money")
        //        .HasColumnName("Reinst_Amout");
        //    entity.Property(e => e.ReinstDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("Reinst_Date");
        //    entity.Property(e => e.ReinstLapse).HasColumnName("Reinst_Lapse");
        //    entity.Property(e => e.Rowguid).HasColumnName("rowguid");
        //    entity.Property(e => e.Split)
        //        .HasMaxLength(1)
        //        .IsUnicode(false)
        //        .HasColumnName("SPLIT");
        //    entity.Property(e => e.SplitFrom)
        //        .HasMaxLength(4)
        //        .IsUnicode(false)
        //        .HasColumnName("SPLIT_FROM");
        //    entity.Property(e => e.SplitPolicyId).HasColumnName("Split_policy_id");
        //    entity.Property(e => e.Sr22)
        //        .HasColumnType("money")
        //        .HasColumnName("SR22");
        //    entity.Property(e => e.Sr22CaseNum)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("SR22_CaseNum");
        //    entity.Property(e => e.TimeEntered).HasColumnType("datetime");
        //    entity.Property(e => e.TimeStamp)
        //        .HasColumnType("datetime")
        //        .HasColumnName("time_stamp");
        //    entity.Property(e => e.TypeOfBus)
        //        .HasMaxLength(75)
        //        .IsUnicode(false);
        //    entity.Property(e => e.UcommPaid)
        //        .HasColumnType("money")
        //        .HasColumnName("UCOMM_PAID");
        //    entity.Property(e => e.Unique)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("UNIQUE");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.WarnRsn)
        //        .HasMaxLength(3)
        //        .IsUnicode(false)
        //        .HasColumnName("WARN_RSN");
        //    entity.Property(e => e.Warning)
        //        .HasColumnType("datetime")
        //        .HasColumnName("WARNING");
        //    entity.Property(e => e.Wholesaler)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<QbExport>(entity =>
        //{
        //    entity.ToTable("qbExport");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.ExpAccounts)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("expAccounts");
        //    entity.Property(e => e.ExpChecks)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("expChecks");
        //    entity.Property(e => e.ExpClients)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("expClients");
        //    entity.Property(e => e.ExpCompanies)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("expCompanies");
        //    entity.Property(e => e.ExpDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("expDate");
        //    entity.Property(e => e.ExpDeposit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("expDeposit");
        //    entity.Property(e => e.ExpEnd)
        //        .HasColumnType("datetime")
        //        .HasColumnName("expEnd");
        //    entity.Property(e => e.ExpPayments)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("expPayments");
        //    entity.Property(e => e.ExpStart)
        //        .HasColumnType("datetime")
        //        .HasColumnName("expStart");
        //});

        //modelBuilder.Entity<Query>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Query");

        //    entity.Property(e => e.DateCreated).HasPrecision(3);
        //    entity.Property(e => e.DateModified).HasPrecision(3);
        //    entity.Property(e => e.Description).HasMaxLength(255);
        //    entity.Property(e => e.EmailUidl)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("EmailUIDL");
        //    entity.Property(e => e.FileName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.IpAddress).HasMaxLength(20);
        //    entity.Property(e => e.Md5)
        //        .HasMaxLength(39)
        //        .IsUnicode(false);
        //    entity.Property(e => e.NewFilename).HasMaxLength(255);
        //    entity.Property(e => e.ObjectName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.OldFilename).HasMaxLength(255);
        //    entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
        //    entity.Property(e => e.PrivateKey).HasMaxLength(32);
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasPrecision(3)
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasPrecision(3)
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Uploadcompleted).HasColumnName("uploadcompleted");
        //    entity.Property(e => e.Workstation)
        //        .HasMaxLength(50)
        //        .HasColumnName("workstation");
        //});

        //modelBuilder.Entity<Reminder>(entity =>
        //{
        //    entity.HasIndex(e => e.AgentId, "ix_Reminders_AgentID_WITH_INCLUDES");

        //    entity.HasIndex(e => new { e.Done, e.RemDate, e.Remind }, "ix_Reminders_Done_RemDate_Remind");

        //    entity.HasIndex(e => e.Remind, "ix_Reminders_Remind");

        //    entity.HasIndex(e => e.ClientId, "ix_Reminders_clientID_WITH_INCLUDES");

        //    entity.HasIndex(e => new { e.ClientId, e.Done, e.Remind }, "ix_Reminders_clientID_done_remind");

        //    entity.Property(e => e.ReminderId).HasColumnName("reminderID");
        //    entity.Property(e => e.Account).HasMaxLength(250);
        //    entity.Property(e => e.AgentId).HasColumnName("AgentID");
        //    entity.Property(e => e.Amount).HasColumnName("amount");
        //    entity.Property(e => e.Ap)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("AP");
        //    entity.Property(e => e.Ar)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("AR");
        //    entity.Property(e => e.Arpdone)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("ARPDone");
        //    entity.Property(e => e.Category)
        //        .HasMaxLength(255)
        //        .HasColumnName("category");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.ComDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("comDate");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.Critical)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("critical");
        //    entity.Property(e => e.Done)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("done");
        //    entity.Property(e => e.ImpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("impDate");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Memo1)
        //        .HasColumnType("ntext")
        //        .HasColumnName("memo1");
        //    entity.Property(e => e.PayTo)
        //        .HasMaxLength(250)
        //        .HasColumnName("payTo");
        //    entity.Property(e => e.PaymentDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("paymentDate");
        //    entity.Property(e => e.PaymentFollow)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("paymentFollow");
        //    entity.Property(e => e.Popup).HasColumnName("popup");
        //    entity.Property(e => e.PostDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("postDate");
        //    entity.Property(e => e.QuoteDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("quoteDate");
        //    entity.Property(e => e.QuoteFollow)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("quoteFollow");
        //    entity.Property(e => e.RemDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("remDate");
        //    entity.Property(e => e.Remind)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("remind");
        //    entity.Property(e => e.RenewDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("renewDate");
        //    entity.Property(e => e.RenewFollow)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("renewFollow");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<Remindersbak1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Remindersbak1");

        //    entity.Property(e => e.Account).HasMaxLength(250);
        //    entity.Property(e => e.AgentId).HasColumnName("AgentID");
        //    entity.Property(e => e.Amount).HasColumnName("amount");
        //    entity.Property(e => e.Ap).HasColumnName("AP");
        //    entity.Property(e => e.Ar).HasColumnName("AR");
        //    entity.Property(e => e.Arpdone).HasColumnName("ARPDone");
        //    entity.Property(e => e.Category)
        //        .HasMaxLength(255)
        //        .HasColumnName("category");
        //    entity.Property(e => e.ClientId).HasColumnName("ClientID");
        //    entity.Property(e => e.ComDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("comDate");
        //    entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        //    entity.Property(e => e.Critical).HasColumnName("critical");
        //    entity.Property(e => e.Done).HasColumnName("done");
        //    entity.Property(e => e.ImpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("impDate");
        //    entity.Property(e => e.Memo).HasColumnType("ntext");
        //    entity.Property(e => e.Memo1)
        //        .HasColumnType("ntext")
        //        .HasColumnName("memo1");
        //    entity.Property(e => e.PayTo)
        //        .HasMaxLength(250)
        //        .HasColumnName("payTo");
        //    entity.Property(e => e.PaymentDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("paymentDate");
        //    entity.Property(e => e.PaymentFollow).HasColumnName("paymentFollow");
        //    entity.Property(e => e.Popup).HasColumnName("popup");
        //    entity.Property(e => e.PostDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("postDate");
        //    entity.Property(e => e.QuoteDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("quoteDate");
        //    entity.Property(e => e.QuoteFollow).HasColumnName("quoteFollow");
        //    entity.Property(e => e.RemDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("remDate");
        //    entity.Property(e => e.Remind).HasColumnName("remind");
        //    entity.Property(e => e.ReminderId).HasColumnName("reminderID");
        //    entity.Property(e => e.RenewDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("renewDate");
        //    entity.Property(e => e.RenewFollow).HasColumnName("renewFollow");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<RenewFollowUp>(entity =>
        //{
        //    entity.ToTable("RenewFollowUp");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.FollowDate).HasColumnType("smalldatetime");
        //});

        //modelBuilder.Entity<Sr22>(entity =>
        //{
        //    entity.HasKey(e => e.SrId);

        //    entity.ToTable("SR22");

        //    entity.Property(e => e.SrId).HasColumnName("srID");
        //    entity.Property(e => e.BridgeId).HasColumnName("bridgeID");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.DrvNum).HasColumnName("drvNum");
        //    entity.Property(e => e.SrCase)
        //        .HasMaxLength(200)
        //        .HasColumnName("srCase");
        //    entity.Property(e => e.SrDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("srDate");
        //    entity.Property(e => e.SrReason)
        //        .HasMaxLength(200)
        //        .HasColumnName("srReason");
        //    entity.Property(e => e.SrState)
        //        .HasMaxLength(50)
        //        .HasColumnName("srState");
        //});

        //modelBuilder.Entity<SystemSetting>(entity =>
        //{
        //    entity.HasIndex(e => e.Key, "IX_SystemSettings").IsUnique();

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Key)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("key");
        //    entity.Property(e => e.Value)
        //        .HasMaxLength(512)
        //        .IsUnicode(false)
        //        .HasColumnName("value");
        //});

        //modelBuilder.Entity<TblAdditionalIncome>(entity =>
        //{
        //    entity.ToTable("tblAdditionalIncome");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Agencyid).HasColumnName("agencyid");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.Checkamt)
        //        .HasColumnType("money")
        //        .HasColumnName("checkamt");
        //    entity.Property(e => e.CompanyName)
        //        .HasMaxLength(100)
        //        .IsFixedLength();
        //    entity.Property(e => e.Companyid).HasColumnName("companyid");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("deletedby");
        //    entity.Property(e => e.Memo)
        //        .HasMaxLength(250)
        //        .HasColumnName("memo");
        //    entity.Property(e => e.SysUtccreateDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreateDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //});

        //modelBuilder.Entity<TblAfeeCommRate>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("tblAFeeCommRates");

        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate).HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby).HasColumnName("deletedby");
        //    entity.Property(e => e.Flatrate)
        //        .HasColumnType("decimal(4, 1)")
        //        .HasColumnName("flatrate");
        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.IsPctBased).HasColumnName("isPctBased");
        //    entity.Property(e => e.Pct)
        //        .HasColumnType("decimal(4, 1)")
        //        .HasColumnName("pct");
        //    entity.Property(e => e.SysUtcdateCreated).HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified).HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Tier).HasColumnName("tier");
        //    entity.Property(e => e.Title).HasMaxLength(20);
        //});

        //modelBuilder.Entity<TblAfeesCommission>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("tblAFeesCommissions");

        //    entity.Property(e => e.AfeeAmt).HasColumnType("money");
        //    entity.Property(e => e.CommAmt).HasColumnType("money");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
        //    entity.Property(e => e.DeletedDate).HasColumnName("deletedDate");
        //    entity.Property(e => e.Id)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("id");
        //    entity.Property(e => e.PdAmount).HasColumnType("money");
        //    entity.Property(e => e.PdCheckNum)
        //        .HasMaxLength(100)
        //        .HasColumnName("pdCheckNum");
        //    entity.Property(e => e.PdDate)
        //        .HasColumnType("date")
        //        .HasColumnName("pdDate");
        //    entity.Property(e => e.Rec).HasColumnName("rec");
        //    entity.Property(e => e.SysUtcdateCreated).HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<TblBankDeposit>(entity =>
        //{
        //    entity.HasKey(e => e.BankDepositId);

        //    entity.ToTable("tblBankDeposits");

        //    entity.HasIndex(e => new { e.ReportId, e.Deleted }, "IX_tblBankDeposits_ReportID_Deleted");

        //    entity.Property(e => e.Agencyid)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("agencyid");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.BankId).HasColumnName("BankID");
        //    entity.Property(e => e.Cashamt)
        //        .HasColumnType("money")
        //        .HasColumnName("cashamt");
        //    entity.Property(e => e.Checkamt)
        //        .HasColumnType("money")
        //        .HasColumnName("checkamt");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby).HasColumnName("deletedby");
        //    entity.Property(e => e.DepDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("depDate");
        //    entity.Property(e => e.Memo).HasColumnName("memo");
        //    entity.Property(e => e.ReportId).HasColumnName("ReportID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //    entity.Property(e => e.Totalamt)
        //        .HasColumnType("money")
        //        .HasColumnName("totalamt");
        //});

        //modelBuilder.Entity<TblCommissionPayment>(entity =>
        //{
        //    entity.ToTable("tblCommissionPayments");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.CommissionDate).HasColumnType("datetime");
        //    entity.Property(e => e.CommissionId).HasColumnName("CommissionID");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby).HasColumnName("deletedby");
        //    entity.Property(e => e.PayDate).HasColumnType("datetime");
        //    entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModifed)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModifed");
        //});

        //modelBuilder.Entity<TblCompPayment>(entity =>
        //{
        //    entity.ToTable("tblCompPayments");

        //    entity.HasIndex(e => e.Reportid, "ix_ReportID");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Agencyid).HasColumnName("agencyid");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.CalcAmount)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("calcAmount");
        //    entity.Property(e => e.Companyname)
        //        .HasMaxLength(50)
        //        .IsFixedLength()
        //        .HasColumnName("companyname");
        //    entity.Property(e => e.Compid).HasColumnName("compid");
        //    entity.Property(e => e.Cpnotes).HasColumnName("CPNotes");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.Deletedate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedate");
        //    entity.Property(e => e.Deletedby).HasColumnName("deletedby");
        //    entity.Property(e => e.Diff)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("diff");
        //    entity.Property(e => e.EnteredAmt)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("enteredAmt");
        //    entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        //    entity.Property(e => e.Reportid)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("reportid");
        //    entity.Property(e => e.SysUtccreatedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreatedDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCmodifiedDate");
        //});

        //modelBuilder.Entity<TblCreditCardBatch>(entity =>
        //{
        //    entity.HasKey(e => e.Batchid);

        //    entity.ToTable("tblCreditCardBatches");

        //    entity.Property(e => e.Batchid).HasColumnName("batchid");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyId");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.BatAmount)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.BatFee)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.BatMemo)
        //        .HasMaxLength(250)
        //        .HasColumnName("batMemo");
        //    entity.Property(e => e.BatNet)
        //        .HasColumnType("money")
        //        .HasColumnName("batNet");
        //    entity.Property(e => e.BatchNo)
        //        .HasMaxLength(10)
        //        .IsFixedLength()
        //        .HasColumnName("batchNo");
        //    entity.Property(e => e.BatchType)
        //        .HasMaxLength(20)
        //        .IsFixedLength();
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby).HasColumnName("deletedby");
        //    entity.Property(e => e.Screenid).HasColumnName("screenid");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModifed)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModifed");
        //});

        //modelBuilder.Entity<TblEodagencyFee>(entity =>
        //{
        //    entity.ToTable("tblEODAgencyFees");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.AfeeDiff)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.Agencyid).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.Agentid).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.CalcAfeeAmt)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("calcAfeeAmt");
        //    entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.DeletedBy).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.Deleteddate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deleteddate");
        //    entity.Property(e => e.Reportid)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("reportid");
        //    entity.Property(e => e.SysUtccreatedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreatedDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //    entity.Property(e => e.TotAfCount).HasColumnName("totAfCount");
        //    entity.Property(e => e.TotalAfeeAmt)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //});

        //modelBuilder.Entity<TblEodreport>(entity =>
        //{
        //    entity.HasKey(e => e.Reportid);

        //    entity.ToTable("tblEODReports");

        //    entity.HasIndex(e => new { e.Agencyid, e.Reportdate }, "IX_dbo_tblEODReports_agencyidreportdate");

        //    entity.HasIndex(e => e.Reportid, "ix_tblEODReports_reportid");

        //    entity.Property(e => e.Reportid).HasColumnName("reportid");
        //    entity.Property(e => e.Agencyid).HasColumnName("agencyid");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.AttachmentSuppId).HasColumnName("AttachmentSuppID");
        //    entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.DeletedBy).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.Deleteddate)
        //        .HasDefaultValueSql("('1/1/1900')")
        //        .HasColumnType("datetime")
        //        .HasColumnName("deleteddate");
        //    entity.Property(e => e.ExportQblog)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("exportQBLog");
        //    entity.Property(e => e.Reloadflag)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("reloadflag");
        //    entity.Property(e => e.Reportdate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("reportdate");
        //    entity.Property(e => e.Reportstatus)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("(N'Not Verified')")
        //        .HasColumnName("reportstatus");
        //    entity.Property(e => e.ShortOver)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("shortOver");
        //    entity.Property(e => e.SysUtccreateDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreateDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //    entity.Property(e => e.TotAddIncome)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totAddIncome");
        //    entity.Property(e => e.TotAgencyfee)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totAgencyfee");
        //    entity.Property(e => e.TotAllDeposits)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totAllDeposits");
        //    entity.Property(e => e.TotCreditCardbat)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totCreditCardbat");
        //    entity.Property(e => e.TotEcheck)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totECheck");
        //    entity.Property(e => e.TotIou)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totIOU");
        //    entity.Property(e => e.TotPayments)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totPayments");
        //    entity.Property(e => e.TotSweep)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totSweep");
        //    entity.Property(e => e.TotTitlTransOut)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totTitlTransOut");
        //    entity.Property(e => e.TotTitleTransIn)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totTitleTransIn");
        //    entity.Property(e => e.TotYouOweMe)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totYouOweMe");
        //    entity.Property(e => e.TotalIn)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.TotalOut)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money")
        //        .HasColumnName("totalOut");
        //    entity.Property(e => e.VerifiedDateTime).HasColumnType("datetime");
        //    entity.Property(e => e.VerifierId).HasColumnName("VerifierID");
        //    entity.Property(e => e.Zmveridfiedid).HasColumnName("ZMVeridfiedid");
        //    entity.Property(e => e.ZmverifiedDateTime)
        //        .HasColumnType("datetime")
        //        .HasColumnName("ZMVerifiedDateTime");
        //});

        //modelBuilder.Entity<TblEodrptPayment>(entity =>
        //{
        //    entity.ToTable("tblEODRptPayments");

        //    entity.HasIndex(e => new { e.Reportid, e.Deleted }, "ix_tblEODRptPayments_reportid_deleted_WITH_INCLUDES");

        //    entity.HasIndex(e => new { e.Reportid, e.Paymentid, e.Deleted }, "ix_tblEODRptPayments_reportid_paymentid_deleted");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Clientid).HasColumnName("clientid");
        //    entity.Property(e => e.Companyid).HasColumnName("companyid");
        //    entity.Property(e => e.Deleted)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("deleted");
        //    entity.Property(e => e.Deletedate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedate");
        //    entity.Property(e => e.Deletedby)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("deletedby");
        //    entity.Property(e => e.PayAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("payAmount");
        //    entity.Property(e => e.PayFee)
        //        .HasColumnType("money")
        //        .HasColumnName("payFee");
        //    entity.Property(e => e.Paydate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("paydate");
        //    entity.Property(e => e.Paymentid).HasColumnName("paymentid");
        //    entity.Property(e => e.Paymethod)
        //        .HasMaxLength(50)
        //        .IsFixedLength()
        //        .HasColumnName("paymethod");
        //    entity.Property(e => e.Paytype)
        //        .HasMaxLength(50)
        //        .IsFixedLength()
        //        .HasColumnName("paytype");
        //    entity.Property(e => e.Policynum)
        //        .HasMaxLength(100)
        //        .IsFixedLength()
        //        .HasColumnName("policynum");
        //    entity.Property(e => e.Reportid).HasColumnName("reportid");
        //    entity.Property(e => e.SysUtccreateDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreateDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //});

        //modelBuilder.Entity<TblIouUome>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK_tbl_IOU");

        //    entity.ToTable("tblIOU_UOMe");

        //    entity.HasIndex(e => e.Paymentid, "ix_PaymentID");

        //    entity.HasIndex(e => new { e.RecAgencyId, e.Paydate }, "ix_recAgencyID_paydate_Include_PaymentID");

        //    entity.HasIndex(e => new { e.ForAgencyId, e.Deleted, e.Paydate }, "ix_tblIOU_UOMe_forAgencyID_deleted_paydate");

        //    entity.HasIndex(e => e.Paydate, "ix_tblIOU_UOMe_paydate");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.AgencyFeeAmt)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.Agentid)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("agentid");
        //    entity.Property(e => e.Amount)
        //        .HasColumnType("money")
        //        .HasColumnName("amount");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("deletedby");
        //    entity.Property(e => e.ForAgencyId)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("forAgencyID");
        //    entity.Property(e => e.IouagencyReportid)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("IOUAgencyReportid");
        //    entity.Property(e => e.Memo)
        //        .HasMaxLength(500)
        //        .HasColumnName("memo");
        //    entity.Property(e => e.Paydate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("paydate");
        //    entity.Property(e => e.PaymentBankId).HasColumnName("PaymentBankID");
        //    entity.Property(e => e.PaymentTotal)
        //        .HasDefaultValueSql("((0.00))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.Paymentid).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.RecAgencyId)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("recAgencyID");
        //    entity.Property(e => e.RecAgentid).HasColumnName("recAgentid");
        //    entity.Property(e => e.Sysutccreatedate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysutccreatedate");
        //    entity.Property(e => e.Sysutcmodifieddate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysutcmodifieddate");
        //    entity.Property(e => e.UomagencyReportid).HasColumnName("UOMAgencyReportid");
        //});

        //modelBuilder.Entity<TblMappedAgency>(entity =>
        //{
        //    entity.ToTable("tblMappedAgency");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.AgencyName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("agencyName");
        //    entity.Property(e => e.Classreference)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("classreference");
        //    entity.Property(e => e.CreditAcctName)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("creditAcctName");
        //    entity.Property(e => e.DebitAcctName)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnName("debitAcctName");
        //    entity.Property(e => e.DisplayedAgency)
        //        .HasMaxLength(150)
        //        .IsUnicode(false)
        //        .HasColumnName("displayedAgency");
        //});

        //modelBuilder.Entity<TblRecordLock>(entity =>
        //{
        //    entity.HasKey(e => e.LockId);

        //    entity.ToTable("tblRecordLocks");

        //    entity.Property(e => e.LockId).HasColumnName("LockID");
        //    entity.Property(e => e.LockedBy).HasMaxLength(36);
        //    entity.Property(e => e.LockedByUserName).HasMaxLength(50);
        //    entity.Property(e => e.LockedDateTime).HasColumnType("datetime");
        //    entity.Property(e => e.RecordId).HasColumnName("RecordID");
        //    entity.Property(e => e.UnlockRequestedBy).HasMaxLength(36);
        //    entity.Property(e => e.UnlockRequestedByUserName).HasMaxLength(50);
        //    entity.Property(e => e.UnlockRequestedDateTime).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<TblRefund>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("tblRefunds");

        //    entity.Property(e => e.Agencyid).HasColumnName("agencyid");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.Clientid).HasColumnName("clientid");
        //    entity.Property(e => e.Deleted)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("deleted");
        //    entity.Property(e => e.DeletedBy)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("deletedBy");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Paymentid).HasColumnName("paymentid");
        //    entity.Property(e => e.RefundAmtAfee)
        //        .HasColumnType("money")
        //        .HasColumnName("RefundAmtAFee");
        //    entity.Property(e => e.RefundAmtPrem).HasColumnType("money");
        //    entity.Property(e => e.RefundDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("refundDate");
        //    entity.Property(e => e.RefundFor)
        //        .HasMaxLength(50)
        //        .HasColumnName("refundFor");
        //    entity.Property(e => e.RefundReason)
        //        .HasMaxLength(250)
        //        .HasColumnName("refundReason");
        //    entity.Property(e => e.Refundid)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("refundid");
        //    entity.Property(e => e.SysUtccreateDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreateDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //});

        //modelBuilder.Entity<TblSchemaChange>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK_SchemaChanges");

        //    entity.ToTable("tblSchemaChanges");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.DateApplied)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(512)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Major).HasDefaultValueSql("((6))");
        //    entity.Property(e => e.ScriptName)
        //        .HasMaxLength(256)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<TblSupplemental>(entity =>
        //{
        //    entity.ToTable("tblSupplementals");

        //    entity.HasIndex(e => new { e.ObjectType, e.Deleted }, "IX_dbo_tblSupplementals_ObjectType_Deleted");

        //    entity.HasIndex(e => new { e.OwnerType, e.ObjectType, e.Description, e.Deleted }, "IX_dbo_tblSupplementals_OwnerType_ObjectType_Description_Deleted");

        //    entity.HasIndex(e => new { e.ObjectType, e.Deleted }, "idx_tblSupplementals_Object_Type");

        //    entity.HasIndex(e => new { e.OwnerId, e.OwnerType, e.ObjectType, e.Deleted }, "idx_tblSupplementals_OwnerID1");

        //    entity.HasIndex(e => new { e.OwnerId, e.ObjectType, e.Deleted }, "idx_tblSupplementals_OwnerID2");

        //    entity.HasIndex(e => new { e.OwnerType, e.ObjectType, e.Deleted }, "idx_tblSupplementals_OwnerType_ObjectType_Deleted");

        //    entity.HasIndex(e => new { e.Deleted, e.DateModified }, "ix_tblSupplementals_Deleted_DateModified_WITH_INCLUDES");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.DateCreated)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.EmailUidl)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("EmailUIDL");
        //    entity.Property(e => e.FileName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.IpAddress).HasMaxLength(20);
        //    entity.Property(e => e.Md5)
        //        .HasMaxLength(39)
        //        .IsUnicode(false)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NewFilename)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ObjectName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OldFilename)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
        //    entity.Property(e => e.OwnerType).HasDefaultValueSql("((1))");
        //    entity.Property(e => e.PrivateKey).HasMaxLength(32);
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.Uploadcompleted)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("uploadcompleted");
        //    entity.Property(e => e.Workstation)
        //        .HasMaxLength(50)
        //        .HasColumnName("workstation");
        //});

        //modelBuilder.Entity<TblSweep>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("tblSweeps");

        //    entity.Property(e => e.CompanyName)
        //        .HasMaxLength(100)
        //        .IsFixedLength()
        //        .HasColumnName("companyName");
        //    entity.Property(e => e.Companyid).HasColumnName("companyid");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedBy)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("deletedBy");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.InvoiceNo)
        //        .HasMaxLength(50)
        //        .IsFixedLength();
        //    entity.Property(e => e.Reportid).HasColumnName("reportid");
        //    entity.Property(e => e.SweepAmt).HasColumnType("money");
        //    entity.Property(e => e.Sweepid)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("sweepid");
        //    entity.Property(e => e.SysUtccreateDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreateDate");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        //modelBuilder.Entity<TblTitleTransfer>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("tblTitleTransfers");

        //    entity.Property(e => e.Accountname)
        //        .HasMaxLength(50)
        //        .HasColumnName("accountname");
        //    entity.Property(e => e.Agencyid).HasColumnName("agencyid");
        //    entity.Property(e => e.Agentid).HasColumnName("agentid");
        //    entity.Property(e => e.Deleted).HasColumnName("deleted");
        //    entity.Property(e => e.DeletedDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("deletedDate");
        //    entity.Property(e => e.Deletedby)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("deletedby");
        //    entity.Property(e => e.Itemid)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("itemid");
        //    entity.Property(e => e.Itemtype).HasColumnName("itemtype");
        //    entity.Property(e => e.Memo)
        //        .HasMaxLength(250)
        //        .HasColumnName("memo");
        //    entity.Property(e => e.Reportid)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("reportid");
        //    entity.Property(e => e.SysUtccreateDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCCreateDate");
        //    entity.Property(e => e.SysUtcmodifiedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCModifiedDate");
        //    entity.Property(e => e.TransAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("transAmount");
        //});

        //modelBuilder.Entity<TblVersion>(entity =>
        //{
        //    entity.HasKey(e => e.VersionId);

        //    entity.ToTable("tblVersion");

        //    entity.Property(e => e.VersionId).HasColumnName("VersionID");
        //    entity.Property(e => e.CurrentVersion).HasMaxLength(35);
        //    entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        //    entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<TempInfo>(entity =>
        //{
        //    entity.HasKey(e => e.Transid).HasName("PK_newTempInfo");

        //    entity.ToTable("tempInfo", tb => tb.HasTrigger("trg_TempInfo_AFTER_INSERT_OR_Update"));

        //    entity.Property(e => e.AaClientId).HasColumnName("aaClientID");
        //    entity.Property(e => e.Aacid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AAcid");
        //    entity.Property(e => e.Aapid)
        //        .HasMaxLength(50)
        //        .HasColumnName("AApid");
        //    entity.Property(e => e.AddLiv)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money");
        //    entity.Property(e => e.AddressCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("addressCity");
        //    entity.Property(e => e.AddressState)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressState");
        //    entity.Property(e => e.AddressStreet)
        //        .HasMaxLength(60)
        //        .HasColumnName("addressStreet");
        //    entity.Property(e => e.AddressZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("addressZip");
        //    entity.Property(e => e.AgencyBuzzId).HasColumnName("AgencyBuzzID");
        //    entity.Property(e => e.AgencyBuzzPolicyId).HasColumnName("AgencyBuzzPolicyID");
        //    entity.Property(e => e.AgencyCommission)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("agencyCommission");
        //    entity.Property(e => e.AgencyFee)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("agencyFee");
        //    entity.Property(e => e.AgencyId).HasColumnName("agencyID");
        //    entity.Property(e => e.AgentCommission)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission");
        //    entity.Property(e => e.AgentCommission2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("agentCommission2");
        //    entity.Property(e => e.AgentId).HasColumnName("agentID");
        //    entity.Property(e => e.AgentId2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("agentID2");
        //    entity.Property(e => e.AgentPaid)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("agentPaid");
        //    entity.Property(e => e.AgentPaid2).HasColumnName("agentPaid2");
        //    entity.Property(e => e.Alarm)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("alarm");
        //    entity.Property(e => e.Anniversary).HasColumnType("smalldatetime");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(100)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.Assoc).HasDefaultValueSql("((-1))");
        //    entity.Property(e => e.Bodily)
        //        .HasMaxLength(10)
        //        .HasColumnName("bodily");
        //    entity.Property(e => e.BodilyIndex).HasColumnName("bodilyIndex");
        //    entity.Property(e => e.BusinessName)
        //        .HasMaxLength(100)
        //        .HasColumnName("businessName");
        //    entity.Property(e => e.Carrier1).HasMaxLength(100);
        //    entity.Property(e => e.Carrier2).HasMaxLength(100);
        //    entity.Property(e => e.CellPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone");
        //    entity.Property(e => e.CellPhone1)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone1");
        //    entity.Property(e => e.CellPhone2)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone2");
        //    entity.Property(e => e.CellPhone3)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone3");
        //    entity.Property(e => e.CellPhone4)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone4");
        //    entity.Property(e => e.CellPhone5)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone5");
        //    entity.Property(e => e.CellPhone6)
        //        .HasMaxLength(25)
        //        .HasColumnName("cellPhone6");
        //    entity.Property(e => e.ClientEmail)
        //        .HasMaxLength(200)
        //        .HasColumnName("clientEmail");
        //    entity.Property(e => e.ClientId)
        //        .HasDefaultValueSql("((-1))")
        //        .HasColumnName("clientID");
        //    entity.Property(e => e.ClientNote)
        //        .HasColumnType("ntext")
        //        .HasColumnName("clientNote");
        //    entity.Property(e => e.CoName)
        //        .HasMaxLength(100)
        //        .HasColumnName("coName");
        //    entity.Property(e => e.Coll1)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll1");
        //    entity.Property(e => e.Coll2)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll2");
        //    entity.Property(e => e.Coll3)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll3");
        //    entity.Property(e => e.Coll4)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll4");
        //    entity.Property(e => e.Coll5)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll5");
        //    entity.Property(e => e.Coll6)
        //        .HasMaxLength(10)
        //        .HasColumnName("coll6");
        //    entity.Property(e => e.Comp1)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp1");
        //    entity.Property(e => e.Comp2)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp2");
        //    entity.Property(e => e.Comp3)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp3");
        //    entity.Property(e => e.Comp4)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp4");
        //    entity.Property(e => e.Comp5)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp5");
        //    entity.Property(e => e.Comp6)
        //        .HasMaxLength(10)
        //        .HasColumnName("comp6");
        //    entity.Property(e => e.CompanyFee)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("companyFee");
        //    entity.Property(e => e.CompanyId).HasColumnName("companyID");
        //    entity.Property(e => e.Const)
        //        .HasMaxLength(50)
        //        .HasColumnName("const");
        //    entity.Property(e => e.Coverage).HasMaxLength(255);
        //    entity.Property(e => e.DateAccessed)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateAccessed");
        //    entity.Property(e => e.DateCreated)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateCreated");
        //    entity.Property(e => e.DateDeleted).HasColumnType("datetime");
        //    entity.Property(e => e.DateModified)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("dateModified");
        //    entity.Property(e => e.Ded)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("ded");
        //    entity.Property(e => e.DirectDebit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("directDebit");
        //    entity.Property(e => e.Dl1)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl1");
        //    entity.Property(e => e.Dl1Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL1_enc");
        //    entity.Property(e => e.Dl2)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl2");
        //    entity.Property(e => e.Dl2Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL2_enc");
        //    entity.Property(e => e.Dl3)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl3");
        //    entity.Property(e => e.Dl3Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL3_enc");
        //    entity.Property(e => e.Dl4)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl4");
        //    entity.Property(e => e.Dl4Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL4_enc");
        //    entity.Property(e => e.Dl5)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl5");
        //    entity.Property(e => e.Dl5Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL5_enc");
        //    entity.Property(e => e.Dl6)
        //        .HasMaxLength(256)
        //        .HasColumnName("dl6");
        //    entity.Property(e => e.Dl6Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("DL6_enc");
        //    entity.Property(e => e.DlState5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState5");
        //    entity.Property(e => e.DlState6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlState6");
        //    entity.Property(e => e.Dlstate1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate1");
        //    entity.Property(e => e.Dlstate2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate2");
        //    entity.Property(e => e.Dlstate3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate3");
        //    entity.Property(e => e.Dlstate4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlstate4");
        //    entity.Property(e => e.Dlyear1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear1");
        //    entity.Property(e => e.Dlyear1Index).HasColumnName("dlyear1Index");
        //    entity.Property(e => e.Dlyear2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear2");
        //    entity.Property(e => e.Dlyear2Index).HasColumnName("dlyear2Index");
        //    entity.Property(e => e.Dlyear3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear3");
        //    entity.Property(e => e.Dlyear3Index).HasColumnName("dlyear3Index");
        //    entity.Property(e => e.Dlyear4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear4");
        //    entity.Property(e => e.Dlyear4Index).HasColumnName("dlyear4Index");
        //    entity.Property(e => e.Dlyear5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear5");
        //    entity.Property(e => e.Dlyear6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dlyear6");
        //    entity.Property(e => e.DnPayType).HasMaxLength(255);
        //    entity.Property(e => e.Dob1)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob1");
        //    entity.Property(e => e.Dob2)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob2");
        //    entity.Property(e => e.Dob3)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob3");
        //    entity.Property(e => e.Dob4)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob4");
        //    entity.Property(e => e.Dob5)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob5");
        //    entity.Property(e => e.Dob6)
        //        .HasMaxLength(10)
        //        .HasColumnName("dob6");
        //    entity.Property(e => e.DownPayment)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("downPayment");
        //    entity.Property(e => e.DownloadDate).HasColumnType("datetime");
        //    entity.Property(e => e.DrExclude1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude1");
        //    entity.Property(e => e.DrExclude2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude2");
        //    entity.Property(e => e.DrExclude3)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude3");
        //    entity.Property(e => e.DrExclude4)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude4");
        //    entity.Property(e => e.DrExclude5)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude5");
        //    entity.Property(e => e.DrExclude6)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drExclude6");
        //    entity.Property(e => e.DrSr221)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_1");
        //    entity.Property(e => e.DrSr222)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_2");
        //    entity.Property(e => e.DrSr223)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_3");
        //    entity.Property(e => e.DrSr224)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_4");
        //    entity.Property(e => e.DrSr225)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_5");
        //    entity.Property(e => e.DrSr226)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("drSR22_6");
        //    entity.Property(e => e.Dwelling)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("dwelling");
        //    entity.Property(e => e.EdLevel1)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel2)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel3)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel4)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel5)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.EdLevel6)
        //        .HasMaxLength(40)
        //        .IsFixedLength();
        //    entity.Property(e => e.Edited).HasColumnName("edited");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(100)
        //        .HasColumnName("email");
        //    entity.Property(e => e.EmailStatus)
        //        .HasMaxLength(50)
        //        .HasColumnName("emailStatus");
        //    entity.Property(e => e.EndAmount)
        //        .HasColumnType("money")
        //        .HasColumnName("endAmount");
        //    entity.Property(e => e.EndEffDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("endEffDate");
        //    entity.Property(e => e.FName1)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName1");
        //    entity.Property(e => e.FName2)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName2");
        //    entity.Property(e => e.FName3)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName3");
        //    entity.Property(e => e.FName4)
        //        .HasMaxLength(50)
        //        .HasColumnName("fName4");
        //    entity.Property(e => e.FileNum)
        //        .HasMaxLength(50)
        //        .HasColumnName("fileNum");
        //    entity.Property(e => e.FinCo)
        //        .HasMaxLength(250)
        //        .HasColumnName("finCo");
        //    entity.Property(e => e.Fire)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("fire");
        //    entity.Property(e => e.Fname5)
        //        .HasMaxLength(50)
        //        .HasColumnName("fname5");
        //    entity.Property(e => e.Fname6)
        //        .HasMaxLength(50)
        //        .HasColumnName("fname6");
        //    entity.Property(e => e.Gender1)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender1");
        //    entity.Property(e => e.Gender1index).HasColumnName("gender1index");
        //    entity.Property(e => e.Gender2)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender2");
        //    entity.Property(e => e.Gender2index).HasColumnName("gender2index");
        //    entity.Property(e => e.Gender3)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender3");
        //    entity.Property(e => e.Gender3index).HasColumnName("gender3index");
        //    entity.Property(e => e.Gender4)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender4");
        //    entity.Property(e => e.Gender4index).HasColumnName("gender4index");
        //    entity.Property(e => e.Gender5)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender5");
        //    entity.Property(e => e.Gender5index).HasColumnName("gender5index");
        //    entity.Property(e => e.Gender6)
        //        .HasMaxLength(6)
        //        .HasColumnName("gender6");
        //    entity.Property(e => e.Gender6index).HasColumnName("gender6index");
        //    entity.Property(e => e.HoForm).HasMaxLength(50);
        //    entity.Property(e => e.HomePhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("homePhone");
        //    entity.Property(e => e.LName1)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName1");
        //    entity.Property(e => e.LName2)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName2");
        //    entity.Property(e => e.LName3)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName3");
        //    entity.Property(e => e.LName4)
        //        .HasMaxLength(50)
        //        .HasColumnName("lName4");
        //    entity.Property(e => e.Liab)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("liab");
        //    entity.Property(e => e.Lname5)
        //        .HasMaxLength(50)
        //        .HasColumnName("lname5");
        //    entity.Property(e => e.Lname6)
        //        .HasMaxLength(50)
        //        .HasColumnName("lname6");
        //    entity.Property(e => e.Loss)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("loss");
        //    entity.Property(e => e.MaddCity)
        //        .HasMaxLength(50)
        //        .HasColumnName("MAddCity");
        //    entity.Property(e => e.MaddLine1)
        //        .HasMaxLength(250)
        //        .HasColumnName("MAddLine1");
        //    entity.Property(e => e.MaddSt)
        //        .HasMaxLength(25)
        //        .HasColumnName("MAddSt");
        //    entity.Property(e => e.MaddZip)
        //        .HasMaxLength(10)
        //        .HasColumnName("MAddZip");
        //    entity.Property(e => e.Make1)
        //        .HasMaxLength(20)
        //        .HasColumnName("make1");
        //    entity.Property(e => e.Make1Index).HasColumnName("make1Index");
        //    entity.Property(e => e.Make2)
        //        .HasMaxLength(20)
        //        .HasColumnName("make2");
        //    entity.Property(e => e.Make2Index).HasColumnName("make2Index");
        //    entity.Property(e => e.Make3)
        //        .HasMaxLength(20)
        //        .HasColumnName("make3");
        //    entity.Property(e => e.Make3Index).HasColumnName("make3Index");
        //    entity.Property(e => e.Make4)
        //        .HasMaxLength(20)
        //        .HasColumnName("make4");
        //    entity.Property(e => e.Make4Index).HasColumnName("make4Index");
        //    entity.Property(e => e.Make5)
        //        .HasMaxLength(20)
        //        .HasColumnName("make5");
        //    entity.Property(e => e.Make5Index).HasColumnName("make5Index");
        //    entity.Property(e => e.Make6)
        //        .HasMaxLength(20)
        //        .HasColumnName("make6");
        //    entity.Property(e => e.Make6Index).HasColumnName("make6Index");
        //    entity.Property(e => e.Married1)
        //        .HasMaxLength(10)
        //        .HasColumnName("married1");
        //    entity.Property(e => e.Married1index).HasColumnName("married1index");
        //    entity.Property(e => e.Married2)
        //        .HasMaxLength(10)
        //        .HasColumnName("married2");
        //    entity.Property(e => e.Married2index).HasColumnName("married2index");
        //    entity.Property(e => e.Married3)
        //        .HasMaxLength(10)
        //        .HasColumnName("married3");
        //    entity.Property(e => e.Married3index).HasColumnName("married3index");
        //    entity.Property(e => e.Married4)
        //        .HasMaxLength(10)
        //        .HasColumnName("married4");
        //    entity.Property(e => e.Married4index).HasColumnName("married4index");
        //    entity.Property(e => e.Married5)
        //        .HasMaxLength(10)
        //        .HasColumnName("married5");
        //    entity.Property(e => e.Married5index).HasColumnName("married5index");
        //    entity.Property(e => e.Married6)
        //        .HasMaxLength(10)
        //        .HasColumnName("married6");
        //    entity.Property(e => e.Married6index).HasColumnName("married6index");
        //    entity.Property(e => e.Med)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("med");
        //    entity.Property(e => e.Medical)
        //        .HasMaxLength(10)
        //        .HasColumnName("medical");
        //    entity.Property(e => e.MedicalIndex).HasColumnName("medicalIndex");
        //    entity.Property(e => e.Model1)
        //        .HasMaxLength(40)
        //        .HasColumnName("model1");
        //    entity.Property(e => e.Model1Index).HasColumnName("model1Index");
        //    entity.Property(e => e.Model2)
        //        .HasMaxLength(40)
        //        .HasColumnName("model2");
        //    entity.Property(e => e.Model2Index).HasColumnName("model2Index");
        //    entity.Property(e => e.Model3)
        //        .HasMaxLength(40)
        //        .HasColumnName("model3");
        //    entity.Property(e => e.Model3Index).HasColumnName("model3Index");
        //    entity.Property(e => e.Model4)
        //        .HasMaxLength(40)
        //        .HasColumnName("model4");
        //    entity.Property(e => e.Model4Index).HasColumnName("model4Index");
        //    entity.Property(e => e.Model5)
        //        .HasMaxLength(40)
        //        .HasColumnName("model5");
        //    entity.Property(e => e.Model5Index).HasColumnName("model5Index");
        //    entity.Property(e => e.Model6)
        //        .HasMaxLength(40)
        //        .HasColumnName("model6");
        //    entity.Property(e => e.Model6Index).HasColumnName("model6Index");
        //    entity.Property(e => e.MonthlyPayment)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("monthlyPayment");
        //    entity.Property(e => e.NativeLanguage).HasMaxLength(50);
        //    entity.Property(e => e.NumDrivers).HasColumnName("numDrivers");
        //    entity.Property(e => e.NumVeh).HasColumnName("numVeh");
        //    entity.Property(e => e.OccIndustry1).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry2).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry3).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry4).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry5).HasMaxLength(75);
        //    entity.Property(e => e.OccIndustry6).HasMaxLength(75);
        //    entity.Property(e => e.Occup1).HasMaxLength(50);
        //    entity.Property(e => e.Occup2).HasMaxLength(50);
        //    entity.Property(e => e.Occup3).HasMaxLength(50);
        //    entity.Property(e => e.Occup4).HasMaxLength(50);
        //    entity.Property(e => e.Occup5).HasMaxLength(50);
        //    entity.Property(e => e.Occup6).HasMaxLength(50);
        //    entity.Property(e => e.OtherPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("otherPhone");
        //    entity.Property(e => e.Otherstruc)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("otherstruc");
        //    entity.Property(e => e.OwnHome)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("ownHome");
        //    entity.Property(e => e.Pip)
        //        .HasMaxLength(10)
        //        .HasColumnName("pip");
        //    entity.Property(e => e.PipIndex).HasColumnName("pipIndex");
        //    entity.Property(e => e.PmtDueDay).HasColumnName("pmtDueDay");
        //    entity.Property(e => e.PmtType).HasColumnName("pmtType");
        //    entity.Property(e => e.PolCanDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("polCanDate");
        //    entity.Property(e => e.PolicyEffDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyEffDate");
        //    entity.Property(e => e.PolicyExpDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyExpDate");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.PolicyNum2)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum2");
        //    entity.Property(e => e.PolicyRenDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("policyRenDate");
        //    entity.Property(e => e.PolicyTerm)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyTerm");
        //    entity.Property(e => e.PolicyTermIndex).HasColumnName("policyTermIndex");
        //    entity.Property(e => e.PolicyType)
        //        .HasMaxLength(20)
        //        .HasColumnName("policyType");
        //    entity.Property(e => e.PolicyTypeIndex).HasColumnName("policyTypeIndex");
        //    entity.Property(e => e.Premium)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("premium");
        //    entity.Property(e => e.PriorInsurance)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("priorInsurance");
        //    entity.Property(e => e.PriorLapse)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorLapse");
        //    entity.Property(e => e.PriorLapseIndex).HasColumnName("priorLapseIndex");
        //    entity.Property(e => e.PriorMarket)
        //        .HasMaxLength(50)
        //        .HasColumnName("priorMarket");
        //    entity.Property(e => e.PriorMarketIndex).HasColumnName("priorMarketIndex");
        //    entity.Property(e => e.Prop)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("prop");
        //    entity.Property(e => e.Property)
        //        .HasMaxLength(10)
        //        .HasColumnName("property");
        //    entity.Property(e => e.PropertyIndex).HasColumnName("propertyIndex");
        //    entity.Property(e => e.QuoteStatus)
        //        .HasMaxLength(20)
        //        .HasColumnName("quoteStatus");
        //    entity.Property(e => e.Relation1)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation1");
        //    entity.Property(e => e.Relation1index).HasColumnName("relation1index");
        //    entity.Property(e => e.Relation2)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation2");
        //    entity.Property(e => e.Relation2index).HasColumnName("relation2index");
        //    entity.Property(e => e.Relation3)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation3");
        //    entity.Property(e => e.Relation3index).HasColumnName("relation3index");
        //    entity.Property(e => e.Relation4)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation4");
        //    entity.Property(e => e.Relation4index).HasColumnName("relation4index");
        //    entity.Property(e => e.Relation5)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation5");
        //    entity.Property(e => e.Relation5index).HasColumnName("relation5index");
        //    entity.Property(e => e.Relation6)
        //        .HasMaxLength(10)
        //        .HasColumnName("relation6");
        //    entity.Property(e => e.Relation6index).HasColumnName("relation6index");
        //    entity.Property(e => e.Rent1)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent1");
        //    entity.Property(e => e.Rent2)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent2");
        //    entity.Property(e => e.Rent3)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent3");
        //    entity.Property(e => e.Rent4)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent4");
        //    entity.Property(e => e.Rent5)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent5");
        //    entity.Property(e => e.Rent6)
        //        .HasMaxLength(10)
        //        .HasColumnName("rent6");
        //    entity.Property(e => e.Replace)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("replace");
        //    entity.Property(e => e.Roof)
        //        .HasMaxLength(50)
        //        .HasColumnName("roof");
        //    entity.Property(e => e.Room)
        //        .HasMaxLength(50)
        //        .HasColumnName("room");
        //    entity.Property(e => e.SearchName).HasMaxLength(250);
        //    entity.Property(e => e.SellDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("sellDate");
        //    entity.Property(e => e.Sqft)
        //        .HasMaxLength(50)
        //        .HasColumnName("sqft");
        //    entity.Property(e => e.Ssn1)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn1");
        //    entity.Property(e => e.Ssn1Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN1_enc");
        //    entity.Property(e => e.Ssn2)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn2");
        //    entity.Property(e => e.Ssn2Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN2_enc");
        //    entity.Property(e => e.Ssn3)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn3");
        //    entity.Property(e => e.Ssn3Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN3_enc");
        //    entity.Property(e => e.Ssn4)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn4");
        //    entity.Property(e => e.Ssn4Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN4_enc");
        //    entity.Property(e => e.Ssn5)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn5");
        //    entity.Property(e => e.Ssn5Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN5_enc");
        //    entity.Property(e => e.Ssn6)
        //        .HasMaxLength(12)
        //        .HasColumnName("ssn6");
        //    entity.Property(e => e.Ssn6Enc)
        //        .HasMaxLength(256)
        //        .IsUnicode(false)
        //        .HasColumnName("SSN6_enc");
        //    entity.Property(e => e.Style1)
        //        .HasMaxLength(20)
        //        .HasColumnName("style1");
        //    entity.Property(e => e.Style1Index).HasColumnName("style1Index");
        //    entity.Property(e => e.Style2)
        //        .HasMaxLength(20)
        //        .HasColumnName("style2");
        //    entity.Property(e => e.Style2Index).HasColumnName("style2Index");
        //    entity.Property(e => e.Style3)
        //        .HasMaxLength(20)
        //        .HasColumnName("style3");
        //    entity.Property(e => e.Style3Index).HasColumnName("style3Index");
        //    entity.Property(e => e.Style4)
        //        .HasMaxLength(20)
        //        .HasColumnName("style4");
        //    entity.Property(e => e.Style4Index).HasColumnName("style4Index");
        //    entity.Property(e => e.Style5)
        //        .HasMaxLength(20)
        //        .HasColumnName("style5");
        //    entity.Property(e => e.Style5Index).HasColumnName("style5Index");
        //    entity.Property(e => e.Style6)
        //        .HasMaxLength(20)
        //        .HasColumnName("style6");
        //    entity.Property(e => e.Style6Index).HasColumnName("style6Index");
        //    entity.Property(e => e.Swim)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("swim");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //    entity.Property(e => e.TempDeleted).HasDefaultValueSql("((0))");
        //    entity.Property(e => e.Tow1)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow1");
        //    entity.Property(e => e.Tow2)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow2");
        //    entity.Property(e => e.Tow3)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow3");
        //    entity.Property(e => e.Tow4)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow4");
        //    entity.Property(e => e.Tow5)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow5");
        //    entity.Property(e => e.Tow6)
        //        .HasMaxLength(10)
        //        .HasColumnName("tow6");
        //    entity.Property(e => e.TransCode)
        //        .HasMaxLength(50)
        //        .HasColumnName("transCode");
        //    entity.Property(e => e.TransFileName).HasMaxLength(100);
        //    entity.Property(e => e.TransType).HasMaxLength(50);
        //    entity.Property(e => e.UeCommAg1)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg1");
        //    entity.Property(e => e.UeCommAg2)
        //        .HasColumnType("money")
        //        .HasColumnName("ueCommAg2");
        //    entity.Property(e => e.Uec)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("uec");
        //    entity.Property(e => e.Ueprem)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("money")
        //        .HasColumnName("ueprem");
        //    entity.Property(e => e.UimBi)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimBI");
        //    entity.Property(e => e.UimBiindex).HasColumnName("uimBIIndex");
        //    entity.Property(e => e.UimPd)
        //        .HasMaxLength(10)
        //        .HasColumnName("uimPD");
        //    entity.Property(e => e.UimPdindex).HasColumnName("uimPDIndex");
        //    entity.Property(e => e.Unbi)
        //        .HasMaxLength(10)
        //        .HasColumnName("unbi");
        //    entity.Property(e => e.UnbiIndex).HasColumnName("unbiIndex");
        //    entity.Property(e => e.Unpd)
        //        .HasMaxLength(10)
        //        .HasColumnName("unpd");
        //    entity.Property(e => e.UnpdIndex).HasColumnName("unpdIndex");
        //    entity.Property(e => e.UpAgent).HasColumnName("upAgent");
        //    entity.Property(e => e.UploadDate).HasColumnType("datetime");
        //    entity.Property(e => e.Vin1)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin1");
        //    entity.Property(e => e.Vin2)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin2");
        //    entity.Property(e => e.Vin3)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin3");
        //    entity.Property(e => e.Vin4)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin4");
        //    entity.Property(e => e.Vin5)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin5");
        //    entity.Property(e => e.Vin6)
        //        .HasMaxLength(20)
        //        .HasColumnName("vin6");
        //    entity.Property(e => e.WorkPhone)
        //        .HasMaxLength(25)
        //        .HasColumnName("workPhone");
        //    entity.Property(e => e.Year1)
        //        .HasMaxLength(4)
        //        .HasColumnName("year1");
        //    entity.Property(e => e.Year2)
        //        .HasMaxLength(4)
        //        .HasColumnName("year2");
        //    entity.Property(e => e.Year3)
        //        .HasMaxLength(4)
        //        .HasColumnName("year3");
        //    entity.Property(e => e.Year4)
        //        .HasMaxLength(4)
        //        .HasColumnName("year4");
        //    entity.Property(e => e.Year5)
        //        .HasMaxLength(4)
        //        .HasColumnName("year5");
        //    entity.Property(e => e.Year6)
        //        .HasMaxLength(4)
        //        .HasColumnName("year6");
        //    entity.Property(e => e.Yrbuilt)
        //        .HasMaxLength(50)
        //        .HasColumnName("yrbuilt");
        //});

        //modelBuilder.Entity<TempaccidentInfo>(entity =>
        //{
        //    entity.HasKey(e => e.TempaccId);

        //    entity.ToTable("tempaccidentInfo");

        //    entity.Property(e => e.TempaccId).HasColumnName("tempaccID");
        //    entity.Property(e => e.AccDate)
        //        .HasColumnType("datetime")
        //        .HasColumnName("accDate");
        //    entity.Property(e => e.AccNotes)
        //        .HasColumnType("ntext")
        //        .HasColumnName("accNotes");
        //    entity.Property(e => e.ApplicantName)
        //        .HasMaxLength(100)
        //        .HasColumnName("applicantName");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.DriverFname)
        //        .HasMaxLength(20)
        //        .HasColumnName("driverFName");
        //    entity.Property(e => e.DriverLname)
        //        .HasMaxLength(20)
        //        .HasColumnName("driverLName");
        //    entity.Property(e => e.DriverNum).HasColumnName("driverNum");
        //    entity.Property(e => e.NewClient).HasColumnName("newClient");
        //    entity.Property(e => e.PolicyNum)
        //        .HasMaxLength(256)
        //        .HasColumnName("policyNum");
        //    entity.Property(e => e.Violation)
        //        .HasMaxLength(250)
        //        .HasColumnName("violation");
        //});

        //modelBuilder.Entity<WriteCheck>(entity =>
        //{
        //    entity.HasKey(e => e.CheckId);

        //    entity.ToTable("writeCheck");

        //    entity.HasIndex(e => new { e.CheckNum, e.BankId, e.CheckId }, "IX_writecheck_CheckNum_BankID_CheckID");

        //    entity.HasIndex(e => new { e.BankId, e.CheckId }, "ix_WriteCheck_BankdID_CheckID_INCLUDE_CheckNum");

        //    entity.HasIndex(e => e.ClientId, "ix_writeCheck_ClientID");

        //    entity.Property(e => e.CheckId).HasColumnName("checkID");
        //    entity.Property(e => e.Account)
        //        .HasMaxLength(100)
        //        .HasColumnName("account");
        //    entity.Property(e => e.Amount)
        //        .HasColumnType("money")
        //        .HasColumnName("amount");
        //    entity.Property(e => e.BankId)
        //        .HasDefaultValueSql("((1))")
        //        .HasColumnName("bankID");
        //    entity.Property(e => e.CheckDate)
        //        .HasColumnType("smalldatetime")
        //        .HasColumnName("checkDate");
        //    entity.Property(e => e.CheckNum)
        //        .HasMaxLength(100)
        //        .HasColumnName("checkNum");
        //    entity.Property(e => e.ChkNum).HasColumnName("chkNum");
        //    entity.Property(e => e.ClientId).HasColumnName("clientID");
        //    entity.Property(e => e.Memo)
        //        .HasMaxLength(255)
        //        .HasColumnName("memo");
        //    entity.Property(e => e.PayTo)
        //        .HasMaxLength(100)
        //        .HasColumnName("payTo");
        //    entity.Property(e => e.PrintNoShow)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("printNoShow");
        //    entity.Property(e => e.Printed)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("printed");
        //    entity.Property(e => e.QbExport)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("qbExport");
        //    entity.Property(e => e.RecCheck)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("recCheck");
        //    entity.Property(e => e.RecConfirm)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnName("recConfirm");
        //    entity.Property(e => e.SysUtcdateCreated)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateCreated");
        //    entity.Property(e => e.SysUtcdateModified)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("sysUTCDateModified");
        //});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
