using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vhnlesson07CF.Models
{
    public class VhnbookStore:DbContext 
    {
        public VhnbookStore():base() { }

        //khai bao cac thuoc tinh tuong ung voi cac bang trong csdl

        public DbSet<Vhncategory> Vhncategories { get; set; }

        public DbSet<VhnBook> VhnBooks { get; set; }
    }
}