

namespace CodeKatas {
  public class MaskifyKata {
    public string Maskify(string cc) {
      if (cc.Length <= 4)
        return cc;

      var newString = cc.Remove(0, cc.Length - 4);
      return newString.PadLeft(cc.Length, '#');


    }
  }
}
