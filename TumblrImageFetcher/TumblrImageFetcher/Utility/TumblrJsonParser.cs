using Newtonsoft.Json.Linq;

namespace TumblrImageFetcher.Utility
{
    public class TumblrJsonParser
    {
        public string cleanJsonResponse(string response)
        {
            int jsonStart = response.IndexOf("{");
            int jsonEnd = response.LastIndexOf("}");

            if (jsonStart != -1 && jsonEnd != -1)
            {
                return response.Substring(jsonStart, jsonEnd - jsonStart + 1);
            }

            return string.Empty; // Return empty if no valid JSON part is found
        }

        public void parseAndDisplayBlogInfo(string response, int startPost, int endPost)
        {
            try
            {
                var root = JObject.Parse(response);

                var blogInfo = root["tumblelog"];
                Console.WriteLine($"Title: {blogInfo["title"]}");
                Console.WriteLine($"Name: {blogInfo["name"]}");
                Console.WriteLine($"Description: {blogInfo["description"]}");

                int totalPosts = root["posts-total"].ToObject<int>();
                Console.WriteLine($"Total number of posts: {totalPosts}\n");

                var posts = root["posts"];
                int postCount = posts.Count();

                for (int i = 0, j = startPost; i < postCount && j <= endPost; i++, j++)
                {
                    var post = posts[i];
                    Console.Write($"{j}. ");

                    bool hasImage = false;
                    if (post["photo-url-1280"] != null)
                    {
                        string photoUrl = post["photo-url-1280"].ToString();
                        Console.WriteLine(photoUrl);
                        hasImage = true;
                    }

                    if (!hasImage)
                    {
                        Console.WriteLine("No images found in this post.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
            }
        }
    }
}
