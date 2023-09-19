namespace USD_to_BGN
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //1 USD = 1.79549 BGN.
      double oneUsd = 1.79549;
      double usd = double.Parse(Console.ReadLine());
      double convertBgn = usd * oneUsd;
      Console.WriteLine(convertBgn);
    }
  }
}