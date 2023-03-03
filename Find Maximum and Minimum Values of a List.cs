//Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.

public class Kata
{
  public int Min(int[] list)
  {
    int min = list[0];
    foreach (int a in list)
    {
        if (min >a)
        min = a;
    }
    return min;
  }
  
  public int Max(int[] list)
  {
    int max = list[0];
    foreach (int a in list)
    {
        if (max < a)
        max = a;
    }
    return max;
  }
}


//public class Kata
//{
// public int Min(int[] list) => list.Min();
  
// public int Max(int[] list) => list.Max();
//}