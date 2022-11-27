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
      if (NumberOfLoaves == 1 || NumberOfLoaves == 2)
      {
        int cost = NumberOfLoaves * 5;
        return cost;
      }
      else
      {
        int cost = (NumberOfLoaves/3) * 10 + (NumberOfLoaves % 3) * 5;
        return cost;
      }
    } 
  }
}