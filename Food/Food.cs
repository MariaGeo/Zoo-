using Microsoft.VisualBasic;

namespace Zoo_exercise;

public abstract class Food()
{
    public String Name { get; }


    public Food(String foodName) : this()
    {
        Name = foodName;
    }

    public override String ToString()
    {
        return "FoodName='" + Name;
    }


    public String GetName()
    {
        return Name;
    }

    // public FoodType GetFoodType()
    //  {
    //       return Type;
    //   }
}