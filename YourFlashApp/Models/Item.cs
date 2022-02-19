using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFlashApp.Models
{
    public class Item
    {
        [Newtonsoft.Json.JsonProperty("Item_Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("English")]
        public string EngWord { get; set; }

        [Newtonsoft.Json.JsonProperty("Ukrainian")]
        public string UkrWord { get; set; }

        [Newtonsoft.Json.JsonProperty("Example")]
        public string ExampleSentence { get; set; }

        [Newtonsoft.Json.JsonProperty("Category")]
        public string Category { get; set; }

        [Newtonsoft.Json.JsonProperty("IsLerned")]
        public bool IsLerned { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("IsRemembered")]
        public int IsRemembered { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("Date")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
