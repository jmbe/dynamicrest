﻿// Services.cs
//

using System;

namespace Application {

    internal static class Services {

        public const string FlickrUri = "http://api.flickr.com/services/rest/?method=flickr.{operation}&api_key={apiKey}&format=json&nojsoncallback=1";
        public const string FlickrApiKey = "???";

        public const string AmazonUri = "http://ecs.amazonaws.com/onca/xml?Service=AWSECommerceService&Version=2009-03-31&Operation={operation}&AssociateTag=myamzn-20";
        public const string AmazonAccessKey = "???";
        public const string AmazonSecretKey = "???";

        public const string BingSearchUri = "http://api.bing.net/json.aspx?AppId={appID}&Version=2.2&Market=en-US";
        public const string BingApiKey = "???";

        public const string GoogleSearchUri = "http://ajax.googleapis.com/ajax/services/search/web?v=1.0";
    }
}
