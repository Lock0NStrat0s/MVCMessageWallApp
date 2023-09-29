using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCMessageWall.Controllers
{
    public class MessageWallController : Controller
    {
        // GET: MessageWallController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageWallController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageWallController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageWallController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageWallController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageWallController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageWallController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageWallController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
