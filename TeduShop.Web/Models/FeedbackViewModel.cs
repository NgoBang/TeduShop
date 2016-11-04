using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Web.Models
{
    public class FeedbackViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Tên phải nhập")]
        [MaxLength(250, ErrorMessage = "Tên không được quá 250 kí tự")]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "Email không được quá 250 kí tự")]
        public string Email { get; set; }

        [MaxLength(500, ErrorMessage = "Tin nhắn không được quá 500 kí tự")]
        public string Message { get; set; }

        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "Phải nhập trang thái")]
        public bool Status { get; set; }

        public ContactDetailViewModel ContactDetail { get; set; }
    }
}