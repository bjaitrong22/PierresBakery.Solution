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
    Bread newBread = new Bread();

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

  }
}