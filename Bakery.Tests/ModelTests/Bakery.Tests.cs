using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
    public class BakeryTests
    {


      [TestMethod]
      public void Bread_Object_Bread()
      {
       Bread newBread = new Bread(1);
       Assert.AreEqual(typeof(Bread), newBread.GetType());
      }

      [TestMethod]
      public void Bread_BreadQuantity_Int()
      {
        
      }

    }
}