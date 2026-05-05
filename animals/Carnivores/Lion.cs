namespace Zoo_exercise;

public class Lion : Carnivore
{
    public Lion(int currentLifespan) : base(currentLifespan)
    {
    }

    public override void SpeakName()
    {
        Console.WriteLine("I am lion");
    }
}