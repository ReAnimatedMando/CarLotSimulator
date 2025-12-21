using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();
    public static int _numberOfCars = 0; // created field to hold number of cars in CarLot

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"My {vehicle.Year}, {vehicle.Make}, {vehicle.Model} goes {vehicle.EngineNoise} {vehicle.HonkNoise}");
        }
    }
}