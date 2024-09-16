public class TitleCaseKata
{
  public static string TitleCase(string title, string minorWords="")
  {
    var mWords = string.IsNullOrEmpty(minorWords) ? minorWords.Split(" ") : [];
    var result = title.Split(" ").Select(word=>{
     if (!minorWords.Contains(word, StringComparison.InvariantCultureIgnoreCase)){
        return ProperCase(word);
     }else{
      return word.ToLower();
     }
    }).ToList();
    result[0] = ProperCase(result[0]);
    return new string(string.Join(" ", result));
  }

    public static string ProperCase(string word){
      switch(word.Length){
        case 0:
          return string.Empty;
        case 1: 
          return char.ToUpper(word[0]).ToString();
        default:
          return string.Concat(char.ToUpper(word[0]).ToString(), word[1..].ToLower());
      }
    }
}