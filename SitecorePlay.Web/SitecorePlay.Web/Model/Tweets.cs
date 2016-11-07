using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SitecorePlay.Web.Model
{
    public class Tweets
    {
        /// <summary>
        /// A User's username. eg: "sergiotapia, mrkibbles, matumbo"
        /// </summary>
        [JsonProperty("ScreenName")]
        public string ScreenName { get; set; }

        /// <summary>
        /// A User's name. eg: "Sergio Tapia, John Cosack, Lucy McMillan"
        /// </summary>
        [JsonProperty("TextAsHtml")]
        public string TextAsHtml { get; set; }

        /// <summary>
        /// A User's location. eh: "Bolivia, USA, France, Italy"
        /// </summary>
        [JsonProperty("Day")]
        public string Day { get; set; }

        [JsonProperty("Month")]
        public string Month { get; set; } 

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("ProfileImageUrl")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("MediaUrl")]
        public string MediaUrl { get; set; } 

     

    }
}