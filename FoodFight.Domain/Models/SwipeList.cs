using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodFight.Domain.Models
{
    public class SwipeList : DomainObject
    {     

        [JsonProperty("swipeLists")]
        public object[] SwipeLists { get; set; }

        [JsonProperty("restaurant")]
        public object RestaurantId { get; set; }             

       
        public virtual MatchSession MatchSession { get; set; }
        
        public virtual Restaurant Restaurant { get; set; }
    
        public virtual ICollection<AcceptedRestaurant> AcceptedRestaurants { get; set; }
       
        public virtual ICollection<RejectedRestaurant> RejectedRestaurants { get; set; }
    }
}
