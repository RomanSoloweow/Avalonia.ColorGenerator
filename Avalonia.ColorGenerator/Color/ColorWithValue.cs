using Avalonia.Media;

namespace Avalonia.ColorGenerator
{
    public class ColorWithValue:ColorDefinition
    {
        public Color Color { get; set; }
        
        public ColorWithValue(ColorDefinition color):base(color.Index, color.Name, color.Hex)
        {
            Color = Color.Parse(color.Hex);
        }
    }
}