using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class BlockedRestaurant : DomainObject
    {

        [JsonProperty("restaurant")]
        public object Restaurant { get; set; }

        [JsonProperty("user")]
        public object User { get; set; }
       
        //public virtual Restaurant Restaurant { get; set; }       
     
        //public virtual User User { get; set; }
    }
}
