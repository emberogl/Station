namespace Station.Model
{
    public class Chicken : Animal
    {
        protected override string _species { get; } = "Gallus domesticus";
        protected override string? _reproductionType { get; } = "Oviparous";
        protected override int? _legCount { get; } = 2;
        public Chicken(string name, int age, string sex) : base(name, age, null, sex)
        {
        }

        public override string GetFurType()
        {
            return $"no fur, just feathers";
        }
    }
}