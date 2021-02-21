# Avalonia.ColorGenerator
 - Generates a number for choosing a color from a ready set.

Usage example(application with color display)
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

Copyright (c) GMIKE

Licensed under the [MIT](LICENSE) license.
