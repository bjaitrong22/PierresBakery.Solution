using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class BreadTests
  {

   [TestMethod]
   public void BreadConstructor_CreatesInstanceOfBread_Bread()
   {
    //Arrange and Act
    int quantity = 1;
    Bread newBread = new Bread("multigrain",quantity);

    //Assert
    Assert.AreEqual(typeof(Bread), newBread.GetType()); 
   } 

   [TestMethod]
   public void GetTypeOfBread_ReturnsTypeOfBread_String()
   {
    //Arrange
    string type = "Sourdough";
    int quantity = 1;
    Bread newBread = new Bread(type,quantity);

    //Act
    string breadType = newBread.TypeOfBread;

    //Assert
    Assert.AreEqual(type,breadType);
   }

   [TestMethod]
   public void SetTypeOfBread_SetTypeOfBread_String()
   {
    //Arrange
    string breadType = "Sourdough";
    int quantity = 1;
    Bread newBread = new Bread(breadType,quantity);

    //Act
    string updateBreadType = "Rye";
    newBread.TypeOfBread = updateBreadType;
    string result = newBread.TypeOfBread;

    //Assert
    Assert.AreEqual(updateBreadType,result);
   }

   [TestMethod]
   public void GetNumberOfLoaves_ReturnsNumberOfLoaves_Int()
   {
    //Arrange
    string type = "multigrain";
    int quantity = 2;
    Bread newBread = new Bread(type,quantity);

    //Act
    int result = newBread.NumberOfLoaves;

    //Assert
    Assert.AreEqual(quantity,result);
   }

   [TestMethod]
   public void SetNumberOfLoaves_SetNumberOfLoaves_Int()
   {
    //Arrange
    string breadType = "Sourdough";
    int quantity = 1;
    Bread newBread = new Bread(breadType,quantity);

    //Act
    int updateNumberOfLoaves = 3;
    newBread.NumberOfLoaves = updateNumberOfLoaves;
    int result = newBread.NumberOfLoaves;

    //Assert
    Assert.AreEqual(updateNumberOfLoaves,result);
   }

   [TestMethod]
   public void CostOfBreadOrder_ReturnsCostOfBreadOrder_Int()
   {
    //Arrange
    string breadType = "Sourdough";
    int quantity = 1;
    Bread newBread = new Bread(breadType,quantity);

    //Act
    int costOfOneLoaf = 5;
    int result = newBread.CostOfBreadOrder();

    //Assert
    Assert.AreEqual(costOfOneLoaf,result);
   }

   [TestMethod]
   public void CostOfBreadOrder_ReturnsCostOfBreadOrderForTwoLoaves_Int()
   {
    //Arrange
    string breadType = "Sourdough";
    int quantity = 2;
    Bread newBread = new Bread(breadType,quantity);

    //Act
    int costOfTwoLoaf = 10;
    int result = newBread.CostOfBreadOrder();

    //Assert
    Assert.AreEqual(costOfTwoLoaf,result);
   }

   [TestMethod]
   public void CostOfBreadOrder_ReturnsCostOfBreadOrderForMultipleOfTwo_Int()
   {
    //Arrange
    string breadType = "Sourdough";
    int quantity = 14;
    Bread newBread = new Bread(breadType,quantity);

    //Act
    int costOfFourteenLoaf = 70;
    int result = newBread.CostOfBreadOrder();

    //Assert
    Assert.AreEqual(costOfFourteenLoaf,result);
   }
  }
}