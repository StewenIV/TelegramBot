using Domen.Primitivies;

namespace Application.Dtos;

public class PersonGetByIdResponse
{

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string MiddleName { get; set; } = string.Empty;
    public DateTime BirthDay { get; private set; }

    public int Age => BirthDay.Year - DateTime.Now.Year;

    public Gender.GenderType Gender { get; private set; }
    public string PhoneNumber { get; private set; }
}