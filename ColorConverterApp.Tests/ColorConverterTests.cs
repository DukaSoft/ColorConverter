
namespace ColorConverterApp.Tests
{
	public class ColorConverterTests
	{
		[Theory]
		[InlineData("fff")]
		public void ConvertThreeLengthHex(string Hex)
		{
			//Arrange
			Color myColor;

			//Act
			myColor = ColorConverter.ConvertToRGBA(Hex);

			//Assert
			Color ExpectedColor = Color.FromArgb(255,255,255,255);
			Assert.Equal(ExpectedColor, myColor);
		}

		[Theory]
		[InlineData("ffff")]
		public void ConvertFourLengthHex(string Hex)
		{
			//Arrange
			Color myColor;

			//Act
			myColor = ColorConverter.ConvertToRGBA(Hex);

			//Assert
			Color ExpectedColor = Color.FromArgb(255, 255, 255, 255);
			Assert.Equal(ExpectedColor, myColor);
		}

		[Theory]
		[InlineData("ffffff")]
		public void ConvertSixLengthHex(string Hex)
		{
			//Arrange
			Color myColor;

			//Act
			myColor = ColorConverter.ConvertToRGBA(Hex);

			//Assert
			Color ExpectedColor = Color.FromArgb(255, 255, 255, 255);
			Assert.Equal(ExpectedColor, myColor);
		}

		[Theory]
		[InlineData("ffffffff")]
		public void ConvertEightLengthHex(string Hex)
		{
			//Arrange
			Color myColor;

			//Act
			myColor = ColorConverter.ConvertToRGBA(Hex);

			//Assert
			Color ExpectedColor = Color.FromArgb(255, 255, 255, 255);
			Assert.Equal(ExpectedColor, myColor);
		}
	}
}