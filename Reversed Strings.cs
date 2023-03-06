//Complete the solution so that it reverses the string passed into it.

//'world'  =>  'dlrow'
//'word'   =>  'drow'


using System;
using System.Linq; // to use KATA2
public static class Kata
{
  public static string Solution(string str) 
  {
    return new string(str.Reverse().ToArray());
    throw new NotImplementedException("TODO: Kata.Solution(string) => string");
  }
}

public static class Kata2
{
  public static string Solution(string str)
    {
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }
}
