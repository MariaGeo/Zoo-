namespace Zoo_exercise;

public class Tiger : Carnivore
{
 public Tiger(int customLifespan) : base(customLifespan)
 {
 }


 public override void SpeakName()
 {
  if (isLive)
  {
   Console.WriteLine("I am tiger");
   
  }
 }
}

