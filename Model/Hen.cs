namespace Station.Model
{
    internal class Chicken : Animal
    {
        protected override string _species { get; } = "Gallus domesticus";
        protected override string? _reproductionType { get; } = "Oviparous";
        protected override int? _legCount { get; } = 2;
        public Chicken(string name, int age, string furType) : base(name, age, furType)
        {
        }
    }
}