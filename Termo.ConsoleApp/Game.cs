using System.Security.Cryptography;

static class Game
{
  private static readonly string[] words = [
  "AMIGO", "VERDE", "NUVEM", "TIGRE", "VENTO",
    "CHUVA", "FOLHA", "PRAIA", "SABOR", "FALAR",
    "ROSTO", "LENTE", "CANTO", "BRISA", "FERRO",
    "PEQUI", "NOBRE", "TOCAR", "FIRME", "CASAL"
  ];

  public static string GenerateRandomWord()
  {
    int index = RandomNumberGenerator.GetInt32(words.Length);
    return words[index];
  }


}