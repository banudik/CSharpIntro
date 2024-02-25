Customer customer1 = new Customer {Id=1, FirstName="Engin",LastName="Demiroğ",City="Ankara" };
Customer customer3 = new Customer();
customer3.Id = 3; //aynı mantık

Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

Console.WriteLine(customer2.FirstName);

class Customer
{
    //default constructor
    public Customer()
    {
        
    }
    public Customer(int id,string firstName, string lastName, string city)
    {   Id = id; 
        FirstName = firstName;
        LastName = lastName;
        City = city;
        
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}