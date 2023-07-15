namespace AreaCalculation.Geometries.Shapes {
    public class Circle : Shape {
        public double Radius { get; }
        public Circle(double radius) : base(ShapeType.Circle) {
            if (radius == 0 || radius < 0)
                throw new ArgumentException("Raduis cannot be zero or less", "radius");

            Radius = radius;
        }

        protected override double CalculateArea() {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}