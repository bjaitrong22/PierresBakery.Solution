using System;

namespace PierresBakery
{
  public class PierresBakeryApp
  {
    public static void Main()
    {
      Console.Clear();

      // Set the Foreground color to blue
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\n");

      string welcomeMessage = "WELCOME TO PIERRE'S BAKERY";
      string breadHeading = "BREAD";
      string singleLoaf = "Single Loaf: $5";
      string twoLoaves = "Two Loaves: $10";
      string threeLoaves = "Three Loaves: $10";

      Console.SetCursorPosition((Console.WindowWidth - welcomeMessage.Length) / 2, Console.CursorTop);

      Console.WriteLine(welcomeMessage);
      Console.WriteLine("\n");

      Console.ForegroundColor = ConsoleColor.DarkRedcle;

      Console.SetCursorPosition((Console.WindowWidth - breadHeading.Length) / 2, Console.CursorTop);

      Console.WriteLine(breadHeading);

      Console.SetCursorPosition((Console.WindowWidth - threeLoaves.Length) / 2, Console.CursorTop);

      Console.WriteLine(threeLoaves);

      Console.SetCursorPosition((Console.WindowWidth - threeLoaves.Length) / 2, Console.CursorTop);

      Console.WriteLine(twoLoaves);

      Console.SetCursorPosition((Console.WindowWidth - threeLoaves.Length) / 2, Console.CursorTop);

      Console.WriteLine(singleLoaf);

     
      
      
      





      

    }
  }

}