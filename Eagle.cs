namespace Zoo_exercise;

public class Eagle:Carnivore
{
    public override void Speak()
    {
        if (IsLive)
        {
            Console.WriteLine("I am eagle");
            base.Speak();
        }
        
    }
}