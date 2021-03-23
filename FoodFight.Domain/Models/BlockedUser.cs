using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class BlockedUser : DomainObject
    {
        /// <summary>
        /// Many to Many Table for Blocked Users
        /// </summary>

        [JsonProperty("baseUser")]
        public object BaseUser { get; set; }

        [JsonProperty("blockedUserNavigation")]
        public object BlockedUserNavigation { get; set; }
        
        
        //public virtual User BaseUser { get; set; }    
       
        //public virtual User BlockedUserNavigation { get; set; }

    }
}
