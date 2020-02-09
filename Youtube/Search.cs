using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace SGTubeMVC.Youtube
{
  public class Search
  {
    //[STAThread]
    //static void Main(string[] args)
    //{
    //  Console.WriteLine("YouTube Data API: Search");
    //  Console.WriteLine("========================");

    //  try
    //  {
    //    new Search().Run().Wait();
    //  }
    //  catch (AggregateException ex)
    //  {
    //    foreach (var e in ex.InnerExceptions)
    //    {
    //      Console.WriteLine("Error: " + e.Message);
    //    }
    //  }

    //  Console.WriteLine("Press any key to continue...");
    //  Console.ReadKey();
    //}

    public async Task<SearchListResponse> YoutubeApi_Search(string termo)
    {
      var youtubeService = new YouTubeService(new BaseClientService.Initializer()
      {
        ApiKey = "AIzaSyBVn68RQa7aeSAJKAcHYAGXNdbtc4J1l0I",
        ApplicationName = this.GetType().ToString()
      });

      var searchListRequest = youtubeService.Search.List("snippet");
      searchListRequest.Q = termo; // Replace with your search term.
      searchListRequest.MaxResults = 50;

      // Call the search.list method to retrieve results matching the specified query term.
      return await searchListRequest.ExecuteAsync();

      //var videos = new List<string>();
      //var channels = new List<string>();
      //var playlists = new List<string>();

      //foreach (var searchResult in searchListResponse.Items)
      //{
      //  switch (searchResult.Id.Kind)
      //  {
      //    case "youtube#video":
      //      videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
      //      break;

      //    case "youtube#channel":
      //      channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
      //      break;

      //    case "youtube#playlist":
      //      playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
      //      break;
      //  }
      }
    }
  }
