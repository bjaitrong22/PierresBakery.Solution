namespace PierresBakery
{
  public class Pastry
  {
    public string TypeOfPastry{get; set; }
    public int NumberOfPastry{get; set; }

    //constructor
    public Pastry(string pastryType, int quantity)
      {
        TypeOfPastry = pastryType;
        NumberOfPastry = quantity;
      } 

    public int CostOfPastryOrder()
    {
      return 0;
    }
  }
}