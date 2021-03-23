using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class MatchedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Matched Restaurants during matching session
        /// </summary>

        [JsonProperty("acceptedRestaurant")]
        public object RestaurantId { get; set; }

        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        public virtual AcceptedRestaurant AcceptedRestaurant { get; set; }
    }
}
