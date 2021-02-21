namespace Avalonia.ColorGenerator
{
    public interface IColorsPack
    {
        int CountColors();
        ColorDefinition GetColor(int colorNumber);
        ColorDefinition GetColor(string colorName);
    }
}