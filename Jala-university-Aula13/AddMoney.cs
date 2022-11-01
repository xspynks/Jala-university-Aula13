namespace Jala_university_Aula13;

public class AddMoneyService : WalletService
{
    public void AddToBalance(decimal amount)
    {
        Balance += amount;
    }
}