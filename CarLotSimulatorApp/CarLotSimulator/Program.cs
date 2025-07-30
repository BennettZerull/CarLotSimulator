using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carLotOne = new CarLot();
            
            var carOne = new Car();
            carOne.Year = 1942;
            carOne.Make = "Ford";
            carOne.Model = "Jalopy";
            carOne.IsDriveable = false;
            
            carOne.MakeEngineNoise("THUD THUD THUD");
            carOne.MakeHonkNoise("CHAWOOGAH");
            
            carLotOne.ParkingLot.Add(carOne);
            Console.WriteLine($"The Current Number of Cars on the lot is: {CarLot.NumberOfCars}");

            var carTwo = new Car()
            {
                Year = 2025,
                Make = "Tesla",
                Model = "Cybertruck",
                IsDriveable = true,
            };
            
            carLotOne.ParkingLot.Add(carTwo);
            
            carTwo.MakeEngineNoise("vacuum");
            carTwo.MakeHonkNoise("clown car");
            Console.WriteLine($"The Current Number of Cars on the lot is: {CarLot.NumberOfCars}");

            var carThree = new Car(2020, "Hyundai", "Elantra", true);
            
            carThree.MakeEngineNoise("verrrr");
            carThree.MakeHonkNoise("beep beep");
            
            carLotOne.ParkingLot.Add(carThree);
            Console.WriteLine($"The Current Number of Cars on the lot is: {CarLot.NumberOfCars}");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotOne.CheckCars();
        }
    }
}
