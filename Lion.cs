namespace Zoo_exercise;

public class Lion:Carnivore
{
    public override void Speak()
    {
        if (IsLive)
        {
            Console.WriteLine("I am lion");
            base.Speak();
        }
       
    }
}