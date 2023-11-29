using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Receiving Form Data
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost] // Điều này chỉ định rằng phương thức này chỉ xử lý các yêu cầu HTTP POST.
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: Lưu trữ phản hồi từ khách
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse); // Gọi phương thức AddResponse từ Repository để lưu trữ thông tin từ đối tượng guestResponse.            return View("Thanks", guestResponse); // Chuyển hướng đến view có tên "Thanks" và chuyển đối tượng guestResponse đến view để hiển thị thông tin cảm ơn.
                return View("Thanks", guestResponse); // Chuyển hướng đến view có tên "Thanks" và chuyển đối tượng guestResponse đến view để hiển thị thông tin cảm ơn.
            }
            else
            {
                return View();
            }

        }
        #endregion
        public ViewResult ListResponses()
        {
            // Trả về view chứa danh sách các phản hồi từ khách mời có ý chấp nhận tham dự (WillAttend == true).
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }


    }
}