namespace Jala_university_Aula13;

public class WalletService : CurrencyService
{
    public void CurrencyService(string symbol, string code)
    {
        Symbol = symbol;
        Code = code;
    }
    
    public int Id { get; set; }
    public const string WalletCurrency = "BRL";
    
    public decimal Balance { get;  set; }
    
    public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount)
    {
        if (!Currencies.TryGetValue(outgoingCurrency, out var to))
        {
            throw new ArgumentException("Invalid currency");
        }

        if (amount < 50)
        {
            throw new InvalidOperationException("amount below expected");
        }

        if (amount > Balance)
        {
            throw new ArgumentException();
        }
       
        var total = (amount * to) - 0.01M;
        
        return new Tuple<string, decimal>(outgoingCurrency, total);
    }
}