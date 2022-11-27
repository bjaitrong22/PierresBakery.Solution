namespace PierresBakery
{
  public class Bread
  {
    public string TypeOfBread {get; set; }
    public int NumberOfLoaves{get; set; }
  
    //constructor
    public Bread(string breadType,int quantity)
    {
      TypeOfBread = breadType;
      NumberOfLoaves = quantity;
    }

    public int CostOfBreadOrder()
    {
        int breadBaseCost = 5;
        int cost = (NumberOfLoaves/3) * 10 + (NumberOfLoaves % 3) * breadBaseCost;
        return cost; 
    } 
  }
}