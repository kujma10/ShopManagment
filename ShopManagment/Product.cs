//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopManagment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Balances = new HashSet<Balance>();
        }
    
        public int ID { get; set; }
        public int CatID { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public Nullable<double> Price { get; set; }
        public bool Disabled { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Balance> Balances { get; set; }
    }
}
