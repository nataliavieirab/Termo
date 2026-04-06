static class Validator
{
  public static bool IsValid(string userGuess)
  {
    if (string.IsNullOrWhiteSpace(userGuess) || HasInvalidCharacters(userGuess))
    {
      Console.WriteLine("\n------------------------------------------------------------");
      Console.WriteLine("❌  Não utilize espaços em branco, números e/ou caracteres.");
      Console.WriteLine("------------------------------------------------------------");
      return false;
    }

    if (userGuess.Length != 5)
    {
      Console.WriteLine("\n------------------------------------------------------------");
      Console.WriteLine("⚠️   Ops! Digite uma palavra de 5 letras.");
      Console.WriteLine("------------------------------------------------------------");
      return false;
    }

    return true;
  }

  public static bool HasInvalidCharacters(string userGuess)
  {
    char[] commonChars = ['0','1','2','3','4','5','6','7','8','9','`','-','=','[',']','\\',';','\'',',','.','/', '~','!','@','#','$','%','¨','&','*','(',')',
    '_','+','{','}','|',':','"','<','>','?', 'ç','Ç'];

    foreach (char letter in userGuess)
      foreach (char charactere in commonChars)
        if (letter == charactere) return true;

    return false;
  }

}