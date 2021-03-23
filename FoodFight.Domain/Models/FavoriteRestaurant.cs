using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class FavoriteRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for favorite restaurants
        /// </summary>

        [JsonProperty("restaurant")]
        public Guid RestaurantId { get; set; }

        [JsonProperty("user")]
        public Guid UserId { get; set; }

       
        public virtual Restaurant Restaurant { get; set; }      
        public virtual User User { get; set; }
    }
}
