using System;
using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
        public virtual IEnumerable<ProductCategoryViewModel> Posts { get; set; }
    }
}