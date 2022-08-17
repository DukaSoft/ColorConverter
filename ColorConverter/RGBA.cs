namespace DukaSoft.ColorConverter;

public class RGBA
{
	public int Red { get; internal set; }
	public int Green { get; internal set; }
	public int Blue { get; internal set; }
	public float Alpha { get; internal set; }

	public override string ToString()
	{
		string color = "Red: " + Red.ToString()
			+ "\nGreen: " + Green.ToString()
			+ "\nBlue: " + Blue.ToString()
			+ "\nAlpha: " + Alpha.ToString();

		return color;
	}
}
