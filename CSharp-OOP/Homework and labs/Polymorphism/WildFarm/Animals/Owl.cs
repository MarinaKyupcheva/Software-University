﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        private const double BaseWeightModifier = 0.25;
        private static HashSet<string> OwlAllowedFoods = new HashSet<string>
        {
            nameof(Meat),
           
        };
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize, OwlAllowedFoods, BaseWeightModifier)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
