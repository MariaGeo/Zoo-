namespace Zoo_exercise.Animals.Herbivores;

public class Rabbit(int lifespan) :Herbivore(lifespan)
{
    public override void SpeakName()
    {
        Console.WriteLine("I am rabbit");
    }
}