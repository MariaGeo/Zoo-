namespace Zoo_exercise.Animals.Herbivores;

public class Cow(int lifespan) :Herbivore(lifespan)
{
    public override void SpeakName()
    {
        if (IsLive)
        {
            Console.WriteLine("I am cow");
        };
    }
}