// See https://aka.ms/new-console-template for more information

using Zoo_exercise;


List<Food> bag = new List<Food>()
{
    new Meat("Parzhola"),
    new Meat("Steak"),
    new Meat("Chicken Breast"),
    new Meat("Sausage"),
    new Meat("Bacon"),
    new Meat("Ham"),
    new Meat("Lamb Chops"),
    new Meat("Meatballs"),
    new Meat("Fish Fillet"),
    new Meat("Salami"),

    new Plant("Carrot"),
    new Plant("Apple"),
    new Plant("Banana"),
    new Plant("Cabbage"),
    new Plant("Lettuce"),
    new Plant("Tomato"),
    new Plant("Cucumber"),
    new Plant("Potato"),
    new Plant("Corn"),
    new Plant("Beans"),

   

    new Poison("Rat Poison"),
    new Poison("Expired Milk"),
    new Poison("Spoiled Meat" ),
    new Poison("Moldy Bread"),
    new Poison("Toxic Mushroom"),
    new Poison("Pesticide Apple"),
    new Poison("Bleach-Marinated Steak"),
    new Poison("Poisoned Cheese"),
    new Poison("Rotten Fish"),
    new Poison("Chemical Soup"), 
};

List<Animal> animals = new List<Animal>()
{
    new Tiger(5),
    new Lion(5),
    new Wolf(5),
    new Eagle(5)

};

Person keeper = new Person();
keeper.FeedAllAnimals(animals,bag);








