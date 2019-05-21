using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
   public  class Character
    {  
      [JsonProperty("_id")]
      public string Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }
    public override string ToString()
    {
      return Name;
    }
  }

}
