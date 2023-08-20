
namespace Area
{
	public class Circle : IShape
	{
        public double Radius { get; set; }

		public Circle(double radius)
		{
            if (radius < 0)
                throw new ArgumentException("Radius cannot be negative", nameof(radius));
            Radius = radius;
		}

        public double CalculateArea()
        {
            return (Math.PI * Radius * Radius);
        }
    }
}

