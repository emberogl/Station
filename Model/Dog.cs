namespace Station.Model
{
    internal class Dog : Animal
    {
        protected override string _species { get; } = "Canis familiaris";
        protected override string? _reproductionType { get; } = "Viviparous";
        protected override int? _legCount { get; } = 4;
        public Dog(string name, int age, string furType) : base(name, age, furType)
        {
        }
    }
}
