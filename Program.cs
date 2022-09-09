namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Please enter a secret message you would like encrypted: ");
      string secretString = Console.ReadLine();

      char[] secretMessage = new char [secretString.Length];

      char[] encryptedMessage = new char [secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        
      }
    }
  }
}