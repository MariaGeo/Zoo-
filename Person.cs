namespace Zoo_exercise;
using System.Collections.Generic;

public class Person
{
    Random random=new Random();

    
  

    public void FeedAnimal(IAnimal animal, Food food)
    {
            animal.Eat(food);
            animal.Speak();
    }

    public void FeedAllAnimals(List<IAnimal> animals, List<Food> bag)
    {
        for (int i = 0; i < 5; i++)
        {
            foreach (var animal in animals)
            {
                int index = random.Next(bag.Count);
                Food food = bag[index];
                FeedAnimal(animal, food);
                bag.RemoveAt(index);
            }
            
        }
    }
}
