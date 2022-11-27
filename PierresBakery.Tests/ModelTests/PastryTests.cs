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
      Pastry newPastry = new Pastry("test",1);

      //Assert
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }

    [TestMethod]
   public void GetTypeOfPastry_ReturnsTypeOfPastry_String()
   {
    //Arrange
    string type = "Flaky";
    Pastry newPastry = new Pastry(type,1);

    //Act
    string PastryType = newPastry.TypeOfPastry;

    //Assert
    Assert.AreEqual(type,PastryType);
   }

   [TestMethod]
   public void SetTypeOfPastry_SetTypeOfPastry_String()
   {
    //Arrange
    string type = "Flaky";
    Pastry newPastry = new Pastry(type,1);

    //Act
    string updatePastryType = "Shortcrust";
    newPastry.TypeOfPastry = updatePastryType;
    string result = newPastry.TypeOfPastry;

    //Assert
    Assert.AreEqual(updatePastryType,result);
   }

   [TestMethod]
   public void GetNumberOfPastry_ReturnsNumberOfPastry_Int()
   {
    //Arrange
    string type = "Flaky";
    int quantity = 2;
    Pastry newPastry = new Pastry(type,quantity);

    //Act
    int result = newPastry.NumberOfPastry;

    //Assert
    Assert.AreEqual(quantity,result);
   }

   [TestMethod]
   public void SetNumberOfPastry_SetNumberOfPastry_Int()
   {
    //Arrange
    string type = "Puff";
    int quantity = 5;
    Pastry newPastry = new Pastry(type,quantity);

    //Act
    int updateNumberOfPastry = 3;
    newPastry.NumberOfPastry = updateNumberOfPastry;
    int result = newPastry.NumberOfPastry;

    //Assert
    Assert.AreEqual(updateNumberOfPastry,result);
   }

   [TestMethod]
   public void CostOfPastryOrder_ReturnsCostOfOneToTwoPastryOrder_Int()
   {
    //Arrange
    string type = "Choux";
    int quantity = 1;
    Pastry newPastry = new Pastry(type,quantity);

    //Act
    int costOfOnePastry = 2;
    int result = newPastry.CostOfPastryOrder();

    //Assert
    Assert.AreEqual(costOfOnePastry,result);
   }

   [TestMethod]
   public void CostOfPastryOrder_ReturnsCostOfThreeToFivePastry_Int()
   {
    //Arrange
    string type = "Choux";
    int quantity = 3;
    Pastry newPastry = new Pastry(type,quantity);

    //Act
    int costOfThreePastry = 5;
    int result = newPastry.CostOfPastryOrder();

    //Assert
    Assert.AreEqual(costOfThreePastry,result);
   }

   [TestMethod]
   public void CostOfPastryOrder_ReturnsCostOfSixOrMorePastry_Int()
   {
    //Arrange
    string type = "Choux";
    int quantity = 6;
    Pastry newPastry = new Pastry(type,quantity);

    //Act
    int costOfSixPastry = 10;
    int result = newPastry.CostOfPastryOrder();

    //Assert
    Assert.AreEqual(costOfSixPastry,result);
   }
  }
}