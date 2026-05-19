using Zoo_exercise.Foods;

namespace Zoo_exercise.Animals.Оmnivorous;

public abstract class Omnivorous:Animal
{
    public Omnivorous(int lifespan) : base(lifespan)
    {
    }
    
    public override void Eat(Food food)
    {
        if (!IsLive)
        {
            return;
        }

        Console.WriteLine($"I eat {food.GetName()}");

        switch (food)
        {
            case Poison:
                IsLive = false;
                LivePoints = 0;
                return;
          default:
               if (LivePoints == 0)
                {
                    IsLive = false;
                }
                break;
        }
    }
}