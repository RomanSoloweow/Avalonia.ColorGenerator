using Avalonia.Media;

namespace Avalonia.ColorGenerator
{
    public class ColorWithValue
    {
        public Color Color { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }
        public ColorWithValue(ColorDefinition color)
        {
            Color = Color.Parse(color.Hex);
            Index = color.Index;
            Name = color.Name;
            Hex = color.Hex;
        }
    }
}