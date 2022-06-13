using System.Globalization;
using System.Drawing;

namespace ColorConverterApp
{
	public static class ColorConverter
	{
		public static Color ConvertToRGBA(string Hex)
		{
			Color myColor;

			if (int.TryParse(Hex, NumberStyles.HexNumber, default, out _) == false)
			{
				throw new Exception($"{nameof(Hex)} value is not Hex");
			}

			switch (Hex.Length){
				case 3:
					myColor = ThreeLengthHex(Hex);
					break;

				case 4:
					myColor = FourLengthHex(Hex);
					break;

				case 6:
					myColor = SixLengthHex(Hex);
					break;
					
				case 8:
					myColor = EightLengthHex(Hex);
						break;

				default:
					throw new Exception($"{nameof(Hex)} value is invalid");

			}

			return myColor;
		}

		private static Color ThreeLengthHex(string Hex)
		{
			var myColor = Color.FromArgb(
				255,
				int.Parse(Hex.Substring(0, 1) + Hex.Substring(0, 1), NumberStyles.HexNumber),
				int.Parse(Hex.Substring(1, 1) + Hex.Substring(1, 1), NumberStyles.HexNumber),
				int.Parse(Hex.Substring(2, 1) + Hex.Substring(2, 1), NumberStyles.HexNumber));

			return myColor;
		}

		private static Color FourLengthHex(string Hex)
		{
			Hex = Hex.Substring(3, 1) + Hex.Substring(0, 3);
			var myColor = Color.FromArgb(
				int.Parse(Hex.Substring(0, 1) + Hex.Substring(0, 1), NumberStyles.HexNumber),
				int.Parse(Hex.Substring(1, 1) + Hex.Substring(1, 1), NumberStyles.HexNumber),
				int.Parse(Hex.Substring(2, 1) + Hex.Substring(2, 1), NumberStyles.HexNumber),
				int.Parse(Hex.Substring(3, 1) + Hex.Substring(3, 1), NumberStyles.HexNumber));

			return myColor;
		}

		private static Color SixLengthHex(string Hex)
		{
			var col = int.Parse(Hex, NumberStyles.HexNumber);
			var myColor = Color.FromArgb(col);
			myColor = Color.FromArgb(255, myColor.R, myColor.G, myColor.B);

			return myColor;
		}

		private static Color EightLengthHex(string Hex)
		{
			Hex = Hex.Substring(6, 2) + Hex.Substring(0, 6);
			var col = int.Parse(Hex, NumberStyles.HexNumber);
			var myColor = Color.FromArgb(col);

			return myColor;
		}
	}
}
