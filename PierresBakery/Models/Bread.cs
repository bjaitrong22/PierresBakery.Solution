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
      if (NumberOfLoaves == 1)
      {
        return 5;
      }
      else
      {
        return 0;
      }
      ;
    }
  }
}