using CrudWeb.Models;

namespace CrudWeb.Repository
{
    public interface IContactRepository

    {
        ContactModel listarId(int id);
        List<ContactModel> GetAll();
        ContactModel New(ContactModel contact);

        ContactModel Edit(ContactModel contact);

        bool Delete(int id);

    }
}
