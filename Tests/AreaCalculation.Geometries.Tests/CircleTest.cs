using System.Reflection;
namespace AreaCalculation.Geometriesries.Tests;

public class CircleTest {

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void InvalidParameters(double radius) {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(66.3)]
    public void Area(double radius) {
        IShape c = new Circle(radius);
        Assert.Equal(c.Area, Math.PI * Math.Pow(radius, 2));
    }
}