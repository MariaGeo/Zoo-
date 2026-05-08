using Zoo_exercise.Foods;

namespace Zoo_exercise.Animals.Carnivores;

public abstract class Carnivore : Animal

{
    protected Carnivore(int lifespan) : base(lifespan)
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
            case Meat:
                if (LivePoints < Lifespan)
                {
                    LivePoints++;
                }

                break;
            default:
                LivePoints--;
                if (LivePoints == 0)
                {
                    IsLive = false;
                }
                break;
        }
    }
}