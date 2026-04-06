static class Renderer
{
  public static void RenderGuess(string userGuess, string word, int remainingAttempts)
  {
    Console.Write("< ");

    for (int position = 0; position < userGuess.Length; position++)
    {
      char guessLetter = userGuess[position];
      char wordLetter = word[position];

      if (guessLetter == wordLetter)
        Console.BackgroundColor = ConsoleColor.DarkGreen;

      else if (word.Contains(guessLetter))
        Console.BackgroundColor = ConsoleColor.DarkYellow;

      else
        Console.BackgroundColor = ConsoleColor.DarkRed;

      Console.Write(guessLetter);
      Console.ResetColor();
    }

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write($" [{remainingAttempts}] tentativas restantes...");
    Console.ResetColor();
  }

  public static void RenderSuccessMessage(string userGuess)
  {
    Console.Write("< ");
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(userGuess);
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("\n🎉 Parabéns! Você acertou!");
    Console.WriteLine("Digite ENTER para continuar...");
    Console.ReadLine();
  }

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

}