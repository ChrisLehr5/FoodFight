using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class MatchSession : DomainObject 
    {
        /// <summary>
        /// Join Table for Session Data
        /// </summary>
    
        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }

        [JsonProperty("connectedUser")]
        public object ConnectedUserId { get; set; }        
        
        public virtual ConnectedUser ConnectedUser { get; set; }
      
        public virtual ICollection<SwipeList> SwipeLists { get; set; }
    }
}
