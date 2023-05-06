using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework6.Models
{
    [Table("Analyzes")]
    public class Analysis
    {
        [Column("an_id")]
        public int AnId { get; set; }

        [Column("an_name")]
        public string AnName { get; set; }

        [Column("an_cost")]
        public decimal AnCost { get; set; }

        [Column("an_price")]
        public decimal AnPrice { get; set; }

        [Column("an_group")]
        public int AnGroupId { get; set; }

        public Group AnGroup { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
