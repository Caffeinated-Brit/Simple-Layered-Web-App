using Xunit;
namespace MathService.Tests;

public class FactorialTests
{
    [Fact]
    public void factorial0f2()
    {
        Assert.Equal(2,FactorialService.CalculateFactorial(2));
    }
    [Fact]
    public void factorial0f0()
    {
        Assert.Equal(1,FactorialService.CalculateFactorial(0));
    }
    [Fact]
    public void factorial0f10()
    {
        Assert.Equal(3628800,FactorialService.CalculateFactorial(10));
    }
    [Fact]
    public void notFactorial0f0()
    {
        Assert.NotEqual(-1,FactorialService.CalculateFactorial(0));
    }
}