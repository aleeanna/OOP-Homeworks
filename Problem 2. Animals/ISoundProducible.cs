namespace Problem_2.Animals
{
    public interface ISoundProducible
    {
        Gender Gender { get; set; }
        int Age { get; set; }
        string Name { get; set; }
        void ProduceSound();
    }
}