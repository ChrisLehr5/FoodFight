using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace FoodFight.Domain.Models
{
    public class UserSetting : DomainObject
    {
        [JsonProperty("settingsId")]
        public Guid SettingsId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("userSettings")]
        public object[] UserSettings { get; set; }

        public virtual User User { get; set; }
    }
}
