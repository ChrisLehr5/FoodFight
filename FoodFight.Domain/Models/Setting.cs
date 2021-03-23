using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class Setting : DomainObject
    {
      
        [JsonProperty("userSettings")]
        public object[] userSettings { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public bool Enabled { get; set; }
               
        public virtual ICollection<UserSetting> UserSettings { get; set; }
    }
}
