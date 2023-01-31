//https://github.com/AlexeyBoronin/Class-Init-namespace-required/blob/master/Классы/Program.cs
using System.Reflection;
using static System.Console;
/*Person bob = new Person("Bob", 45);
(_, int age1) = bob;//Вызов деконструктора
//WriteLine(name);
WriteLine(age1);
bob.Print();
;class Person
{
    string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
    public void Print()
    {
        WriteLine($"Имя: {name} Возраст:{age}");
    }
}*/

using Base.OrganisationTypes;
using Base.PersonType;

Base.OrganisationTypes.Company google = new("Google");
Person Petor = new("Petor", google);
Petor.Print();
namespace Base
{
    namespace PersonType
    {
        class Person
        {
            string name;
            OrganisationTypes.Company company;
            public Person(string name,OrganisationTypes.Company company)
            {
                this.name = name;
                this.company = company;
            }
            public void Print()
            {
                WriteLine($"Имя: {name}");
                company.Print();
            }
        }
    }
    namespace OrganisationTypes
    {
        class Company
        {
            string title;
            public Company(string title) => this.title = title;
            public void Print() => WriteLine($"Название компании: {title}");
        }
    }
}
