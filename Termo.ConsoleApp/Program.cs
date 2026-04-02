using System.Security.Cryptography;

namespace Termo.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    ExibirCabecalho();

  }

  static void ExibirCabecalho()
  {
    Console.Clear();
    Console.WriteLine("===========================================");
    Console.WriteLine("------------------ TERMO ------------------");
    Console.WriteLine("===========================================");
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
}