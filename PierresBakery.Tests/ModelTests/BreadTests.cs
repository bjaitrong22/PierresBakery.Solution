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
    Bread newBread = new Bread();
    Assert.AreEqual(typeof(Bread), newBread.GetType()); 
   } 

  }
}