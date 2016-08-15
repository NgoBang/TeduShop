using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { get; set; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}