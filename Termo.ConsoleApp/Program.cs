using System.Security.Cryptography;

namespace Termo.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    ExibirCabecalho();

    string palavraAleatoria = GerarPalavraAleatoria();

    while (true)
    {

      Console.Write("\n> ");
      string? chute = Console.ReadLine()?.ToUpper();

      if (!VerificarInput(chute!)) continue;

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
      "Amigo",
      "Verde",
      "Nuvem",
      "Tigre",
      "Vento",
      "Chuva",
      "Folha",
      "Praia",
      "Sabor",
      "Falar",
      "Rosto",
      "Lente",
      "Canto",
      "Brisa",
      "Ferro",
      "Pequi",
      "Nobre",
      "Tocar",
      "Firme",
      "Casal"
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

  static bool VerificarInput(string chute)
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
}

