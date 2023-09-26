namespace Connector.Models
{
    public class RequestModel
    {
        public string Method { get; set; }
        public string Uri { get; set; }
        public List<Header> Headers { get; set; }
        public List<Parameter> Parameters { get; set; }
    }

    public class Header
    {
        [JsonProperty("app-id")]
        public string appid { get; set; }
    }

    public class Parameter
    {
        [JsonProperty("app-id")]
        public string appid { get; set; }
    }
}