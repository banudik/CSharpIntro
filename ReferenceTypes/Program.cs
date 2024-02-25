//int,decimal,float,enum,boolean value types
//int number1 = 10;
//int number2 = 20;

//number1 = number2;
//number2 = 100;

//Console.WriteLine("Sayı 1 :" + number1);

//int[] numbers1 = new int[] { 1, 2, 3 };
//int[] numbers2 = new int[] {10, 20, 30 };

//numbers1 = numbers2;
//numbers2[0] = 1000;

//Console.WriteLine("Sayılar1[0] = "+numbers1[0]);

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Engin";
person2 = person1;
person1.FirstName = "Derin";

//Console.WriteLine(person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = "1234878687";
Employee employee = new Employee();
employee.FirstName = "Veli";

Person person3 = customer;
customer.FirstName = "Ahmet";
//Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(employee);


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

//base class:Person
class Customer:Person
{
    public string CreditCardNumber { get; set; }
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}