
namespace Area
{
	public class Triangle : IShape
	{
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
		{
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides of triangle must positive");
            if (a + b <= c || b + c <= a || a + c <= b)
                throw new ArgumentException("The provided sides do not form a valid triangle");
            A = a;
            B = b;
            C = c;
		}

        public double CalculateArea()
        {
            var s = (A + B + C) / 2.0;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRightAngled()
        {
            var sides = new double[] { A, B, C };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2); 
        }
    }
}

