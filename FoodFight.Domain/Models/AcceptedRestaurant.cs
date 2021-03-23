using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class AcceptedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Accepted Restaurants
        /// </summary>       

        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("user")]
        public object User { get; set; }

        [JsonProperty("restaurant")]
        public object Restaurant { get; set; }

        [JsonProperty("swipeList")]
        public object[] SwipeLists { get; set; }

        //need restaurantID inside the table 

        public virtual SwipeList SwipeList { get; set; }        
        public virtual ICollection<MatchedRestaurant> MatchedRestaurants { get; set; }
    }
}
