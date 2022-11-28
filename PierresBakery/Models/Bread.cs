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
        int cost = 0;

        if (NumberOfLoaves % 3 == 0)
        {
          cost = (NumberOfLoaves/3) * 10; 
        }
        else if (NumberOfLoaves % 3 == 1)
        {
          cost = (NumberOfLoaves/3) * 10 + (NumberOfLoaves % 3) * breadBaseCost;
        }
        else
        {
          //Where NumberOfLoaves % 3 == 2
          cost = (NumberOfLoaves/3) * 10 + (NumberOfLoaves % 3) * breadBaseCost;
          
          //adding third third loaf (buy two and get third loaf free)
          NumberOfLoaves++;
        }
        return cost; 
    } 
  }
}