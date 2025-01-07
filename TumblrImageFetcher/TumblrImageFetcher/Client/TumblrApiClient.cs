
namespace TumblrImageFetcher.Client
{
    public class TumblrApiClient
    {
        private readonly HttpClient _httpClient;

        public TumblrApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> fetchBlogPostsAsync(string blogName, int startPost, int numPosts)
        {
            string apiUrl = $"https://{blogName}.tumblr.com/api/read/json?type=photo&num={numPosts}&start={startPost - 1}";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            Console.WriteLine($"Request failed with status: {response.StatusCode}");
            return string.Empty;
        }
    }
}
