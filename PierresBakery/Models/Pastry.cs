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
      int cost = 2;
    
      if (NumberOfPastry == 1 || NumberOfPastry == 2)
      {
        cost = NumberOfPastry * cost;
        return cost;
      }
      else if (NumberOfPastry < 6)
      {
        cost = (NumberOfPastry * cost) - 1;
        return cost;
      }
      {
        return 0;
      }  
    }
  }
}