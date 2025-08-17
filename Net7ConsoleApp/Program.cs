namespace Net7ConsoleApp;

internal class Program
{
  static async Task Main(string[] args)
  {
    AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
    {
      Console.WriteLine($"Resolving: {args.Name}");
      return null;
    };

    Console.WriteLine("Press ENTER to call async service");
    Console.ReadLine();
    await PerformServiceTaskAsync();

    Console.WriteLine("Press ENTER to exit");
    Console.ReadLine();
  }


  static async Task PerformServiceTaskAsync()
  {
    await using var service = new Netstandard20ClassLibrary.Service();
    await service.PerformServiceAsync();
  }
}
