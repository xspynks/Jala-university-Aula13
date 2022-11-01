using Microsoft.AspNetCore.Mvc;

namespace Jala_university_Aula13.Controllers;

[Route("api/[controller]/[action]")]
public class ExchangeController : Controller
{
    private readonly WalletService _walletService;
    
    private readonly AddMoneyService _addMoneyService;

    public ExchangeController(WalletService walletService, AddMoneyService addMoneyService)
    {
        _walletService = walletService;
        _addMoneyService = addMoneyService;
    }

    [HttpGet]
    public IActionResult GetAvailableMoney()
    {
        return Ok(_walletService.Balance);
    }

    [HttpPost]
    public ActionResult ExchangeMoney(string money, decimal amount)
    {
        var result = _walletService.ExchangeMoney(money, amount);
        return StatusCode(200);
    }

    [HttpPost]
    public IActionResult AddMoneyToWallet(decimal amount)
    {
        _addMoneyService.AddToBalance(amount);
        return Ok(amount);
    }
}