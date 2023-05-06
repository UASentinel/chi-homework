using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Models
{
    [Table("Orders")]
    public class Order
    {
        [Column("ord_id")]
        public int OrdId { get; set; }

        [Column("ord_datetime")]
        public DateTime OrdDateTime { get; set; }

        [Column("ord_an")]
        public int OrdAnId { get; set; }

        public Analysis OrdAn { get; set; }
        public void Print()
        {
            Console.Write($"Order Id: {OrdId}\tDateTime: {OrdDateTime.ToShortDateString()}\t");
            if (OrdAn != null) Console.WriteLine($"Analysis Name: {OrdAn.AnName}");
            else Console.WriteLine($"Analysis Id: {OrdAnId}");
        }
    }
}
