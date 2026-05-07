namespace Zoo_exercise.Animals.Carnivores;

public class Eagle : Carnivore
{
    public Eagle(int lifespan) : base(lifespan)
    {
    }

    public override void SpeakName()
    {
        if (IsLive)
        {
            Console.WriteLine("I am eagle");
        }
    }
}