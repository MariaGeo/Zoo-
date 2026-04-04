namespace Zoo_exercise;

public class Tiger : Carnivore

{
 public override void Speak()
 {
  if (IsLive)
  {
   Console.WriteLine("I am tiger");
   base.Speak();
  }
 }
}

