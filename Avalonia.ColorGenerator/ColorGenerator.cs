﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<int> UniqueIndexes { get; } = new();
        private int CurrentUniqueIndexNumber { get; set; }
        
        /// <summary>
        /// Reform unique on overflow
        /// </summary>
        public bool ReformUnique{ get; }
        public ColorGenerator(IColorsPack pack = null, bool reformUnique = false)
        {
            ColorsPack = pack ?? new AvaloniaColorPack();
            ReformUnique = reformUnique;
            ColorsCount = ColorsPack.GetColorsCount();
            FillUniqueValues();
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
        
        public ColorWithValue NextUnique()
        {
            if (CurrentUniqueIndexNumber == ColorsCount)
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
            for (int top = ColorsCount - ColorsCount; top < ColorsCount; top++)
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