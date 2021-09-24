using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosWebApp.Models
{
    public class ClothesWebModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
        [JsonProperty(PropertyName = "price")]
        public double Price { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }
}
