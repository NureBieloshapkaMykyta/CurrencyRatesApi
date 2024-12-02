namespace Shared.Options;

public class PrivatBankOptions
{
    public const string SectionName = "PrivatBank";
    public required string CurrenciesUrl {  get; set; }
    public required string CorsesUrl { get; set; }
}
