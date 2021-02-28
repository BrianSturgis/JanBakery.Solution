using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_Object_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
      public void Pastry_PastryQuantity_Int()
      {
        Pastry newPastry = new Pastry(1);
        int result = newPastry.Quantity;
        Assert.AreEqual(0, result);
      }










    }
}