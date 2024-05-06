using BankConfirmation_DTO;
using BankConfirmation_UI_MVC.REST;
using Microsoft.AspNetCore.Mvc;

namespace BankConfirmation_UI_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Index()
        {
            AccountRest accountRest = new ();
            return View(accountRest.GetAll());
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            AccountRest accountRest = new(); 
            var result = accountRest.GetById(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            Account account = new();
            return View(account);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Account account)
        {
            AccountRest accountRest = new();
            if (ModelState.IsValid)
            {
                try
                {
                    accountRest.Insert(account);
                    
                    var e = new Exception();

                    ViewBag.ErrorMessage = e.Message;

                    return View();
                    
                    //return RedirectToAction(nameof(Index));
                }
                catch(Exception e)
                {
                    ViewBag.ErrorMessage = e.Message;
                    return View();
                }
            }
            return View();
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            AccountRest accountRest = new();
            var result = accountRest.GetById(id);
            if (result==null) return NotFound();
            return View(result);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Account account)
        {
            AccountRest accountRest = new();
            if (ModelState.IsValid)
            {
                try
                {
                    accountRest.Update(account);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex;
                }
            }
            return View();
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            AccountRest accountRest = new();
            var result = accountRest.GetById(id);
            if (result==null) return NotFound();
            return View(result);
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Account account)
        {
            AccountRest accountRest = new();
            if (id!=account.Id) return NotFound();
            try
            {
                accountRest.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return View();
            }
        }
        public ActionResult SelectByClient()
        {
            return View();
        }
        public ActionResult CreateByClient(int id)
        {
            Account account = new();
            account.ClientId = id;
            return View(account);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateByClient(Account account)
        {
            AccountRest accountRest = new();
            if (ModelState.IsValid)
            {
                try
                {
                    accountRest.Insert(account);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View();
        }
    }
}
