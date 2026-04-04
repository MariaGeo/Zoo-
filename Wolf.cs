namespace Zoo_exercise;

public class Wolf:Carnivore
{
    public override void Speak()
    {
        if (IsLive)
        {
            Console.WriteLine("I am wolf");
            base.Speak();
        }
        
    }
}