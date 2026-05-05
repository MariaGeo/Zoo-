using System;

namespace Zoo_exercise;

public abstract class Carnivore : Animal

{
    public Carnivore(int currentLifespan) : base(currentLifespan)
    {
    }


    public override void Eat(Food food)
    {
        Console.WriteLine("I eat " + food.GetName());

        if (!isLive)
        {
            return;
        }

        if (food.GetType() == typeof(Poison))
        {
            isLive = false;
            currentLifespan=0;
            return;
        }

        if (food.GetType() == typeof(Meat) && currentLifespan < 5)
        {
            currentLifespan++;
            return;
        }

        currentLifespan--;
    }

    
}