using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
  {
    public int Quantity { get; set; }
    public int Total { get; set; }

    public Bread(int a)
    {
      Quantity = 0;
      Total = 0;
    }

  }
}