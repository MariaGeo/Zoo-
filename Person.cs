namespace Zoo_exercise;
using System.Collections.Generic;

public class Person
{
    Random random=new Random();


    public void FeedAnimal(Animal animal, Food food)
    {
       
        animal.Eat(food);
        animal.SpeakLifespan();
    }

    public void FeedAllAnimals(List<Animal> animals, List<Food> bag)
    {
        for (int i = 0; i < 5; i++)
        {
            foreach (var animal in animals)
            {
                if (!animal.isLive)
                {
                    break;
                }
                animal.SpeakName();
                if (bag.Count == 0)
                {
                    Console.WriteLine("No more food in the bag");
                    return;
                }
                int index = random.Next(bag.Count);
                Food food = bag[index];
                FeedAnimal(animal, food);
                bag.RemoveAt(index);
            }
        }
    }
}
