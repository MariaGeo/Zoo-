namespace Zoo_exercise;

public interface IAnimal
{
   public int Lifespan { get; set; }
   public Boolean IsLive { get; set; }
    
    void Eat(Food food);
    void Speak();
    
    public String ToString()
    {
        return "Lifespan='" + Lifespan + "; isLive= " + IsLive;

    }
   
}