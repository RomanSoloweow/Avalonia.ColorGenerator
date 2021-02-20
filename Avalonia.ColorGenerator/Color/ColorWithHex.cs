namespace Avalonia.ColorGenerator
{
    public class ColorWithHex:ColorDefinition
    {
        public string Hex { get; set; }
        
        public ColorWithHex(int index, string name, string hex):base(index, name)
        {
            Hex = hex;
        }
    }
}