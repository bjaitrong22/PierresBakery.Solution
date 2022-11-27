using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      //Arrange and Act
      Pastry newPastry = new Pastry();

      //Assert
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }

    [TestMethod]
   public void GetTypeOfPastry_ReturnsTypeOfPastry_String()
   {
    //Arrange
    string type = "Flaky";
    int quantity = 1;
    Pastry newPastry = new Pastry(type,quantity);

    //Act
    string PastryType = newPastry.TypeOfPastry;

    //Assert
    Assert.AreEqual(type,PastryType);
   }
  }
}