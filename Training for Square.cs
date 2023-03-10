//Complete the square sum function so that it squares each number passed into it and then sums the results together.

//For example, for [1, 2, 2] it should return 9 because 



public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    foreach (int x in numbers)
      {
      sum = sum + x*x;
    }
    return sum;
  }
}


//using System.Linq; cach lam 2

public static class Kata
{
  public static int SquareSum(int[] numbers ) => numbers.Sum(i => i * i);
}