namespace AreaCalculation.Geometries.Shapes {
    public class Triangle : Shape {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool Simple { get; }

        private double? perimeter;
        public double Perimeter { get => perimeter == null ? GetPerimeter() : perimeter.Value; }

        private bool? rectangular;
        public bool IsRectangular { get => rectangular == null ? GetRectangular() : rectangular.Value; }
        
        public Triangle(double sideA, double sideB, double sideC) : base(ShapeType.Triangle) {
            if (sideA == 0 || sideA < 0)
                throw new ArgumentException("Side cannot be zero or less", "sideA");
            if (sideB == 0 || sideB < 0) 
                throw new ArgumentException("Side cannot be zero or less", "sideB");
            if (sideC == 0 || sideC < 0) 
                throw new ArgumentException("Side cannot be zero or less", "sideC");

            var notExists = 
                sideA + sideB < sideC 
                || sideB + sideC < sideA 
                || sideC + sideA < sideB;

            if (notExists)
                throw new ArgumentException("Triangle does not exists");
                
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            Simple = SideA == SideB && SideA == SideC;
        }

        private double GetPerimeter() {
            if (perimeter.HasValue)
                return perimeter.Value;

            perimeter = SideA + SideB + SideC;
            return perimeter.Value;
        }

        private bool GetRectangular() {
            if (rectangular.HasValue)
                return rectangular.Value;

            rectangular = false;
            if (!Simple) {
                double calcHypotenuse(double c1, double c2) 
                    => Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));

                rectangular = 
                    calcHypotenuse(SideB, SideC) == SideA
                    ||  calcHypotenuse(SideA, SideC) == SideB
                    ||  calcHypotenuse(SideB, SideA) == SideC;
            }

            return rectangular.Value;
        }

        protected override double CalculateArea() {
            var halfPart = Perimeter / 2;
            return Math.Sqrt(halfPart * (halfPart - SideA) * (halfPart - SideB) * (halfPart - SideC));
        }
    }
}