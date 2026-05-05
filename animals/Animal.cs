namespace Zoo_exercise;

public abstract class Animal
{
    public int currentLifespan { get; set; }

    //protected int CustomLifespan { get; set; }
    public virtual Boolean isLive { get; set; } = true;

    protected Animal(int lifespan)
    {
        currentLifespan = lifespan;
       
    }

    public abstract void Eat(Food food);
    public abstract void SpeakName();

    public void SpeakLifespan()
    {
        Console.WriteLine("My lifespan is " + currentLifespan);
        Console.WriteLine("========================");
    }


    public virtual String ToString()
    {
        return "Lifespan='" + currentLifespan + "; isLive= " + isLive;
    }
}