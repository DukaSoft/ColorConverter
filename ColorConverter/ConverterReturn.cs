namespace DukaSoft.ColorConverter;

public class ConverterReturn
{
	public bool IsSuccess { get; internal set; } = false;
	public ErrorType Error { get; internal set; }

	public RGBA Color { get; internal set; } = new RGBA();

}

public enum ErrorType
{
	None,
	InvalidHex,
	InvalidLength
}