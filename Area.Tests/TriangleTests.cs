
namespace Area.Tests
{
	[TestFixture]
	public class TriangleTests
	{
		[Test]
		public void CalculateAreaValidSidesReturnsCorrectArea()
		{
			Triangle triangle = new Triangle(3, 4, 5);
			double expectedArea = 6;

			double actualArea = triangle.CalculateArea();

			Assert.That(actualArea, Is.EqualTo(expectedArea));
		}

		[Test]
		public void ConstructorNegativeSideThrowsArgumentException()
		{
			Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
		}

		[Test]
		public void ConstructorInvalidTriangleThrowsArgumentException()
		{
			Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 4));
		}

		[Test]
		public void IsRightAngledRightTriangleReturnsTrue()
		{
			Triangle triangle = new Triangle(3, 4, 5);

			Assert.That(triangle.IsRightAngled(), Is.True);
		}

		[Test]
		public void IsRightAngledNotRightTriangleReturnsFalse()
		{
			Triangle triangle = new Triangle(3, 3, 3);

			Assert.That(triangle.IsRightAngled, Is.False);
		}
	}
}

