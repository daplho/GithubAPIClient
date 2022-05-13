using System.Text.Json.Serialization;

namespace GithubAPIClient {
    public class Repository {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("html_url")]
        public Uri GithubHomeUrl { get; set; }

        [JsonPropertyName("homepage")]
        public Uri Homepage { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("pushed_at")]
        public DateTime LastPushUtc { get; set; }

        public DateTime LastPush => LastPushUtc.ToLocalTime();

        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }
    }
}