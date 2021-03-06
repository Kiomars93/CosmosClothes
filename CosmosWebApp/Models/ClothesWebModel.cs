using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CosmosWebApp.Models
{
    public class ClothesWebModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "title")]
        [Required]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "description")]
        [Required]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "color")]
        [Required]
        public string Color { get; set; }
        [JsonProperty(PropertyName = "price")]
        [Required]
        public double Price { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }
}