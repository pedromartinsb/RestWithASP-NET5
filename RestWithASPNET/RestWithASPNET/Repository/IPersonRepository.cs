using System.Collections.Generic;
using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IPersonRepository
    {
        List<Person> FindAll();

        Person FindByID(long id);

        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);

        bool Exists(long id);
    }
}
