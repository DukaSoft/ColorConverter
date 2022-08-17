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

string HexString = "FFFFFFFF";
HexConverter converter = new();

var result = converter.ConvertToRGBA(HexString);

if (result.IsSuccess)
{
	Console.WriteLine(result.Color.ToString());
}
else
{
	Console.WriteLine("Something went wrong!");
}
```

## This is just a learning project
Feel free to use and/or change
