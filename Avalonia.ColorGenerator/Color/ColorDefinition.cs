namespace Avalonia.ColorGenerator
{
    public abstract class ColorDefinition
    {
        public ColorDefinition(int index, string name)
        {
            Index = index;
            Name = name;
        }
        
        public int Index { get; set; }
        public string Name { get; set; }
    }
}