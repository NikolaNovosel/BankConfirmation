using BankConfirmation_DTO;
using BankConfirmation_UI_MVC.REST;
using Microsoft.AspNetCore.Mvc;

namespace BankConfirmation_UI_MVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {
            ClientRest clientRest = new();
            return View(clientRest.GetAll());
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            ClientRest clientRest = new();
            var result = clientRest.GetById(id);
            if (result==null) return NotFound();
            return View(result);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            Client client = new();
            return View(client);
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            ClientRest clientRest = new();
            try
            {
                clientRest.Insert(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            ClientRest clientRest = new();
            var result = clientRest.GetById(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Client client)
        {
            ClientRest clientRest = new();
            try
            {
                clientRest.Update(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            ClientRest clientRest = new();
            var result = clientRest.GetById(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Client client)
        {
            ClientRest clientRest = new();
            if (id!=client.Id) return NotFound();
            try
            {
                clientRest.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
