using TumblrImageFetcher.Service;

namespace TumblrImageFetcher
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var app = new TumblrImageService();
            await app.runAsync();
        }
    }
}
