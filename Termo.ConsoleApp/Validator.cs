static class Validator
{
  public static bool isValid(string chute)
  {
    if (string.IsNullOrWhiteSpace(chute) || HasInvalidCharacters(chute))
    {
      Console.WriteLine("\n------------------------------------------------------------");
      Console.WriteLine("❌  Não utilize espaços em branco, números e/ou caracteres.");
      Console.WriteLine("------------------------------------------------------------");
      return false;
    }

    if (chute.Length != 5)
    {
      Console.WriteLine("\n------------------------------------------------------------");
      Console.WriteLine("⚠️   Ops! Digite uma palavra de 5 letras.");
      Console.WriteLine("------------------------------------------------------------");
      return false;
    }

    return true;
  }

  public static bool HasInvalidCharacters(string chute)
  {
    char[] commonChars = ['0','1','2','3','4','5','6','7','8','9','`','-','=','[',']','\\',';','\'',',','.','/', '~','!','@','#','$','%','¨','&','*','(',')',
    '_','+','{','}','|',':','"','<','>','?', 'ç','Ç'];

    foreach (char letra in chute)
      foreach (char charactere in commonChars)
        if (letra == charactere) return true;

    return false;
  }
}