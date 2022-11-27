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
      string pastryHeading = "PASTRIES";
      string singlePastry = "One: $2";
      string triplePastry = "Three: $5";
      string quadruplePastry = "Four: $7";
      string quintuplePastry = "Five: $9";
      string sextuplePastry = "Six: $10";

      int numberOfLoaves = 0;
      int numberOfPastries = 0;



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

      //Order Request and Input
      string breadType = "sourdough";
      string pastryType = "Choux";


      Console.WriteLine("\n");

      try
      {
        Console.WriteLine("How many Loaves of Bread would you like?");
        string breadOrder = Console.ReadLine();

        Console.WriteLine("How many Pastries would you like?");
        string pastryOrder = Console.ReadLine();

        numberOfLoaves = Math.Abs(int.Parse(breadOrder));
        numberOfPastries = Math.Abs(int.Parse(pastryOrder));
      }
        catch(Exception ex)
      {
        Console.WriteLine("Message= {0}", ex.Message);
        Console.WriteLine("Please enter only whole numbers.\n");
        return;
      }
      
      Bread yourBreadOrder = new Bread(breadType,numberOfLoaves);
      Pastry yourPastryOrder = new Pastry(pastryType,numberOfPastries);

      int totalCost = yourBreadOrder.CostOfBreadOrder() + yourPastryOrder.CostOfPastryOrder();

      Console.WriteLine("\n");
      Console.WriteLine(yourBreadOrder.NumberOfLoaves + " loaf/Loaves of Bread");
      Console.WriteLine(yourPastryOrder.NumberOfPastry + " Pastry/Pastries.");
      Console.WriteLine("________________");
      Console.WriteLine("Total cost: " + "$" + totalCost); 

      Console.WriteLine("\n\n");
    }
  }
}