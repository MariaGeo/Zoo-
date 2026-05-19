namespace Zoo_exercise.Animals.Herbivores;

public class Elephant(int lifespan) :Herbivore(lifespan)
{
    public override void SpeakName()
    {
        Console.WriteLine("I am Elephant");
    }
}