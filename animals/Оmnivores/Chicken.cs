using Zoo_exercise.Animals.Оmnivorous;

namespace Zoo_exercise.Animals.Оmnivores;

public class Chicken:Omnivorous
{
    public Chicken(int lifespan) : base(lifespan)
    {
    }

    public override void SpeakName()
    {
        Console.WriteLine("I am chicken");
    }
}