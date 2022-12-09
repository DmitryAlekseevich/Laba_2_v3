namespace AllStaffNet6.laba2;

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;
    private DateTime _birthDate;
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthDate = birthDate;
    }
    public Person()
    {
        _firstName = "Решат";
        _lastName = "Рашитов";
        _birthDate = new(1987, 6, 10);
    }
    public string FirstName => _firstName;
    public string LastName => _lastName;
    public DateTime BirthDate => _birthDate;
    public int BirthYear
    {
        get => _birthDate.Year;
        set => _birthDate = new(value, _birthDate.Month, _birthDate.Day, _birthDate.Hour, _birthDate.Minute, _birthDate.Second);
    }
    public string ToFullString()
    {
        return $"Фамилия: {_lastName}\n" +
            $"Имя: {_firstName}\n" +
            $"Дата рождения: {_birthDate:dd.MM.yyyy}";
    }
    public string ToShortString() => $"Фамилия: {_lastName}\nИмя: {_firstName}";
}