using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    class Contract
    {
        public int Id { get; set; }
        public int NumberOfContract { get; set; }
        public DateTime Date { get; set; }
        public int Menejer { get; set; }
        public int TheSupplier { get; set; }
    }
}
