namespace Zoo_exercise.Animals.Carnivores;

public class Lion : Carnivore
{
    public Lion(int lifespan) : base(lifespan)
    {
    }

    public override void SpeakName()
    {
        Console.WriteLine("I am lion");
    }
}