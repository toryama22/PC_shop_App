using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    class Supplier
    {
        public long Id { get; }
        public string FIO { get; set; }
        public int INN { get; set; }
        public string Adress { get; set; }
        public long Phone { get; set; }
    }
}
