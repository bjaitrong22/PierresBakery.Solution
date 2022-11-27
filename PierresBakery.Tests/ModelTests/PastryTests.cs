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
  }
}