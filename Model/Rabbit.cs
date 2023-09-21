namespace Station.Model
{
    public class Rabbit : Animal
    {
        protected override string _species { get; } = "Oryctolagus cuniculus";
        protected override string? _reproductionType { get; } = "Viviparous";
        protected override int? _legCount { get; } = 4;
        public Rabbit(string name, int age, string furType, string sex) : base(name, age, furType, sex)
        {
        }
    }
}