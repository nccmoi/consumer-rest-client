using Newtonsoft.Json.Linq;
using RestSharp.Authenticators.OAuth2;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Connector.Models;

namespace Connector.APIHelper.APIRequest
{
    public class RequestBuilder
    {
        private AppSettings _settings;
        public RequestBuilder(AppSettings settings)
        {
            _settings = settings;
        }

        public AbstractRequest BuildRequest() => _settings.Method switch
        {
            Method.Get => GetRequest(),
            Method.Post => PostRequest(),
            Method.Delete => DeleteRequest(),
            Method.Put => PutRequest(),
            _ => throw new ArgumentException(message: "invalid method type", paramName: nameof(_settings.Method)),
        };

        private AbstractRequest GetRequest()
        {
            // GET end point URL
            string getUrl = "/data/v1/user";

            return new GetRequestBuilder()
                  .WithUrl(getUrl)
                  .WithHeaders(new Dictionary<string, string>()
                  {
                    { "Accept", "application/json"},
                    { "Content-Type", "application/json" },
                    { "app-id","650c72958b4bf3217aef1cc6" }
                  });
        }

        private AbstractRequest PostRequest()
        {
            return null;
        }
        
        private AbstractRequest PutRequest()
        {
            return null;
        }
        private AbstractRequest DeleteRequest()
        {
            return null;
        }
    }
}
