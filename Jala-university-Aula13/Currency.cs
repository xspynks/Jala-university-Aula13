namespace Jala_university_Aula13;

public class CurrencyService
{
    public string Symbol { get; set; }
    public  string Code { get; set; }

    public Dictionary<string, decimal> Currencies { get; set; } = new Dictionary<string, decimal>()
        {
            {"USD", 0.18M},
            {"CAD", 0.90M},
            {"EUR", 0.20M},
        };
}