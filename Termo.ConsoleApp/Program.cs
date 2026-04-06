namespace Termo.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    int maxAttempts = 5;
    bool playing = true;

    while (playing)
      playing = Game.Start(maxAttempts);
  }

}