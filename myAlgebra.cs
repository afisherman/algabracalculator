using System;

public class myAlgera
{
  public static void Main()
  {
    int x;
    int y;
    int result;

    int counter = 0;
 
    Random counter2 = new Random();

    Console.WriteLine("Here is an algabreic calculator!");

    while (counter<20)
    {
      x = counter;
      y = counter2.Next(10);
      result = x*y;

      Console.WriteLine($"X equals: {x}, Y equals: {y} = {result}");
      counter++;
    }
  }
}
