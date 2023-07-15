namespace AreaCalculation.Geometries {
    public interface IShape { 
        double Area { get; }
        ShapeType Type { get; }
    }
}