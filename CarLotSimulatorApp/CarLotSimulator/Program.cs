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
            var carLot = new CarLot();
            var car1 = new Car();

            car1.Year = 2016;
            car1.Make = "Dodge";
            car1.Model = "Charger";
            car1.EngineNoise = "vroom";
            car1.HonkNoise = "beep";
            car1.IsDriveable = true;

            carLot.ListOfCars.Add(car1);
            Console.WriteLine($"The current number of cars is {CarLot.numberOfCars}");

            var car2 = new Car()
            {
                Year = 2010,
                Make = "Ford",
                Model = "Fusion",
                EngineNoise = "vroooooom",
                HonkNoise = "bleep",
                IsDriveable = true,
            };
            carLot.ListOfCars.Add(car2);
            Console.WriteLine($"The current number of cars is {CarLot.numberOfCars}");

            var car3 = new Car(2020, "Toyota", "Camry", "Vroom", "Beep", true);
            carLot.ListOfCars.Add(car3);
            Console.WriteLine($"The current number of cars is {CarLot.numberOfCars}");

            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);

            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
        }
    }
}
