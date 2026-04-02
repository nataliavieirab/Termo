using System.Security.Cryptography;

namespace Termo.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    ExibirCabecalho();

    string palavraAleatoria = GerarPalavraAleatoria();
    Console.WriteLine(palavraAleatoria);

    int tentativasMaximas = 5;

    while (true)
    {

      for (int tentativa = tentativasMaximas; tentativa >= 1; tentativa--)
      {
        Console.WriteLine();
        Console.Write("> ");
        string? chute = Console.ReadLine()?.ToUpper();

        if (!VerificarPalavra(chute!)) continue;

        if (Acertou(chute!, palavraAleatoria))
        {
          Console.Write("< ");

          Console.BackgroundColor = ConsoleColor.DarkGreen;
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(chute);
          Console.ResetColor();

          Console.ReadLine();

          Console.WriteLine("\n------------------------------------------------------------");
          Console.WriteLine("🎉  Parabéns, você acertou!!");
          Console.WriteLine("------------------------------------------------------------");

          return;
        }

        ClassificarLetras(chute!, palavraAleatoria, tentativa);

      }

    }
  }
  static void ExibirCabecalho()
  {
    Console.Clear();

    Console.WriteLine("============================================================");
    Console.Write("--------------------- TERMO ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[5 letras] ");
    Console.ResetColor();
    Console.WriteLine("---------------------");
    Console.WriteLine("============================================================");
  }

  static string GerarPalavraAleatoria()
  {
    string[] palavras = [
      "AMIGO",
      "VERDE",
      "NUVEM",
      "TIGRE",
      "VENTO",
      "CHUVA",
      "FOLHA",
      "PRAIA",
      "SABOR",
      "FALAR",
      "ROSTO",
      "LENTE",
      "CANTO",
      "BRISA",
      "FERRO",
      "PEQUI",
      "NOBRE",
      "TOCAR",
      "FIRME",
      "CASAL"
    ];

    int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

    string palavraAleatoria = palavras[indiceAleatorio];

    return palavraAleatoria;
  }

  static bool PossuiCaracteresInvalidos(string chute)
  {
    char[] commonChars = ['0','1','2','3','4','5','6','7','8','9','`','-','=','[',']','\\',';','\'',',','.','/', '~','!','@','#','$','%','¨','&','*','(',')',
    '_','+','{','}','|',':','"','<','>','?', 'ç','Ç'];

    foreach (char letra in chute)
      foreach (char charactere in commonChars)
        if (letra == charactere) return true;

    return false;
  }

  static bool VerificarPalavra(string chute)
  {
    if (string.IsNullOrWhiteSpace(chute) || PossuiCaracteresInvalidos(chute))
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

  static bool Acertou(string chute, string palavraAleatoria)
  {
    if (chute == palavraAleatoria)
      return true;

    return false;
  }

  static void ClassificarLetras(string chute, string palavraAleatoria, int tentativa)
  {
    Console.Write("< ");

    for (int posicao = 0; posicao < chute.Length; posicao++)
    {
      char letraChute = chute[posicao];
      char letraPalavra = palavraAleatoria[posicao];

      if (letraChute == letraPalavra)
      {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
      }
      else if (palavraAleatoria.Contains(letraChute))
      {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
      }
      else
      {
        Console.BackgroundColor = ConsoleColor.DarkRed;
      }

      Console.Write(letraChute);
      Console.ResetColor();

    }

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write($" [{tentativa}] tentativas restantes...");
    Console.ResetColor();
  }

}