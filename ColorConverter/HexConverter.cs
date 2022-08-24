namespace DukaSoft.ColorConverter;

public class HexConverter
{
	/// <summary>
	/// Converts a string of Hex to RGBA
	/// </summary>
	/// <param name="HexString">Supports length of 3, 4, 6 or 8</param>
	/// <returns></returns>
	public ConverterReturn ConvertToRGBA(string HexString)
	{
		ConverterReturn ret = new();
		RGBA? Color = null;
		try
		{

			switch (HexString.Length)
			{
				case 3:
					Color = LengthThree(HexString);
					ret.IsSuccess = true;
					break;
				case 4:
					Color = LengthFour(HexString);
					ret.IsSuccess = true;
					break;
				case 6:
					Color = LengthSix(HexString);
					ret.IsSuccess = true;
					break;
				case 8:
					Color = LengthEight(HexString);
					ret.IsSuccess = true;
					break;
				default:
					ret.IsSuccess = false;
					ret.Error = ErrorType.InvalidLength;
					break;
			}
		}
		catch(FormatException)
		{
			ret.Error = ErrorType.InvalidHex;
		}

		if (ret.IsSuccess)
		{
			ret.Error = ErrorType.None;
			ret.Color = Color!;
		}

		return ret;
	}

	/// <summary>
	/// Converts the hex to RGBA
	/// </summary>
	/// <param name="red">The Red Hex</param>
	/// <param name="green">The Green Hex</param>
	/// <param name="blue">The Blue Hex</param>
	/// <param name="alpha">The Alpha Hex</param>
	/// <returns></returns>
	private RGBA RGBAColor(string red, string green, string blue, string alpha)
	{
		RGBA rGBA = new()
		{
			Red = Convert.FromHexString(red)[0],
			Green = Convert.FromHexString(green)[0],
			Blue = Convert.FromHexString(blue)[0],
			Alpha = Convert.FromHexString(alpha)[0]
		};

		rGBA.Alpha /= 255;


		return rGBA;
	}

	/// <summary>
	/// This converts a string of length 3 into RGBA
	/// Alpha is 1 by default
	/// </summary>
	/// <param name="color">The 3 length Hex string</param>
	/// <returns></returns>

	private RGBA LengthThree(string color)
	{
		RGBA ret;

		string Red = color.Substring(0, 1);
		string Green = color.Substring(1, 1);
		string Blue = color.Substring(2, 1);

		Red += Red;
		Green += Green;
		Blue += Blue;
		ret = RGBAColor(Red, Green, Blue, "FF");

		return ret;
	}

	/// <summary>
	/// This converts a string of length 4 into RGBA
	/// </summary>
	/// <param name="color">The 4 length Hex string</param>
	/// <returns></returns>
	private RGBA LengthFour(string color)
	{
		RGBA ret;

		string Red = color.Substring(0, 1);
		string Green = color.Substring(1, 1);
		string Blue = color.Substring(2, 1);
		string Alpha = color.Substring(3, 1);

		Red += Red;
		Green += Green;
		Blue += Blue;
		Alpha += Alpha;
		ret = RGBAColor(Red, Green, Blue, Alpha);

		return ret;
	}

	/// <summary>
	/// This converts a string of length 6 into RGBA
	/// Alpha is 1 by default
	/// </summary>
	/// <param name="color">The 6 length Hex string</param>
	/// <returns></returns>

	private RGBA LengthSix(string color)
	{
		RGBA ret;

		string Red = color.Substring(0, 2);
		string Green = color.Substring(2, 2);
		string Blue = color.Substring(4, 2);

		Red += Red;
		Green += Green;
		Blue += Blue;

		ret = RGBAColor(Red, Green, Blue, "FF");

		return ret;
	}

	/// <summary>
	/// This converts a string of length 8 into RGBA
	/// </summary>
	/// <param name="color">The 8 length Hex string</param>
	/// <returns></returns>

	private RGBA LengthEight(string color)
	{
		RGBA ret;

		string Red = color.Substring(0, 2);
		string Green = color.Substring(2, 2);
		string Blue = color.Substring(4, 2);
		string Alpha = color.Substring(6, 2);

		ret = RGBAColor(Red, Green, Blue, Alpha);

		return ret;
	}
}
