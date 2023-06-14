using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebCalculator.CalculatorLogic;
using WebCalculator.WebApplicationMVC.Models;

namespace WebCalculator.WebApplicationMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new CalcOperation());
    }
    
    [HttpPost]
    [ActionName("Index")]
    public IActionResult Calc(double left, double right, CalcOperators operation, double result)
    {
        var calc = new CalcOperation(){Left = left, Right = right, Operation = operation, Result = result};
        
        switch (calc.Operation)
        {
            case CalcOperators.Addition:
                calc.Result = CalcOperations.Add(left: calc.Left, right: calc.Right);
                break;
            case CalcOperators.Subtraction:
                calc.Result = CalcOperations.Subtract(left: calc.Left, right: calc.Right);

                break;
            case CalcOperators.Division:
                calc.Result = CalcOperations.Divide(left: calc.Left, right: calc.Right);

                break;
            case CalcOperators.Multiplication:
                calc.Result = CalcOperations.Multiply(left: calc.Left, right: calc.Right);

                break;
        }
        
        return View("Index", calc);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}