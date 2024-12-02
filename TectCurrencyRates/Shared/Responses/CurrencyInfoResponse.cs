namespace Shared.Responses;

public class CurrencyInfoResponse
{
    public required string Symbol { get; set; }

    public float ExchangeBuyRate { get; set; }
    public float ExchangeSellRate { get; set; }
}
