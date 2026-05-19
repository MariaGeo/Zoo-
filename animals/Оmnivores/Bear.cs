using Zoo_exercise.Animals.Оmnivorous;

namespace Zoo_exercise.Animals.Оmnivores;

public class Bear:Omnivorous
{
    public Bear(int lifespan) : base(lifespan)
    {
    }

    public override void SpeakName()
    {
       Console.WriteLine("I am bear");
    }
}