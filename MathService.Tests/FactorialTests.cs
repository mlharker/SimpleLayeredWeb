namespace MathService.Tests;

public class FactorialTests
{
    FactorialService fs = new FactorialService();
    [Fact]
    public void ZeroTest()
    {
        Assert.Equal(1, actual: fs.Factorial(0));
    }
    [Fact]
    public void OneTest()
    {
        Assert.Equal(1, actual: fs.Factorial(1));
    }
    [Fact]
    public void NormalTest()
    {
        Assert.Equal(24, actual: fs.Factorial(4));
    }
}