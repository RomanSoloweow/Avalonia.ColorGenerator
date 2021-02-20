namespace Avalonia.ColorGenerator
{
    public class ColorDefinition
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }
        public ColorDefinition(int index, string name, string hex)
        {
            Index = index;
            Name = name;
            Hex = hex;
        }
    }
}