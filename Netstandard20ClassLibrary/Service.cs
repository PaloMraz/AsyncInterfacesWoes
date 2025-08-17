using System;
using System.Threading.Tasks;

namespace Netstandard20ClassLibrary;

public class Service : IAsyncDisposable
{
  public Service() { }


  public ValueTask DisposeAsync()
  {
    return new ValueTask(Task.CompletedTask);
  }


  public Task PerformServiceAsync()
  {
    return Task.CompletedTask;
  }

}
