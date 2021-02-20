namespace Avalonia.ColorGenerator
{
    public interface IColorsPack
    {
        int GetColorsCount();
        ColorWithHex GetColor(int colorNumber);
        ColorWithHex GetColor(string colorName);
    }
}