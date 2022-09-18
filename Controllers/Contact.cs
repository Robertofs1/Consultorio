using CrudWeb.Models;
using CrudWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudWeb.Controllers
{
    public class Contact : Controller
    {
        private readonly IContactRepository _contactRepository;

        public Contact(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            List<ContactModel> contatos = _contactRepository.GetAll();
            return View(contatos);
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult EditPacient(int Id)
        {
            ContactModel contato = _contactRepository.listarId(Id);
            return View(contato);
        }
        public IActionResult DeletePacient(int Id)
        {
            ContactModel contato = _contactRepository.listarId(Id);

            return View(contato);
        }

        public IActionResult Delete (int id)
        {
            _contactRepository.Delete(id);
            return RedirectToAction("Index");
        }

        

        [HttpPost]
        public IActionResult New(ContactModel contact)
        {
            _contactRepository.New(contact);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(ContactModel contact)
        {
            _contactRepository.Edit(contact);
            return RedirectToAction("Index");
        }

    }
}
