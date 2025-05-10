using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pokemon_API.Entities
{
    public class AbilityWrapper
    {
        [JsonPropertyName("ability")]
        public Ability Ability { get; set; }
    }
}
