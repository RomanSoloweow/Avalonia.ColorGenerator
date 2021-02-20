using System.Collections.Generic;
using Avalonia.ColorGenerator;

namespace Avalonia.ColorPack
{
    public class AvaloniaColorPack:IColorsPack
    {
        private static readonly Dictionary<KnownColor, string> Colors = new()
        {
            {KnownColor.Black, "#000000"},
            {KnownColor.Navy, "#000080"},
            {KnownColor.DarkBlue, "#00008B"},
            {KnownColor.MediumBlue, "#0000CD"},
            {KnownColor.Blue, "#0000FF"},
            {KnownColor.DarkGreen, "#006400"},
            {KnownColor.Green, "#008000"},
            {KnownColor.Teal, "#008080"},
            {KnownColor.DarkCyan, "#008B8B"},
            {KnownColor.DeepSkyBlue, "#00BFFF"},
            {KnownColor.DarkTurquoise, "#00CED1"},
            {KnownColor.MediumSpringGreen, "#00FA9A"},
            {KnownColor.Lime, "#00FF00"},
            {KnownColor.SpringGreen, "#00FF7F"},
            {KnownColor.Aqua, "#00FFFF"},
            {KnownColor.Cyan, "#00FFFF"},
            {KnownColor.MidnightBlue, "#191970"},
            {KnownColor.DodgerBlue, "#1E90FF"},
            {KnownColor.LightSeaGreen, "#20B2AA"},
            {KnownColor.ForestGreen, "#228B22"},
            {KnownColor.SeaGreen, "#2E8B57"},
            {KnownColor.DarkSlateGray, "#2F4F4F"},
            {KnownColor.LimeGreen, "#32CD32"},
            {KnownColor.MediumSeaGreen, "#3CB371"},
            {KnownColor.Turquoise, "#40E0D0"},
            {KnownColor.RoyalBlue, "#4169E1"},
            {KnownColor.SteelBlue, "#4682B4"},
            {KnownColor.DarkSlateBlue, "#483D8B"},
            {KnownColor.MediumTurquoise, "#48D1CC"},
            {KnownColor.Indigo, "#4B0082"},
            {KnownColor.DarkOliveGreen, "#556B2F"},
            {KnownColor.CadetBlue, "#5F9EA0"},
            {KnownColor.CornflowerBlue, "#6495ED"},
            {KnownColor.MediumAquamarine, "#66CDAA"},
            {KnownColor.DimGray, "#696969"},
            {KnownColor.SlateBlue, "#6A5ACD"},
            {KnownColor.OliveDrab, "#6B8E23"},
            {KnownColor.SlateGray, "#708090"},
            {KnownColor.LightSlateGray, "#778899"},
            {KnownColor.MediumSlateBlue, "#7B68EE"},
            {KnownColor.LawnGreen, "#7CFC00"},
            {KnownColor.Chartreuse, "#7FFF00"},
            {KnownColor.Aquamarine, "#7FFFD4"},
            {KnownColor.Maroon, "#800000"},
            {KnownColor.Purple, "#800080"},
            {KnownColor.Olive, "#808000"},
            {KnownColor.Gray, "#808080"},
            {KnownColor.SkyBlue, "#87CEEB"},
            {KnownColor.LightSkyBlue, "#87CEFA"},
            {KnownColor.BlueViolet, "#8A2BE2"},
            {KnownColor.DarkRed, "#8B0000"},
            {KnownColor.DarkMagenta, "#8B008B"},
            {KnownColor.SaddleBrown, "#8B4513"},
            {KnownColor.DarkSeaGreen, "#8FBC8F"},
            {KnownColor.LightGreen, "#90EE90"},
            {KnownColor.MediumPurple, "#9370DB"},
            {KnownColor.DarkViolet, "#9400D3"},
            {KnownColor.PaleGreen, "#98FB98"},
            {KnownColor.DarkOrchid, "#9932CC"},
            {KnownColor.YellowGreen, "#9ACD32"},
            {KnownColor.Sienna, "#A0522D"},
            {KnownColor.Brown, "#A52A2A"},
            {KnownColor.DarkGray, "#A9A9A9"},
            {KnownColor.LightBlue, "#ADD8E6"},
            {KnownColor.GreenYellow, "#ADFF2F"},
            {KnownColor.PaleTurquoise, "#AFEEEE"},
            {KnownColor.LightSteelBlue, "#B0C4DE"},
            {KnownColor.PowderBlue, "#B0E0E6"},
            {KnownColor.Firebrick, "#B22222"},
            {KnownColor.DarkGoldenrod, "#B8860B"},
            {KnownColor.MediumOrchid, "#BA55D3"},
            {KnownColor.RosyBrown, "#BC8F8F"},
            {KnownColor.DarkKhaki, "#BDB76B"},
            {KnownColor.Silver, "#C0C0C0"},
            {KnownColor.MediumVioletRed, "#C71585"},
            {KnownColor.IndianRed, "#CD5C5C"},
            {KnownColor.Peru, "#CD853F"},
            {KnownColor.Chocolate, "#D2691E"},
            {KnownColor.Tan, "#D2B48C"},
            {KnownColor.LightGray, "#D3D3D3"},
            {KnownColor.Thistle, "#D8BFD8"},
            {KnownColor.Orchid, "#DA70D6"},
            {KnownColor.Goldenrod, "#DAA520"},
            {KnownColor.PaleVioletRed, "#DB7093"},
            {KnownColor.Crimson, "#DC143C"},
            {KnownColor.Gainsboro, "#DCDCDC"},
            {KnownColor.Plum, "#DDA0DD"},
            {KnownColor.BurlyWood, "#DEB887"},
            {KnownColor.LightCyan, "#E0FFFF"},
            {KnownColor.Lavender, "#E6E6FA"},
            {KnownColor.DarkSalmon, "#E9967A"},
            {KnownColor.Violet, "#EE82EE"},
            {KnownColor.PaleGoldenrod, "#EEE8AA"},
            {KnownColor.LightCoral, "#F08080"},
            {KnownColor.Khaki, "#F0E68C"},
            {KnownColor.AliceBlue, "#F0F8FF"},
            {KnownColor.Honeydew, "#F0FFF0"},
            {KnownColor.Azure, "#F0FFFF"},
            {KnownColor.SandyBrown, "#F4A460"},
            {KnownColor.Wheat, "#F5DEB3"},
            {KnownColor.Beige, "#F5F5DC"},
            {KnownColor.WhiteSmoke, "#F5F5F5"},
            {KnownColor.MintCream, "#F5FFFA"},
            {KnownColor.GhostWhite, "#F8F8FF"},
            {KnownColor.Salmon, "#FA8072"},
            {KnownColor.AntiqueWhite, "#FAEBD7"},
            {KnownColor.Linen, "#FAF0E6"},
            {KnownColor.LightGoldenrodYellow, "#FAFAD2"},
            {KnownColor.OldLace, "#FDF5E6"},
            {KnownColor.Red, "#FF0000"},
            {KnownColor.Fuchsia, "#FF00FF"},
            {KnownColor.Magenta, "#FF00FF"},
            {KnownColor.DeepPink, "#FF1493"},
            {KnownColor.OrangeRed, "#FF4500"},
            {KnownColor.Tomato, "#FF6347"},
            {KnownColor.HotPink, "#FF69B4"},
            {KnownColor.Coral, "#FF7F50"},
            {KnownColor.DarkOrange, "#FF8C00"},
            {KnownColor.LightSalmon, "#FFA07A"},
            {KnownColor.Orange, "#FFA500"},
            {KnownColor.LightPink, "#FFB6C1"},
            {KnownColor.Pink, "#FFC0CB"},
            {KnownColor.Gold, "#FFD700"},
            {KnownColor.PeachPuff, "#FFDAB9"},
            {KnownColor.NavajoWhite, "#FFDEAD"},
            {KnownColor.Moccasin, "#FFE4B5"},
            {KnownColor.Bisque, "#FFE4C4"},
            {KnownColor.MistyRose, "#FFE4E1"},
            {KnownColor.BlanchedAlmond, "#FFEBCD"},
            {KnownColor.PapayaWhip, "#FFEFD5"},
            {KnownColor.LavenderBlush, "#FFF0F5"},
            {KnownColor.SeaShell, "#FFF5EE"},
            {KnownColor.Cornsilk, "#FFF8DC"},
            {KnownColor.LemonChiffon, "#FFFACD"},
            {KnownColor.FloralWhite, "#FFFAF0"},
            {KnownColor.Snow, "#FFFAFA"},
            {KnownColor.Yellow, "#FFFF00"},
            {KnownColor.LightYellow, "#FFFFE0"},
            {KnownColor.Ivory, "#FFFFF0"},
            {KnownColor.White, "#FFFFFF"}
        };
            
        public int GetColorsCount()
        {
            return Colors.Count;
        }

        public ColorWithHex GetColor(int index)
        {
            var colorEnum = (KnownColor)index;
            var hex = Colors[colorEnum];

            return new ColorWithHex(index, colorEnum.ToString(), hex);
        }

        public ColorWithHex GetColor(string colorName)
        {
            if (!KnownColor.TryParse(colorName, out KnownColor colorEnum)) return null;
            var hex = Colors[colorEnum];

            return new ColorWithHex((int)colorEnum, colorEnum.ToString(), hex);

        }
    }
}