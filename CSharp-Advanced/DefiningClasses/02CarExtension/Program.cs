﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(2, 2.2),
                new Tire(2, 2.2),
                new Tire(2, 2.2),
            };
            var engine = new Engine(560, 6300);

            var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);
            Console.WriteLine($"{car.Model} {car.Make} {car.Year} {car.FuelConsumption} {car.FuelQuantity}" +
                $"{car.Engine} {car.Tires}");
        }
    }
}