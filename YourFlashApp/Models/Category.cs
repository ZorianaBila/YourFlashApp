using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFlashApp.Models
{
    class Category
    {
        [Newtonsoft.Json.JsonProperty("Category_Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Category_Name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Category_Color")]
        public Color Color { get; set; }
    }
}
