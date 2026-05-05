namespace Zoo_exercise;

public class Eagle : Carnivore
{
    public Eagle(int customLifespan) : base(customLifespan)
    {
    }

    public override void SpeakName()
    {
        if (isLive)
        {
            Console.WriteLine("I am eagle");
        }
    }
}