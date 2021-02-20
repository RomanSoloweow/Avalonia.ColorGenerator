using Avalonia.Media;

namespace Avalonia.ColorGenerator
{
    public class ColorWithValue:ColorDefinition
    {
        public Color Color { get; set; }

        public ColorWithValue(int index, string name, Color color):base(index, name)
        {
            Color = color;
        }
        public ColorWithValue(ColorWithHex color):base(color.Index, color.Name)
        {
            Color = Color.Parse(color.Hex);
        }
    }
}