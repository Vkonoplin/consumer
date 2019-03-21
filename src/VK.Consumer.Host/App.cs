using System;
using System.Threading;
using Microsoft.Extensions.Hosting;

namespace VK.Consumer.Host
{
    public class App
    {
        private readonly CancellationToken _cancellationToken;

        public App(IApplicationLifetime applicationLifetime)
        {
            _cancellationToken = applicationLifetime.ApplicationStopping;
        }

        public void Run()
        {
            Console.WriteLine("Hello Consumer Hosted Service");
        }
    }
}
