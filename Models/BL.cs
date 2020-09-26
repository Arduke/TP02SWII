using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP02SWII.Models
{
    public class BL
    {
        public int BLId { get; set; }
        public int Number { get; set; }
        public string Consignee { get; set; }
        public string Ship { get; set; }
        public List<Container> Containers { get; } = new List<Container>();


    
    }
}
