# ColorConverter

## Converts a Hex Color to RGBA

### Supported formats:
- FFF
- FFFF
- FFFFFF
- FFFFFFFF

### How to:
```
using DukaSoft.ColorConverter;

string HexString = "FFF";

HexConverter converter = new();

var result = converter.ConvertToRGBA(HexString);

if (result.IsSuccess)
{
	Console.WriteLine(result.Color.ToString());
}
else
{
	switch (result.Error)
	{
		case ErrorType.None:
			break;
		case ErrorType.InvalidHex:
			Console.WriteLine("The string is not a hex code!");
			break;
		case ErrorType.InvalidLength:
			Console.WriteLine("The length of the string is invalid!");
			break;
	}
}

```

## This is just a learning project
Feel free to use and/or change
