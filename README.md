[![NuGet Pre Release](https://img.shields.io/nuget/vpre/AvaloniaColorGenerator.svg)](https://www.nuget.org/packages/AvaloniaColorGenerator) [![](https://img.shields.io/github/stars/RomanSoloweow/Avalonia.ColorGenerator)](https://github.com/RomanSoloweow/Avalonia.ColorGenerator) [![](https://img.shields.io/github/license/RomanSoloweow/Avalonia.ColorGenerator)](https://github.com/RomanSoloweow/Avalonia.ColorGenerator) [![](https://img.shields.io/github/languages/code-size/RomanSoloweow/Avalonia.ColorGenerator)](https://github.com/RomanSoloweow/Avalonia.ColorGenerator) 
 [![]( https://img.shields.io/github/last-commit/RomanSoloweow/Avalonia.ColorGenerator)](https://github.com/RomanSoloweow/Avalonia.ColorGenerator)
 
# Avalonia.ColorGenerator

Generates a number for choosing a color from a ready set.

Usage [example](https://github.com/RomanSoloweow/DraggableColors) (application with color display)

![](https://github.com/RomanSoloweow/Avalonia.ColorGenerator/blob/master/Example.png)

```C#
 ColorGenerator generator = new();
```
Get random color
```C#
ColorWithValue value = generator.Next();
```
Get random unique color (in case of overflow, the list will start over or be re-formed depending on the flag)
```C#
ColorWithValue value = generator.NextUnique();
```
You can implement your own set of colors for the generator by implementing the interface
```C#
public interface IColorsPack
{
    int CountColors();
    ColorDefinition GetColor(int colorNumber);
    ColorDefinition GetColor(string colorName);
}
```

Fields of color:

- Color - Color for SolidColorBrush or other
- Name - name of current color
- Index - index of current color
- Hex  - Color Hex format


## License📑

Licensed under the [MIT](LICENSE) license.
