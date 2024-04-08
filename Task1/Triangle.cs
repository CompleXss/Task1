namespace Task1;

public class Triangle : Figure
{
	public double Side1 { get; set; }
	public double Side2 { get; set; }
	public double Side3 { get; set; }

	public Triangle(double side1, double side2, double side3)
	{
		Side1 = side1;
		Side2 = side2;
		Side3 = side3;
	}



	public override double Area()
	{
		double halfPerimeter = (Side1 + Side2 + Side3) / 2;
		double a = halfPerimeter - Side1;
		double b = halfPerimeter - Side2;
		double c = halfPerimeter - Side3;

		return Math.Sqrt(halfPerimeter * a * b * c);
	}

	public bool IsRectangular()
	{
		double side1Squared = Side1 * Side1;
		double side2Squared = Side2 * Side2;
		double side3Squared = Side3 * Side3;

		double sum = side1Squared + side2Squared + side3Squared;
		double maxSide = Math.Max(Math.Max(side1Squared, side2Squared), side3Squared);

		return maxSide == (sum - maxSide); // c^2 == a^2 + b^2
	}
}
