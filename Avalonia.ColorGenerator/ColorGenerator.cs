using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Media;
using Metsys.Bson;

namespace Avalonia.ColorGenerator
{
    public static class ColorGenerator
    {
        public static void Init()
        {
            HelperColors.Init(); 
        }
        
        static Random Random { get; set; } = new();
        
        public static Color Next()
        {
           var colorNumber =  Random.Next(0, HelperColors.ColorsUint.Count + 1);
           var uintValue = HelperColors.ColorsUint[(KnownColor) colorNumber];
           
           return Color.FromUInt32(uintValue);
        }
    }
}