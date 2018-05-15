using System.Text;

namespace CodeKatas.MorseCode {
  class MorseCodeDecoder {

    public static string Decode(string morseCode) {
      var stringBuilder = new StringBuilder();
      var alteredString = morseCode.Replace("   ", "~").Split('~');

      foreach (var word in alteredString) {
        foreach (var letter in word.Split(null)) {
          //stringBuilder.Append(MorseCode.Get(letter));
        }
        stringBuilder.Append(" ");
      }
      return stringBuilder.ToString().TrimEnd().TrimStart();
    }
  }
}
