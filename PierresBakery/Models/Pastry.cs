namespace PierresBakery
{
  public class Pastry
  {
    public string TypeOfPastry{get; set; }

    //constructor
    public Pastry(string pastryType)
      {
        TypeOfPastry = pastryType;
      } 
  }
}