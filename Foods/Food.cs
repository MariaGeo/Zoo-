namespace Zoo_exercise.Foods;

public abstract class Food()
{
    public String Name { get; }


    public Food(String foodName) : this()
    {
        Name = foodName;
    }

    public override String ToString()
    {
        return $"FoodName={Name}";
    }


    public String GetName()
    {
        return Name;
    }
}