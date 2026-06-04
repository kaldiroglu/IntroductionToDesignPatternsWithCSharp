namespace dev.kaldiroglu.dp.intro.problems.complexIfs;

/// <summary>
/// A data object with many fields, consumed by <see cref="UserProcessor"/>.
/// (C# port: the Java version exposed getters only; here they are auto-properties
/// so the object can actually be populated.)
/// </summary>
public class User
{
    public int Age { get; set; }
    public int Experience { get; set; }
    public List<string>? Certifications { get; set; }
    public int LastLoginDays { get; set; }
    public int FailedLogins { get; set; }
    public bool BackgroundCheck { get; set; }
    public bool ComplianceTraining { get; set; }
    public bool FinancialClearance { get; set; }
    public int AuditScore { get; set; }
    public bool GeneralTraining { get; set; }
    public int AccountAge { get; set; }
    public int TrialDaysRemaining { get; set; }
    public string? SuspensionReason { get; set; }
    public bool ParentalConsent { get; set; }
}
