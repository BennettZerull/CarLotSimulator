using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var auto in ParkingLot)
        {
            Console.WriteLine($"{auto.Year} {auto.Make} {auto.Model}");
        }
    }
}