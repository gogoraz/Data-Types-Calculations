namespace RAD_to_DEG
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //degree = radian * 180 / π --- π = Math.PI 

      double rad = double.Parse(Console.ReadLine());
      double deg = rad * (180 / Math.PI);
      Console.WriteLine(Math.Round(deg, 13));
    }
  }
}