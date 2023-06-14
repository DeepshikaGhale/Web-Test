namespace WebCalculator.CalculatorLogic.Tests;

[TestClass]
public class CalcOperationTests
{
    [TestMethod]
    public void AddMethodReturnShouldReturnADoubleType()
    {
        var left = 1d;
        var right = 1d;
        var result = CalcOperations.Add(left, right);
        Assert.IsInstanceOfType(result, typeof(double));
    }
    
    [TestMethod]
    [DataRow(1d,1d, 2d)]
    [DataRow(1d,3d, 4d)]
    [DataRow(5d,1d, 6d)]
    public void AddMethodReturnShouldReturnAddedValues(double left, double right, double expected)
    {
        var result = CalcOperations.Add(left, right);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    [DataRow(1d,1d, 2d)]
    [DataRow(1d,3d, 4d)]
    [DataRow(5d,1d, 6d)]
    public void AddMethodReturnShouldBeTransitive(double left, double right, double expected)
    {
        var result = CalcOperations.Add(left, right);
        Assert.AreEqual(expected, result);
        
        var resultT = CalcOperations.Add(right, left);
        Assert.AreEqual(expected, resultT);
        
        
    }
    
}