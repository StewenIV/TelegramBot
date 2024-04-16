namespace Domen.Primitivies;

public static class ValidationMessages
{
    //разобраться как приинмать несколько элементов и уточнить ошибку  //action //func //eventHandler //pridicate
    public static Func<string, string> NotNull { get; set; } =
        (propertyName) => $"Объект {propertyName} не может быть null";
    public static Func<string, string> NotEmpty { get; set; } =
        (propertyName) => $"Объект {propertyName} не может быть Empty";
    public static Func<string, string> InvalidProperty { get; set; } =
        (propertyName) => $"Объект {propertyName} имеет недопустимое значение";
    public static Func<string, string>  OverFlow{ get; set; } =
       (propertyName) => $"Объект {propertyName} имеет больше 20";
    public static Func<string, string> InvalidBirthday { get; set; } =
       (propertyName) => $"Объект {propertyName} имеет недопустимый значение возраста";
    public static Func<string, string> TelegramValidation { get; set; } =
      (propertyName) => $"Объект {propertyName} имеет недопустимый значение";

}

