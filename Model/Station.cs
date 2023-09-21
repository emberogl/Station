namespace Station.Model
{
    /// <summary>
    /// Station class that logs all animals that have entered station,
    /// and animals currently in station
    /// </summary>
    public class Station
    {
        private List<Animal> _beenAtStation = new List<Animal>();
        private List<Animal> _atStation = new List<Animal>();

        public string GetAnimalsBeenAtStation()
        {
            if (_beenAtStation!.Any())
            {
                // Left side of (=>) is an input that represents an individual element in _beenAtStation
                // Right side of (=>) is a method body calling to get the name of the individual element of type Animal to concatenate to Join() method
                return $"Animals been in station: {string.Join(", ", _beenAtStation.Select(a => a.GetName()))}";
            }
            else
            {
                return "No animals have been at the station.";
            }
        }

        public string GetAnimalsAtStation()
        {
            if (_atStation.Any())
            {
                return $"Animals in station: {string.Join(", ", _atStation.Select(a => a.GetName()))}";
            }
            else
            {
                return "No animals are at the station.";
            }
        }

        public string AddToStation(Animal animal)
        {
            _beenAtStation.Add(animal);
            _atStation.Add(animal);
            return $"{animal.GetName()} added to station.";
        }

        public string LeaveStation(Animal animal)
        {
            if (_atStation.Contains(animal))
            {
                _atStation.Remove(animal);
                return $"{animal.GetName()} removed from station.";
            }
            else
            {
                return $"{animal.GetName()} is not in station.";
            }
        }
    }
}