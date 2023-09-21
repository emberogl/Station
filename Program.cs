using Station.Model;
using System.Diagnostics;

namespace Station
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not allowed
            //Animal animal = new Animal();

            // Creating a dog and putting it in a station instance
            Animal dog = new Dog("Doggy", 2, "Short coat", "Male");
            Model.Station station = new Model.Station();

            // Adding dog to station
            Console.WriteLine(station.AddToStation(dog));
            // Incrementing dog age
            dog.IncrementAge(2);
            // Getting animals in station (dog)
            Console.WriteLine(station.GetAnimalsAtStation());
            // Removing dog from station
            Console.WriteLine(station.LeaveStation(dog));
            // Getting animals in station (none)
            Console.WriteLine(station.GetAnimalsAtStation());
            // Getting animals that have been in station (dog)
            Console.WriteLine(station.GetAnimalsBeenAtStation());
            // Dog info
            Console.WriteLine($"name: {dog.GetName()}, age: {dog.GetAge()}, sex: {dog.GetSex()}, species: {dog.GetSpecies()}, fur: {dog.GetFurType()}");
        }
    }
}