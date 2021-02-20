namespace Avalonia.ColorGenerator
{
    public interface IColorsPack
    {
        int GetColorsCount();
        ColorDefinition GetColor(int colorNumber);
        ColorDefinition GetColor(string colorName);
    }
}