﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsuption { get; set; }

        public void Drive (double distance)
        {
            
            double fuelDC = distance * FuelConsuption;
            if (FuelQuantity - fuelDC >= 0)
            {
                 FuelConsuption -= fuelDC;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel:" +
                 $" {this.Model}\nYear: {this.Year}\nFuel:{this.FuelQuantity:F2}L";
        }
    }
    
}
