using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using MessageBoardSample.Models;

namespace MessageBoardSample.Controllers
{
    public class HomeController : Controller
    {
        readonly MessageBoardModel db = new MessageBoardModel();

        [HttpGet]
        public ActionResult Index()
        {
            return View(new IndexModel
            {
                Posted = db.Messages
            });
        }

        [HttpPost]
        public async Task<ActionResult> Index(IndexModel model)
        {
            if (ModelState.IsValid)
            {
                var newMessage = model.Input;
                newMessage.Posted = DateTime.UtcNow;
                db.Messages.Add(newMessage);
                await db.SaveChangesAsync();

                ModelState.Clear();
                ViewBag.Posted = true;
            }

            return View(new IndexModel
            {
                Posted = db.Messages
            });
        }
    }
}
