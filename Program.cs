// See https://aka.ms/new-console-template for more information

using Zoo_exercise;

//Food parzhola= new Meat("Parzhola", FoodType.MEAT);
//Food grass=new Food("Grass", FoodType.PLANTS);
//Food poison=new Food("Poison", FoodType.POISON);


//List<Food> bag = new List<Food>();


/*
List<Food> bag= new ArrayList<>(List.of(
    new Food("Apple"),
    new Food("Banana")


FoodBag bag = new FoodBag();

store.addFoods(List.of(
    new Food("Пилешко", FoodType.MEAT),
    new Food("Говеждо", FoodType.MEAT),
    new Food("Моркови", FoodType.PLANT),
    new Food("Листа", FoodType.PLANT),
    new Food("Сандвич", FoodType.MIXED)
    */
List<Food> bag = new List<Food>()
{
    new Food("Parzhola", FoodType.MEAT),
    new Food("Steak", FoodType.MEAT),
    new Food("Chicken Breast", FoodType.MEAT),
    new Food("Sausage", FoodType.MEAT),
    new Food("Bacon", FoodType.MEAT),
    new Food("Ham", FoodType.MEAT),
    new Food("Lamb Chops", FoodType.MEAT),
    new Food("Meatballs", FoodType.MEAT),
    new Food("Fish Fillet", FoodType.MEAT),
    new Food("Salami", FoodType.MEAT),

    new Food("Carrot", FoodType.PLANT),
    new Food("Apple", FoodType.PLANT),
    new Food("Banana", FoodType.PLANT),
    new Food("Cabbage", FoodType.PLANT),
    new Food("Lettuce", FoodType.PLANT),
    new Food("Tomato", FoodType.PLANT),
    new Food("Cucumber", FoodType.PLANT),
    new Food("Potato", FoodType.PLANT),
    new Food("Corn", FoodType.PLANT),
    new Food("Beans", FoodType.PLANT),

    new Food("Sandwich", FoodType.MIXED),
    new Food("Pizza", FoodType.MIXED),
    new Food("Burger", FoodType.MIXED),
    new Food("Hot Dog", FoodType.MIXED),
    new Food("Lasagna", FoodType.MIXED),
    new Food("Taco", FoodType.MIXED),
    new Food("Wrap", FoodType.MIXED),
    new Food("Doner", FoodType.MIXED),
    new Food("Burrito", FoodType.MIXED),
    new Food("Pasta Bolognese", FoodType.MIXED),

    new Food("Rat Poison", FoodType.POISON),
    new Food("Expired Milk", FoodType.POISON),
    new Food("Spoiled Meat", FoodType.POISON),
    new Food("Moldy Bread", FoodType.POISON),
    new Food("Toxic Mushroom", FoodType.POISON),
    new Food("Pesticide Apple", FoodType.POISON),
    new Food("Bleach-Marinated Steak", FoodType.POISON),
    new Food("Poisoned Cheese", FoodType.POISON),
    new Food("Rotten Fish", FoodType.POISON),
    new Food("Chemical Soup", FoodType.POISON)
};

List<IAnimal> animals = new List<IAnimal>()
{
    new Tiger(),
    new Lion(),
    new Wolf(),
    new Eagle()

};

Person keeper = new Person();
keeper.FeedAllAnimals(animals,bag);








