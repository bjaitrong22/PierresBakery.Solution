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
      int pastryBaseCost = 2;
      int cost = 0;
    
      if (NumberOfPastry < 3)
      {
        cost = NumberOfPastry * pastryBaseCost;
      }
      else if (NumberOfPastry < 6)
      {
        cost = (NumberOfPastry * pastryBaseCost) - 1;
      }
      else
      {
        cost = (NumberOfPastry * pastryBaseCost) - 2;
      } 

      return cost; 
    }
  }
}