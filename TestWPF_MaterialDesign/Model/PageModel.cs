using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPF_MaterialDesign.Model
{
    public class PageModel
    { 
        public int  CustomerCount { get; set; }
        public string CustomerStatus { get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal TransactionValue { get; set; }
        public TimeOnly ShirmentDelivery { get; set; }
        public bool LocationStatus { get; set; }
        public string ProductStatus { get; set; }
    }
}
