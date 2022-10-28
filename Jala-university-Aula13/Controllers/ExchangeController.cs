using Microsoft.AspNetCore.Mvc;

namespace Jala_university_Aula13.Controllers;

[Route("api/[controller]/[action]")]
public class ExchangeController : Controller
{
    private readonly WalletService _walletService;

    public ExchangeController(WalletService walletService)
    {
        _walletService = walletService;
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
        _walletService.AddToBalance(amount);
        return Ok();
    }

}