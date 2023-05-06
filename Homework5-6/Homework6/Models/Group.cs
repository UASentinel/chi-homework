using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Models
{
    [Table("Groups")]
    public class Group
    {
        [Column("gr_id")]
        public int GrId { get; set; }

        [Column("gr_name")]
        public string GrName { get; set; }

        [Column("gr_temp")]
        public decimal GrTemp { get; set; }

        public ICollection<Analysis> Analyzes { get; set;}
    }
}
