using System.Net;

namespace MyCodeLibrary;

public class Scrape
{
    public string ScrapeWebpage(string url)
    {
        return GetWebpage(url);
    }

    public string ScrapeWebpage(string url, string filepath)
    {
        string reply = GetWebpage(url);
        
        Console.WriteLine(reply);
        File.WriteAllText("~/Developer/CSharp/Fundamentals/MyCodeLibrary/WriteText.txt", reply);
        return reply;
    }
    
    private string GetWebpage(string url)
    {
        WebClient client = new WebClient();
        return client.DownloadString(url);
    }
}