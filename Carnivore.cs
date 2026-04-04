namespace Zoo_exercise;

public abstract class Carnivore : IAnimal
{
    public int Lifespan { get; set; }
    public Boolean IsLive { get; set; } = true;
    private Boolean _initialized;
    private int InitialLifespan { get; } = 5;


    public int UpdatedLifespan { get; set; }

    public void Eat(Food food)
    {
        if (!_initialized)
        {
            Lifespan = InitialLifespan;
            _initialized = true;
        }
        Console.WriteLine("========================");
        Console.WriteLine("I eat " + food.GetName());

        if (food.GetFoodType() == FoodType.MEAT)
        {
            if (Lifespan < 5)
            {
                Lifespan += 1;
            }
        }
        else if (food.GetFoodType() == FoodType.POISON)
        {
            IsLive = false;
            Lifespan = 0;
        }
        else
        {
            if (Lifespan is >= 0 and <= 5)
            {
                Lifespan -= 1;
            }
        }

        UpdatedLifespan = Lifespan;
    }

    public virtual void Speak()
    {
        if (IsLive)
        {
            Console.WriteLine("My lifespan is " + UpdatedLifespan);
            Console.WriteLine("I'm Alive");
        }
        else
        {
            Console.WriteLine("I'm dead");
        }

    }
}