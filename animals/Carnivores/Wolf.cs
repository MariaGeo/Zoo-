namespace Zoo_exercise;

public class Wolf:Carnivore
{
    public Wolf(int customLifespan) : base(customLifespan)
    {
    }

    public override void SpeakName()
    {
        if (isLive)
        {
            Console.WriteLine("I am wolf");
           
        }
        
    }
}