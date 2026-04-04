using Microsoft.VisualBasic;

namespace Zoo_exercise;

public class Food()
{
    public  String Name { get; }
    public FoodType Type { get; }

    

  public Food (String foodName, FoodType foodType) : this()
  {
     Name = foodName; 
     Type = foodType;
    }

  public override String ToString()
  {
      return "FoodName='" + Name + "; foodType=" + Type;

  }

  
    public String GetName()
    {
        return Name;
    }

    public FoodType GetFoodType()
    {
        return Type;
    }
}




