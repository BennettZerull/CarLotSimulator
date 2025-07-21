using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"The {Make} {Model} has an engine noise that sounds like a {EngineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"The {Make} {Model} has an engine noise that sounds like a {HonkNoise}.");
    }

    public Car()
    {
        
    }

    public Car(int year, string make, string model, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        IsDriveable = isDriveable;
    }
}