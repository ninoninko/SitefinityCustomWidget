using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceXWidget.Mvc.ViewModels
{
    public class LaunchViewModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "launchpad")]
        public string LaunchpadNumber { get; set; }

        [JsonProperty(PropertyName = "links")]
        public LinkViewModel Links { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }

    public class LinkViewModel
    {
        public PatchViewModel Patch { get; set; }

        [JsonProperty(PropertyName = "webcast")]
        public string VideoToWatch { get; set; }
    }

  
    public class PatchViewModel
    {
        [JsonProperty(PropertyName = "large")]
        public string Large { get; set; }

        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }
    }
}