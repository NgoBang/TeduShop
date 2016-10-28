using System;

namespace TeduShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdateBy { set; get; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
        public string Tags { get; set; }
        public int Quantity { get; set; }
        public virtual ProductCategoryViewModel ProductCategory { get; set; }
    }
}