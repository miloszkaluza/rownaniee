namespace testy;
using QuadraticEquationSolver;

public class UnitTest1
{
    [Theory]
    [InlineData(1, -5, 6, 2, 3)]
    [InlineData(1, -2, 1, 1, 1)]
    [InlineData(2, -8, 12, 2, 3)]
    public void CalculateRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
    {
        var roots = QuadraticEquation.CalculateRoots(a, b, c);
        Assert.Equal(2, roots.Length);
        Assert.Contains(expectedRoot1, roots);
        Assert.Contains(expectedRoot2, roots);
    }
}
