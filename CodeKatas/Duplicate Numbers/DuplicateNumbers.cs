using System;
using System.Linq;

namespace CodeKatas {
  class DuplicateNumbers {
    public int firstDuplicate(int[] a) {
      var thing = a.GroupBy(x => x);
      return a.GroupBy(x=>x).O.Where(z => z.Count() > 1).Select(x=>x.Key).DefaultIfEmpty(-1).FirstOrDefault();
    }
  }
}
