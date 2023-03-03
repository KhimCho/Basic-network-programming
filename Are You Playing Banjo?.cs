//Create a function which answers the question "Are you playing banjo?".
//If your name starts with the letter "R" or lower case "r", you are playing banjo!

//The function takes a name as its only argument, and returns one of the following strings:
//name + " plays banjo" 
//name + " does not play banjo"

using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    return name + (name.ToLower()[0] == 'r' ? " plays banjo" : " does not play banjo");
  }
}