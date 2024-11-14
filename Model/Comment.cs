using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Comment
    {
        public int Id { get; set;}
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; } // this is the key connecting to the model
        public Stock? Stock { get; set; } //Nvigation property-helps us access properties of the Model
    }
}