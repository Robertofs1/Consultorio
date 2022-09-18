using CrudWeb.Controllers;
using CrudWeb.Data;
using CrudWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWeb.Repository
{
    public class ContactRepository : IContactRepository
    {

        private readonly DbContent _dbContent;


        public ContactRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public bool Delete(int id)
        {
            ContactModel contactDB = listarId(id);
            if (contactDB == null) throw new Exception("Houve um erro ao apagar");

            _dbContent.Contatos.Remove(contactDB);
            _dbContent.SaveChanges();

            return true;
        }

        public ContactModel Edit(ContactModel contact)
        {
            ContactModel contactDB = listarId(contact.Id);

            if (contactDB == null) throw new Exception("Houve um erro na atualizacao");
            contactDB.Name = contact.Name;
            contactDB.Email = contact.Email;
            contactDB.Celular = contact.Celular;

            _dbContent.Contatos.Update(contactDB);
            _dbContent.SaveChanges();

            return contactDB;

        }

        public List<ContactModel> GetAll()
            {
            return _dbContent.Contatos.ToList();
    }

        public ContactModel listarId(int id)
        {
            return _dbContent.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContactModel New(ContactModel contact)
        {
            _dbContent.Contatos.Add(contact);
            _dbContent.SaveChanges();
            return contact;
        }
    }
}
