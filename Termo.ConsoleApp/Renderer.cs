static class Renderer
{
  public static void RenderHeader()
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
  public static void RenderSuccessMessage(string chute)
  {
    Console.Write("< ");
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(chute);
    Console.ResetColor();
    Console.WriteLine("\n🎉 Você acertou!");
    Console.ReadLine();
  }
  public static void RenderGuess(string chute, string palavraAleatoria, int tentativa)
  {
    Console.Write("< ");

    for (int posicao = 0; posicao < chute.Length; posicao++)
    {
      char letraChute = chute[posicao];
      char letraPalavra = palavraAleatoria[posicao];

      if (letraChute == letraPalavra)
        Console.BackgroundColor = ConsoleColor.DarkGreen;

      else if (palavraAleatoria.Contains(letraChute))
        Console.BackgroundColor = ConsoleColor.DarkYellow;

      else
        Console.BackgroundColor = ConsoleColor.DarkRed;

      Console.Write(letraChute);
      Console.ResetColor();
    }

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write($" [{tentativa}] tentativas restantes...");
    Console.ResetColor();
  }

}