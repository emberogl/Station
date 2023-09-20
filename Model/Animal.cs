namespace Station.Model
{
    internal class Animal
    {
        protected private string _name;
        protected private string _species;
        protected private string _reproductionType;
        protected private int _age;
        protected private int _legCount;
        protected private string _furType;

        public Animal(string name, string species, string reproductionType, int age, int legCount, string furType)
        {
            _name = name;
            _species = species;
            _reproductionType = reproductionType;
            _age = age;
            _legCount = legCount;
            _furType = furType;
        }

        public string IncrementAge(int years)
        {
            _age += years;
            return $"{_name}'s age increased to {_age}";
        }
    }
}