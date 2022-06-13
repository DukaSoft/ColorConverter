using ColorConverterApp;

string hexValue = "fff5";
Console.WriteLine($"Hex Color: 'RGB/A' {hexValue}\n");

var myColor = ColorConverter.ConvertToRGBA(hexValue);

Console.WriteLine("// If you need alpha to be between 0 and 1");
string Alpha = ((decimal)myColor.A / 255).ToString("0.##");
Console.WriteLine("Red: " + myColor.R + ", Green:" + myColor.G + ", Blue:" + myColor.B + ", Alpha:" + Alpha);

Console.WriteLine("\n// otherwise just use myColor.A");
Console.WriteLine("Red: " + myColor.R + ", Green:" + myColor.G + ", Blue:" + myColor.B + ", Alpha:" + myColor.A);