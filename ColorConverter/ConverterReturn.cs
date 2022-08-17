namespace DukaSoft.ColorConverter;

public class ConverterReturn
{
	public bool IsSuccess { get; internal set; } = false;

	public RGBA Color { get; internal set; } = new RGBA();

}