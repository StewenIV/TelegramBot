using System.Text.RegularExpressions;
using Domen.Primitivies;
using Domen.ValueObject;

namespace Domen.Entity
{
    public class Person : BaseEntity
    {
        // перевести на FluentValidator
        public Person(FullName fullName, DateTime birthDay, Gender.GenderType gender, string phoneNumber,
            string telegram)
        {
            FullName = fullName;  // убрать валидацию, доавбить в FullName валидацию 
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Telegram = telegram;
        }

        public FullName FullName { get; private set; }
        public DateTime BirthDay { get; private set; }

        public int Age => BirthDay.Year - DateTime.Now.Year;

        public Gender.GenderType Gender { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Telegram { get; private set; }
        
        public List<CustomField<string>> CustomFields { get; set; } = new List<CustomField<string>>();

    }
} //напечать документацию 