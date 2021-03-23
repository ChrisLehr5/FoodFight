using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class RejectedRestaurant : DomainObject
    {
        /// <summary>
        /// Join Table for Rejected Restaurants
        /// </summary>      

        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }
        
        [JsonProperty("user")]
        public object UserId { get; set; }       
        
        public virtual SwipeList SwipeList { get; set; }
    }
}
