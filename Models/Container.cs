using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP02SWII.Models
{
    public class Container
    {
        public int ContainerId { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public int BLId { get; set; }
        public BL BL { get; set; }

    }
}
