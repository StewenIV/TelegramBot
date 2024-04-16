using Domen.Entity;

namespace Application.Interfaces;

public interface IpersonRepository:IRepository<Person>
{
    //попробовать сделать поиск по любому полю person через экспрессию(лямбда выражение)
    public List<Person> _SearchByFullName(string firstName, string lastName, string middleName);
}
