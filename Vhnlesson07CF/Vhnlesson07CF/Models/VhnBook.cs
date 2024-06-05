using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vhnlesson07CF.Models
{
    public class VhnBook
    {
        public int VhnId { get; set; }

        public string VhnTitle { get; set; }

        public string VhnAuthor { get; set; }

        public int VhnYear { get; set; }

        public string VhnPulisher { get; set; }

        public string VhnCategoryId { get; set; }

        //thuoc tinhs quan he
        public virtual Vhncategory Vhncategory { get; set; }
    }
}