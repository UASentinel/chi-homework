using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Models
{
    public class Analysis
    {
        public int AnId { get; set; }
        public string AnName { get; set; }
        public decimal AnCost { get; set; }
        public decimal AnPrice { get; set; }
        public Group AnGroup { get; set; }
    }
}
