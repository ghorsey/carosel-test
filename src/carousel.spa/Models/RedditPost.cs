
namespace carousel.spa.Models
{
    using System.Collections.Generic;

    public class RedditWrapper
    {
        public RedditData Data{ get; set;}
    }

    public class RedditData
    {
        public List<RedditDataItem> Children{ get; set;}
    }

    public class RedditDataItem
    {        
        public RedditPost Data { get; set; }
    }


    public class RedditPost
    {
        public string Title{ get; set; }
        public RedditPreview Preview{ get; set;}
    }

    

    public class RedditPreview {
        public List<RedditImage> Images{ get; set;}
    }


    public class RedditImage
    {
        public RedditImageData Source { get; set; }
    }

    public class RedditImageData {
        public string Url { get; set; }
    }
}