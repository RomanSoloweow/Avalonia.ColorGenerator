using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.ColorPack;

namespace Avalonia.ColorGenerator
{
    public class ColorGenerator
    {
        private Random Random { get; } = new();
        public int CountColors { get; }
        private IColorsPack ColorsPack { get; }
        /// <summary>
        /// Shuffled list of color indices
        /// </summary>
        private List<int> UniqueIndexes { get; } = new();
        /// <summary>
        /// Current unique color index
        /// </summary>
        private int CurrentUniqueIndexNumber { get; set; }
        
        /// <summary>
        /// Сache of colors
        /// </summary>
        private Dictionary<int, ColorWithValue> ColorsWithValues{ get; } = new();
        /// <summary>
        /// Сache for indexes
        /// </summary>
        private Dictionary<string, int> ColorsIndexByName { get; } = new();
        
        /// <summary>
        /// Reform unique on overflow
        /// </summary>
        public bool ReformUnique{ get; }
        
        /// <summary>
        /// Color Generator
        /// </summary>
        /// <param name="pack">Pack of colors</param>
        /// <param name="reformUnique">Overflow unique value flag: 
        /// True - The list will be reformed.
        /// False - The list will start over.
        /// </param>
        public ColorGenerator(IColorsPack pack = null, bool reformUnique = false)
        {
            ColorsPack = pack ?? new AvaloniaColorPack();
            ReformUnique = reformUnique;
            CountColors = ColorsPack.CountColors();
            FillUniqueValues();
        }

        public ColorWithValue Next()
        {
            var colorIndex =  Random.Next(0, CountColors);
            
            if (!ColorsWithValues.ContainsKey(colorIndex))
            {
                var colorWithHex = ColorsPack.GetColor(colorIndex);
                AddColor(colorWithHex);
            }
            
            return ColorsWithValues[colorIndex];
        }
        
        public ColorWithValue NextUnique()
        {
            if (CurrentUniqueIndexNumber == CountColors)
            {
                if (ReformUnique)
                    FillUniqueValues();
                CurrentUniqueIndexNumber = 0;
            }
               

            int colorIndex = UniqueIndexes[CurrentUniqueIndexNumber];

            CurrentUniqueIndexNumber++;
            
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

        private void AddColor(ColorDefinition color)
        {
            ColorsWithValues[color.Index] = new ColorWithValue(color);
            ColorsIndexByName[color.Name] = color.Index;
        }

        
        //based on answer https://codereview.stackexchange.com/questions/61338/generate-random-numbers-without-repetitions/61372#61372?newreg=1165f83d96ea41b7826d45b2a4621888
        private void FillUniqueValues()
        {
            HashSet<int> candidates = new HashSet<int>();

            // start Count values before Max, and end at Max
            for (int top = CountColors - CountColors; top < CountColors; top++)
            {
                // May strike a duplicate.
                // Need to add +1 to make inclusive generator
                // +1 is safe even for MaxVal Max value because top < Max
                if (!candidates.Add(Random.Next(0, top + 1))) {
                    // collision, add inclusive Max.
                    // which could not possibly have been added before.
                    candidates.Add(top);
                }
            }
            List<int> result = candidates.ToList();

            // shuffle the results because HashSet has messed
            // with the order, and the algorithm does not produce
            // random-ordered results (e.g. Max-1 will never be the first value)
            for (int i = result.Count - 1; i > 0; i--)
            {  
                int k = Random.Next(i + 1);  
                int tmp = result[k];  
                result[k] = result[i];  
                result[i] = tmp;  
            }

            UniqueIndexes.AddRange(result);
        }
        
    }
}