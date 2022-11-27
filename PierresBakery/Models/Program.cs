using System;

namespace PierresBakery
{
  public class PierresBakeryApp
  {
    public static void Main()
    {
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\n");

      string welcomeMessage = "WELCOME TO PIERRE'S BAKERY";
      string breadHeading = "BREAD";
      string singleLoaf = "Single Loaf: $5";
      string twoLoaves = "Two Loaves: $10";
      string threeLoaves = "Three Loaves: $10";

      //Welcome Message and Bread Prices
      Console.SetCursorPosition((Console.WindowWidth - welcomeMessage.Length) / 2, Console.CursorTop);

      Console.WriteLine(welcomeMessage);
      Console.WriteLine("\n");

      Console.ForegroundColor = ConsoleColor.DarkRed;

      Console.SetCursorPosition((Console.WindowWidth - breadHeading.Length) / 2, Console.CursorTop);
      Console.WriteLine(breadHeading);

      Console.SetCursorPosition((Console.WindowWidth - threeLoaves.Length) / 2, Console.CursorTop);
      Console.WriteLine(threeLoaves);

      Console.SetCursorPosition((Console.WindowWidth - threeLoaves.Length) / 2, Console.CursorTop);
      Console.WriteLine(twoLoaves);

      Console.SetCursorPosition((Console.WindowWidth - threeLoaves.Length) / 2, Console.CursorTop);
      Console.WriteLine(singleLoaf);

      //Pastry Prices
      string pastryHeading = "Pastries";
      string singlePastry = "One: $2";
      string triplePastry = "Three: $5";
      string quadruplePastry = "Four: $7";
      string quintuplePastry = "Five: $9";
      string sextuplePastry = "Six: $10";


      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n");

      Console.SetCursorPosition((Console.WindowWidth - pastryHeading.Length) / 2, Console.CursorTop);
      Console.WriteLine(pastryHeading);

      Console.SetCursorPosition((Console.WindowWidth - triplePastry.Length) / 2, Console.CursorTop);
      Console.WriteLine(sextuplePastry);

      Console.SetCursorPosition((Console.WindowWidth - triplePastry.Length) / 2, Console.CursorTop);
      Console.WriteLine(quintuplePastry);

      Console.SetCursorPosition((Console.WindowWidth - triplePastry.Length) / 2, Console.CursorTop);
      Console.WriteLine(quadruplePastry);

      Console.SetCursorPosition((Console.WindowWidth - triplePastry.Length) / 2, Console.CursorTop);
      Console.WriteLine(triplePastry);

      Console.SetCursorPosition((Console.WindowWidth - triplePastry.Length) / 2, Console.CursorTop);
      Console.WriteLine(singlePastry);
    }
  }

}