using Newtonsoft.Json;
using System;

namespace RssClient
{
    class RssFeedDataDto
    {
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "Link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "PublicationDate")]
        public DateTime PublicationDate { get; set; }

        public override string ToString()
        {
            var title = "\t" + Title + "\n";
            var description = Description + "\n";
            var creationTime = "\t\t" + PublicationDate + "\n";
            var url = Link + "\n\n";

            return title + description + creationTime + url;
        }
    }
}
