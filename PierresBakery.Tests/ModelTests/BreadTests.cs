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
    Bread newBread = new Bread("multigrain");

    //Assert
    Assert.AreEqual(typeof(Bread), newBread.GetType()); 
   } 

   [TestMethod]
   public void GetTypeOfBread_ReturnsTypeOfBread_String()
   {
    //Arrange
    string type = "Sourdough";
    Bread newBread = new Bread(type);

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
    Bread newBread = new Bread(breadType);

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

  }
}