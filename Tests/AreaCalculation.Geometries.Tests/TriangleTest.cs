namespace AreaCalculation.Geometriesries.Tests;

public class TriangleTest {
    
    [Theory]
    [InlineData(0, 1, 2)]
    [InlineData(0, 0, 0)]
    [InlineData(10, 2, 3)]
    [InlineData(-1, 2, 3)]
    public void InvalidCreating(double sideA, double sideB, double sideC) {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 10, 15)]
    public void Creating(double sideA, double sideB, double sideC) {
        Assert.NotNull(new Triangle(sideA, sideB, sideC));
    }
    
    [Fact]
    public void Area() {
        IShape t = new Triangle(3, 4, 5);
        Assert.Equal(t.Area, 6);
    }
    
    [Fact]
    public void Rectangular() {
        var t = new Triangle(3, 4, 5);
        Assert.True(t.IsRectangular);
    }
}
