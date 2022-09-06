using System.Text.Encodings.Web;

namespace AspNetCoreBackgroundService.BackgroundServices
{
    public class CounterBackgroudService : BackgroundService
    {
        private int Counter = 1;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Counter++;
                Console.WriteLine($"counter : {Counter}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
