namespace AreaCalculation.Geometries {
    public abstract class Shape : IShape {
        protected double? area;
        public double Area { get => area == null ? GetArea() : area.Value; }
        public ShapeType Type { get; }

        public Shape(ShapeType type) {
            Type = type;
        }

        private double GetArea() {
            if (area.HasValue)
                return area.Value;

            area = CalculateArea();
            return area.Value;
        }
        protected abstract double CalculateArea();
    }
}