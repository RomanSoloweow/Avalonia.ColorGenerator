using System;
using System.Collections.Generic;
using Avalonia.ColorPack;

namespace Avalonia.ColorGenerator
{
    public class ColorGenerator
    {
        private Random Random { get; } = new();
        public int ColorsCount { get; }
        private IColorsPack ColorsPack { get; }
        private Dictionary<int, ColorWithValue> ColorsWithValues{ get; } = new();
        private Dictionary<string, int> ColorsIndexByName { get; } = new();
        
        public ColorGenerator(IColorsPack pack = null)
        {
            ColorsPack = pack ?? new AvaloniaColorPack();
            
            ColorsCount = ColorsPack.GetColorsCount();
        }

        public ColorWithValue Next()
        {
            var colorIndex =  Random.Next(0, ColorsCount);
            
            if (!ColorsWithValues.ContainsKey(colorIndex))
            {
                var colorWithHex = ColorsPack.GetColor(colorIndex);
                AddColor(colorWithHex);
            }
            
            return ColorsWithValues[colorIndex];
        }

        public ColorWithValue GetColor(string colorName)
        {
            if (!ColorsIndexByName.ContainsKey(colorName))
            {
                var colorWithHex = ColorsPack.GetColor(colorName);
                AddColor(colorWithHex);
            }

            var colorIndex = ColorsIndexByName[colorName];
            return ColorsWithValues[colorIndex];
        }
        
        public ColorWithValue GetColor(int colorIndex)
        {   
            if (!ColorsWithValues.ContainsKey(colorIndex))
            {
                var colorWithHex = ColorsPack.GetColor(colorIndex);
                AddColor(colorWithHex);
            }

            return ColorsWithValues[colorIndex]; 
        }

        private void AddColor(ColorWithHex color)
        {
            ColorsWithValues[color.Index] = new ColorWithValue(color);
            ColorsIndexByName[color.Name] = color.Index;
        }
        
    }
}