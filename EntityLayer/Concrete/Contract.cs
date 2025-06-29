using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contract

    {
        public int ContractId { get; set; }
        public string Desription { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string MapLocaion { get; set; }
        public bool Status { get; set; }
    }
}
