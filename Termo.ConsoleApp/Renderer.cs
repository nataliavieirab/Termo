static class Renderer
{
  public static void Classifier(string chute, string palavraAleatoria, int tentativa)
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