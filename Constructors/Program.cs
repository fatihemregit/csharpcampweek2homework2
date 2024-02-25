namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Fatih",
                LastName = "KILINÇ",
                City = "Adana"
            };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2,"Samet","Turan","Ankara");
            Console.WriteLine(customer2.FirstName);
        }

    }

    class Customer
    {


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //default constructor

        public Customer()
        {
            
        }

        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        
        }


        



    }



}
