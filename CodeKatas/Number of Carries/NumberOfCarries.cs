using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace CodeKatas.Number_of_Carries {
  public class NumberOfCarriesKata {

    public int NumberOfCarries(int a, int b) {
      var total = 0;
      var lastCarry = 0;
      while (a > 0 || b> 0) {
        lastCarry = (a % 10 + b % 10 + lastCarry) / 10;
        total += lastCarry;
        a /= 10;
        b /= 10;
      }
      return total;
    }
  }
}
