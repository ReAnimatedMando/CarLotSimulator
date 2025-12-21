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
            var carLotOne = new CarLot();

            Console.WriteLine($"Cars created: {CarLot._numberOfCars}"); // wrote to console, when a car is incremented in CarLot
            
            var car1 = new Car();
            
            car1.Year = 1967;
            car1.Make = "Ford";
            car1.Model = "Shelby GT500 Mustang";
            car1.MakeEngineNoise( "Vroom!");
            car1.MakeHonkNoise( "Beep!");
            car1.IsDriveable = true;
            
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}"); // wrote to console, when a car is incremented in CarLot

            carLotOne.ParkingLot.Add(car1);

            var car2 = new Car()
            {
                Year = 1982,
                Make = "DeLorean Motor Company",
                Model = "DMC-12",
                IsDriveable = false
            };

            car2.MakeEngineNoise("Swoosh!");
            car2.MakeHonkNoise("Great Scott!");
            
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}"); // wrote to console, when a car is incremented in CarLot
            
            carLotOne.ParkingLot.Add(car2);
            
            var car3 = new Car( 1955, "Lincoln", "Futura",true);

            car3.MakeEngineNoise("du nu nu nu nu nu nu nu!");
            car3.MakeHonkNoise("Batman!");
            
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}"); // wrote to console, when a car is incremented in CarLot
            
            carLotOne.ParkingLot.Add(car3);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLotOne.CheckCars();
        }
    }
}
