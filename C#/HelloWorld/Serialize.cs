using System.Text.Json;
using Cars;

namespace SerializerFunction
{

    public class Serialization
    {
        private static string _filepath = "./Database/Car.json";
        public static void SerialMain()
        {



            //List<Car> listOfCars = new List<Car>();

            //may need to create a car object here
            List<Car> listOfCars = new List<Car>();

            Car car1 = new Car();
            car1._color = "Black";
            car1._owner = "Rhea";
            car1._gallonPerMile = 20;

            listOfCars.Add(car1);

            string jsonString = JsonSerializer.Serialize(car1, new JsonSerializerOptions { WriteIndented = true });

            Console.WriteLine(jsonString);




            //We need to create a json file since we do not already have one
            //The File class will help us with that.

            File.WriteAllText(_filepath, jsonString);



        }

    }
}