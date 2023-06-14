namespace WebCalculator.WebApplicationMVC.Models;

public class CalcOperation
{
    public double Left { get; set; }
    
    public double Right { get; set; }
    
    public double Result { get; set; }

    public CalcOperators Operation;
}

public enum CalcOperators
{
    Addition,
    Subtraction,
    Division,
    Multiplication
}