using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }

        public int Year { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public String EngineNoise { get; set; }
        public String HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
