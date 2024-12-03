namespace Framework.Models
{
    public class Customer
    {
        public int ID { get; set; } //Primary 
        public string FirstName { get; set; } //Required
        public string? MiddleName { get; set; } //Optional
        public string LastName { get; set; } //Required
        public DateOnly BirthDate { get; set; } //Required
        public Address? Address { get; set; } //Address class
        public string? Email { get; set; } // Optional
        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>(); //Phone class
        public List<Like> Likes { get; set; } = new List<Like>(); //Likes class
    }

    public class PhoneNumber
    {
        public int ID { get; set; } //Primary
        public string Number { get; set; } //Phone number
        public int CustomerID { get; set; } //Foreign
        public Customer Customer { get; set; } //Pulls customer
    }

    public class Like
    {
        public int ID { get; set; } //Primar
        public string LikeName { get; set; } //Name
        public int CustomerID { get; set; } //Foreign
        public Customer Customer { get; set; } //Pulls customer
    }

    public class Address
    {
        public int ID { get; set; } //Primary
        public string Street { get; set; } //Street
        public string City { get; set; } //City
        public string State { get; set; } //State
        public string Zipcode { get; set; } //Z ip
        public List<Customer> Residents { get; set; } = new List<Customer>(); //Pulls customer
    }
}
