//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geekshirt.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articles
    {
        public Articles()
        {
            this.ShopLists = new HashSet<ShopLists>();
        }
    
        public int ArticleID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }
    
        public virtual ICollection<ShopLists> ShopLists { get; set; }
    }
}
