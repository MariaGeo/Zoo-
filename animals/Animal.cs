using Zoo_exercise.Foods;

namespace Zoo_exercise.Animals;

public abstract class Animal
{
    protected readonly int Lifespan;

    public int LivePoints { get; set; }
    public virtual Boolean IsLive { get; set; } = true;

    protected Animal(int lifespan)
    {
        this.Lifespan = lifespan;
        LivePoints = Lifespan;
    }

    public abstract void Eat(Food food);
    public abstract void SpeakName();

    public void SpeakLifePoints()
    {
        Console.WriteLine($"My LifePoints are {LivePoints}");
        Console.WriteLine("========================");
    }


    public virtual String ToString()
    {
        return $"Lifespan= {Lifespan}, IsLive= {IsLive}";
    }
}


    