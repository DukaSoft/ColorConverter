namespace ColorConverter.Tests
{
	public class HexConverterTest
	{
		[Theory]
		[InlineData("FFF")]
		public void HexConverter_3LengthHexString_ShouldReturnSuccessfully(string HexColor)
		{
			// Arrange
			HexConverter hexConverter = new();

			// Act
			ConverterReturn cr = hexConverter.ConvertToRGBA(HexColor);

			// Assert
			Assert.True(cr.IsSuccess);

		}

		[Theory]
		[InlineData("FFFF")]
		public void HexConverter_4LengthHexString_ShouldReturnSuccessfully(string HexColor)
		{
			// Arrange
			HexConverter hexConverter = new();

			// Act
			ConverterReturn cr = hexConverter.ConvertToRGBA(HexColor);

			// Assert
			Assert.True(cr.IsSuccess);

		}

		[Theory]
		[InlineData("FFFFFF")]
		public void HexConverter_6LengthHexString_ShouldReturnSuccessfully(string HexColor)
		{
			// Arrange
			HexConverter hexConverter = new();

			// Act
			ConverterReturn cr = hexConverter.ConvertToRGBA(HexColor);

			// Assert
			Assert.True(cr.IsSuccess);

		}

		[Theory]
		[InlineData("FFFFFFFF")]
		public void HexConverter_8LengthHexString_ShouldReturnSuccessfully(string HexColor)
		{
			// Arrange
			HexConverter hexConverter = new();

			// Act
			ConverterReturn cr = hexConverter.ConvertToRGBA(HexColor);

			// Assert
			Assert.True(cr.IsSuccess);

		}
	}
}