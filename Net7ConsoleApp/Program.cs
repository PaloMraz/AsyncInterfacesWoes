namespace Net7ConsoleApp;

internal class Program
{
  static async Task Main(string[] args)
  {
    Console.WriteLine("Press ENTER to call async service");
    Console.ReadLine();
    await PerformServiceTaskAsync();
  }


  static async Task PerformServiceTaskAsync()
  {
    await using var service = new Netstandard20ClassLibrary.Service();
    await service.PerformServiceAsync();
  }
}
