using Zoo_exercise.Animals.Оmnivorous;

namespace Zoo_exercise.Animals.Оmnivores;

public class Pig:Omnivorous
{
    public Pig(int lifespan) : base(lifespan)
    {
    }

    public override void SpeakName()
    {
        Console.WriteLine("I am pig"); 
    }
}