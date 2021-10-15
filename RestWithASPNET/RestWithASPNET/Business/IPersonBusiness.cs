using System.Collections.Generic;
using RestWithASPNET.Model;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        List<Person> FindAll();

        Person FindByID(long id);

        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);
    }
}
