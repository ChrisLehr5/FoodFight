using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class ConnectedUser : DomainObject
    {
        /// <summary>
        /// Many to Many Table for Connected Users
        /// </summary>

        [JsonProperty("baseUser")]
        public Guid BaseUserId { get; set; }

        [JsonProperty("friendUser")]
        public Guid FriendUserId { get; set; }        

        public virtual User BaseUser { get; set; }      
        public virtual User FriendUser { get; set; }        
        public virtual ICollection<MatchSession> MatchSessions { get; set; }
    }
}
