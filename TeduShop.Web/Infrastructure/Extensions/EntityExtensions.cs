﻿using System;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.CreateDate = postCategoryViewModel.CreateDate;
            postCategory.CreateBy = postCategoryViewModel.CreateBy;
            postCategory.UpdatedDate = postCategoryViewModel.UpdatedDate;
            postCategory.UpdateBy = postCategoryViewModel.UpdateBy;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.Status = postCategoryViewModel.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.CategoryID = postViewModel.CategoryID;
            post.Image = postViewModel.Image;
            post.Description = postViewModel.Description;
            post.Content = postViewModel.Content;
            post.HomeFlag = postViewModel.HomeFlag;
            post.ViewCount = postViewModel.ViewCount;
            post.CreateDate = postViewModel.CreateDate;
            post.CreateBy = postViewModel.CreateBy;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.UpdateBy = postViewModel.UpdateBy;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.MetaDescription = postViewModel.MetaDescription;
            post.Status = postViewModel.Status;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryViewModel)
        {
            productCategory.ID = productCategoryViewModel.ID;
            productCategory.Name = productCategoryViewModel.Name;
            productCategory.Alias = productCategoryViewModel.Alias;
            productCategory.Description = productCategoryViewModel.Description;
            productCategory.ParentID = productCategoryViewModel.ParentID;
            productCategory.DisplayOrder = productCategoryViewModel.DisplayOrder;
            productCategory.Image = productCategoryViewModel.Image;
            productCategory.HomeFlag = productCategoryViewModel.HomeFlag;
            productCategory.CreateDate = productCategoryViewModel.CreateDate;

            productCategory.CreateBy = productCategoryViewModel.CreateBy;
            productCategory.UpdatedDate = productCategoryViewModel.UpdatedDate;
            productCategory.UpdateBy = productCategoryViewModel.UpdateBy;
            productCategory.MetaKeyword = productCategoryViewModel.MetaKeyword;
            productCategory.MetaDescription = productCategoryViewModel.MetaDescription;
            productCategory.Status = productCategoryViewModel.Status;
        }

        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
            product.ID = productViewModel.ID;
            product.Name = productViewModel.Name;
            product.Alias = productViewModel.Alias;
            product.CategoryID = productViewModel.CategoryID;
            product.Image = productViewModel.Image;
            product.MoreImages = productViewModel.MoreImages;
            product.Price = productViewModel.Price;
            product.PromotionPrice = productViewModel.PromotionPrice;
            product.Warranty = productViewModel.Warranty;
            product.Description = productViewModel.Description;
            product.Content = productViewModel.Content;
            product.HomeFlag = productViewModel.HomeFlag;
            product.HotFlag = productViewModel.HotFlag;
            product.ViewCount = productViewModel.ViewCount;
            product.CreateDate = productViewModel.CreateDate;
            product.CreateBy = productViewModel.CreateBy;
            product.UpdatedDate = productViewModel.UpdatedDate;
            product.UpdateBy = productViewModel.UpdateBy;
            product.MetaKeyword = productViewModel.MetaKeyword;
            product.MetaDescription = productViewModel.MetaDescription;
            product.Status = productViewModel.Status;
            product.Tags = productViewModel.Tags;
            product.Quantity = productViewModel.Quantity;
        }

        public static void UpdateFeedBack(this Feedback feedBack, FeedbackViewModel feedBackViewModel)
        {
            feedBack.Name = feedBackViewModel.Name;
            feedBack.Email = feedBackViewModel.Email;
            feedBack.Message = feedBackViewModel.Message;
            feedBack.Status = feedBackViewModel.Status;
            feedBack.CreateDate = DateTime.Now;
        }
    }
}