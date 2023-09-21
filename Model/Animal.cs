namespace Station.Model
{
    /// <summary>
    /// Abstract animal class that defines default "animal" properties
    /// </summary>
    public abstract class Animal
    {
        protected string _name;
        protected int _age;
        protected string? _furType;
        protected string? _sex;
        protected virtual string? _species { get; }
        protected virtual string? _reproductionType { get; }
        protected virtual int? _legCount { get; }

        public Animal(string name, int age, string? furType, string? sex)
        {
            _name = name;
            _age = age;
            _furType = furType;
            _sex = sex;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetSpecies()
        {
            return _species!;
        }

        // Allowing override to prevent chicken from having fur
        public virtual string GetFurType()
        {
            return _furType!;
        }

        public void IncrementAge(int years)
        {
            _age += years;
        }

        public string GetSex()
        {
            return _sex!;
        }
    }
}