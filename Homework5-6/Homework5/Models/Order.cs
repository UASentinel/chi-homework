using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Models
{
    public class Order
    {
        public int OrdId { get; set; }
        public DateTime OrdDateTime { get; set; }
        public Analysis OrdAn { get; set; }
        public Order()
        {
            OrdAn = new Analysis();
        }
        public Order(SqlDataReader reader)
        {
            OrdId = reader.GetInt32(0);
            OrdDateTime = reader.GetDateTime(1);
            OrdAn = new Analysis()
            {
                AnId = reader.GetInt32(2),
                AnName = reader.GetString(4),
                AnCost = reader.GetDecimal(5),
                AnPrice = reader.GetDecimal(6),
                AnGroup = new Group()
                {
                    GrId = reader.GetInt32(8),
                    GrName = reader.GetString(9),
                    GrTemp = reader.GetDecimal(10)
                }
            };
        }
        public Order(DataRow row)
        {
            OrdId = (int)row["ord_id"];
            OrdDateTime = (DateTime)row["ord_datetime"];
            OrdAn = new Analysis()
            {
                AnId = (int)row["an_id"],
                AnName = (string)row["an_name"],
                AnCost = (decimal)row["an_cost"],
                AnPrice = (decimal)row["an_price"],
                AnGroup = new Group()
                {
                    GrId = (int)row["gr_id"],
                    GrName = (string)row["gr_name"],
                    GrTemp = (decimal)row["gr_temp"]
                }
            };
        }
        public void Print()
        {
            Console.WriteLine($"OrdId: {OrdId}");
            Console.WriteLine($"OrdDateTime: {OrdDateTime}");
            Console.WriteLine($"OrdAn: {OrdAn.AnId}");
        }
    }
}
