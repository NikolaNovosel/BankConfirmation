using BankConfirmation_DTO;
using BankConfirmation_UI_MVC.REST;
using BankConfirmations_BLL;
using Microsoft.AspNetCore.Mvc;

namespace BankConfirmation_UI_MVC.Controllers
{
    public class CreditController : Controller
    {
        // GET: CreditController
        public ActionResult Index()
        {
            CreditRest creditRest = new();
            return View(creditRest.GetAll());
        }

        // GET: CreditController/Details/5
        public ActionResult Details(int id)
        {
            CreditRest creditRest = new();
            var result = creditRest.GetById(id);
            if (result==null) return NotFound();
            return View(result);
        }

        // GET: CreditController/Create
        public ActionResult Create()
        {
            Credit credit = new();
            return View(credit);
        }

        // POST: CreditController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Credit credit)
        {
            CreditRest creditRest = new();

            if (ModelState.IsValid)
            {
                try
                {
                    creditRest.Insert(credit);

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                }
            }
            return View();
        }

        // GET: CreditController/Edit/5
        public ActionResult Edit(int id)
        {
            CreditRest creditRest = new();
            var result = creditRest.GetById(id);
            if (result==null) return NotFound();
            return View(result);
        }

        // POST: CreditController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Credit credit)
        {
            CreditRest creditRest = new();
            try
            {
                creditRest.Update(credit);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditController/Delete/5
        public ActionResult Delete(int id)
        {
            CreditRest creditRest = new();
            var result = creditRest.GetById(id);
            if (result==null) return NotFound();
            return View(result);
        }

        // POST: CreditController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Credit credit)
        {
            CreditRest creditRest = new();
            if (id!=credit.Id) return NotFound();
            try
            {
                creditRest.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
