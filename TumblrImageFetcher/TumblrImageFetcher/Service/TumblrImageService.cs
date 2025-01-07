using TumblrImageFetcher.Client;
using TumblrImageFetcher.Utility;

namespace TumblrImageFetcher.Service
{
    public class TumblrImageService
    {
        private readonly TumblrApiClient _apiClient;
        private readonly TumblrJsonParser _jsonParser;

        public TumblrImageService()
        {
            _apiClient = new TumblrApiClient();
            _jsonParser = new TumblrJsonParser();
        }

        public async Task runAsync()
        {
            Console.Write("Enter the Tumblr blog name (e.g. good): ");
            string blogName = Console.ReadLine();
            Console.Write("Enter the post range (e.g. 1-5): ");
            string postRange = Console.ReadLine();

            var rangeParts = postRange.Split('-');
            int startPost = int.Parse(rangeParts[0]);
            int endPost = int.Parse(rangeParts[1]);

            string rawResponse = await _apiClient.fetchBlogPostsAsync(blogName, startPost, endPost - startPost + 1);

            if (!string.IsNullOrEmpty(rawResponse))
            {
                string cleanResponse = _jsonParser.cleanJsonResponse(rawResponse);

                if (!string.IsNullOrEmpty(cleanResponse))
                {
                    _jsonParser.parseAndDisplayBlogInfo(cleanResponse, startPost, endPost);
                }
                else
                {
                    Console.WriteLine("Invalid JSON response from Tumblr API.");
                }
            }
        }
    }
}
