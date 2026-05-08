namespace Zoo_exercise.Animals.Carnivores;

public class Tiger : Carnivore
{
 public Tiger(int lifespan) : base(lifespan)
 {
 }


 public override void SpeakName()
 {
  if (IsLive)
  {
   Console.WriteLine("I am tiger");
   
  }
 }
}

