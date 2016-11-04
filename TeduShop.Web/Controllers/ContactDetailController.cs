using AutoMapper;
using BotDetect.Web.Mvc;
using System.Text;
using System.Web.Mvc;
using TeduShop.Common;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Extensions;
using TeduShop.Web.Models;

namespace TeduShop.Web.Controllers
{
    public class ContactDetailController : Controller
    {
        private IContactDetailService _contactDetailService;
        private IFeedBackService _feedBackService;

        public ContactDetailController(IContactDetailService contactDetailService, IFeedBackService feedBackService)
        {
            _contactDetailService = contactDetailService;
            _feedBackService = feedBackService;
        }

        // GET: ContactDetail
        public ActionResult Index()
        {
            FeedbackViewModel feedBackViewModel = new FeedbackViewModel();
            feedBackViewModel.ContactDetail = GetDetail();
            return View(feedBackViewModel);
        }

        [HttpPost]
        [CaptchaValidation("CaptchaCode", "contactCaptcha", "Mã xác nhận không đúng!")]
        public ActionResult SendFeedback(FeedbackViewModel feedBackViewModel)
        {
            if (ModelState.IsValid)
            {
                Feedback newFeedBack = new Feedback();
                newFeedBack.UpdateFeedBack(feedBackViewModel);
                _feedBackService.Create(newFeedBack);
                _feedBackService.Save();

                ViewData["SuccessMsg"] = "Gửi phản hồi thành công";
                

                string content = System.IO.File.ReadAllText(Server.MapPath("/Assets/client/template/contact_template.html"));
                content = content.Replace("{{Name}}", feedBackViewModel.Name);
                content = content.Replace("{{Email}}", feedBackViewModel.Email);
                content = content.Replace("{{Message}}", feedBackViewModel.Message);
                var adminEmail = ConfigHelper.GetByKey("AdminEmail");
                MailHelper.SendMail(adminEmail, "Thông tin liên hệ từ website", content);

                feedBackViewModel.Name = string.Empty;
                feedBackViewModel.Message = string.Empty;
                feedBackViewModel.Email = string.Empty;
            }
            feedBackViewModel.ContactDetail = GetDetail();
            return View("Index", feedBackViewModel);
        }

        private ContactDetailViewModel GetDetail()
        {
            var model = _contactDetailService.GetDefaultContact();
            var contactViewModel = Mapper.Map<ContactDetail, ContactDetailViewModel>(model);
            return contactViewModel;
        }
    }
}