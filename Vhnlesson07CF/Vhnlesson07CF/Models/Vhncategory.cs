using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vhnlesson07CF.Models
{
    public class Vhncategory
    {
        public int VhnId { get; set; }

        public string VhncategoryName { get; set; }

        //thuoc tinh quan he
        public virtual ICollection<VhnBook> VhnBooks { get; set; }
    }
}