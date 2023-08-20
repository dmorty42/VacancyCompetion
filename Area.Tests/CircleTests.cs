
namespace Area.Tests
{
	[TestFixture]
	public class CircleTests
	{
		[Test]
		public void CalculateAreaWithValidRadiusReturnsCorrectArea()
		{
			Circle circle = new Circle(5);
			double expectedArea = Math.PI * 5 * 5;

			double actualArea = circle.CalculateArea();

			Assert.That(actualArea, Is.EqualTo(expectedArea));
 		}

		[Test]
		public void ConstructorNegativeRadiusThrowsArgumentException()
		{
			Assert.Throws<ArgumentException>(() => new Circle(-1));
		}

		[Test]
		public void ZeroRadiusCreateCircleReturncCorrectArea()
		{
			Circle circle = new Circle(0);

			Assert.That(circle.CalculateArea(), Is.EqualTo(0));
		}
	}
}

