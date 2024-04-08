namespace Task1;

public class Circle : Figure
{
	public double Radius { get; set; }

	public Circle(double radius)
	{
		Radius = radius;
	}



	public override double Area()
	{
		return Math.PI * Radius * Radius;
	}
}
