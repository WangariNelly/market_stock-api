using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty; //the empty makes sure that input to db is not null
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] //this makes sure that any purchase input is of length 18 and 2decimal points
        public decimal Purchase { get; set;}
         [Column(TypeName = "decimal(18,2)")] public decimal LastDiv { get; set; }
         public string Industry { get; set; } = string.Empty;
         public long MarketCap { get; set; }
         public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}