namespace Zoo_exercise.Animals.Carnivores;

public class Wolf:Carnivore
{
    public Wolf(int lifespan) : base(lifespan)
    {
    }

    public override void SpeakName()
    {
        if (IsLive)
        {
            Console.WriteLine("I am wolf");
           
        }
        
    }
}