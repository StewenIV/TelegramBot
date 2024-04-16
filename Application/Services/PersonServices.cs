using Application.Dtos;
using Application.Interfaces;
using Domen.Entity;

namespace Application.Services;
//EntityFrameWork ??
public class PersonServices
{
    private readonly IpersonRepository _personRepository;
    public PersonServices(IpersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public List<Person> Get(Person person)
    {
        var GetPerson = _personRepository.Get();
        return GetPerson;
    }
    
    public Person AddPerson(Person person)
    {
        var addPerson = _personRepository.Add(person);
        return addPerson;
    }
    public Person UpdatePerson(Person person)
    {
        var updatePerson = _personRepository.Update(person);
        return updatePerson;
    }
    public void DeletePerson(Person person)
    {
        _personRepository.Delete(person);
    }
    // Описать PersonServices
    public PersonGetByIdResponse  GetById(Guid id)
    {
        var person = _personRepository.GetByid(id);
        throw new NotImplementedException();
        // Маппинг (AutoMapper) применить моэжно если хочешьподготовится 
    }
}
/*public List<Person> _SearchByFullName(string firstName, string lastName, string middleName)
{
    return _persons
        .Where(p => p.FirstName == firstName && p.LastName == lastName && p.MiddleName == middleName)
        .ToList();
}*/