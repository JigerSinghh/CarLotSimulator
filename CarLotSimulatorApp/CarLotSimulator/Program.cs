using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            

            var jigerCar = new Car();
            jigerCar.Year = 2020;
            jigerCar.Make = "Dodge";
            jigerCar.Model = "ScatPack";
            jigerCar.EngineNoise = "VROOOOM";
            jigerCar.HonkNoise = "BEEPBEEP";
            jigerCar.IsDriveable = true;



            var simritsCar = new Car()
            {
                Year = 2017,
                Make = "Mercedes",
                Model = "C300",
                EngineNoise = "nothing",
                HonkNoise = "peep",
                IsDriveable = true,
            };

            var amandeepCar = new Car(2009, "Toyota", "Avalon", "nada", "peepbeep", true);

            jigerCar.MakeEngineNoise();
            simritsCar.MakeEngineNoise();
            amandeepCar.MakeEngineNoise();

            
            
            

            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            //Call each of the methods for each car

            
        }
    }
}
