namespace OODemo1
{
    internal class Program //: Customer
    {
        // fields
        int a;
        //static Customer customer = new Customer(); // HAS-A

        static void Main(string[] args)
        {
            int a;

            Customer customer = new Customer(); // Useses
            customer.name = "Ravi";
            customer.Name = "Ravi";

            //customer.age = -30;
            //customer.SetAge(-20);
            customer.Age = 20;
            //Console.WriteLine(customer.age);
            //Console.WriteLine(customer.GetAge());
            Console.WriteLine(customer.Age);



            Console.WriteLine("Hello, World!");
        }



    }
    public class Customer //: Object//: Program
    {
        // Members
        // Fields / variables
        string name;
        private int age;
        private double discount;
        //private string city;
        //private string backingField234324234;
        //private string addressLine1;
        //private string addressLine2;



        // Properties

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }


        public string City // Automatic properties
        {
            get; //{ return city; }
            set;// { city = value; }
        }
        public double Discount
        {
            set { this.discount = value; }
            get { return this.discount; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    this.age = 1;
                }
            }

        }

        // Methods / functions

        //public void SetAge(int age) 
        //{
        //    if (age > 0 )
        //    {
        //        this.age = age;
        //    }
        //    else
        //    {
        //        this.age = 1;
        //    }
        //}

        //public int GetAge() {
        //return this.age;
        //}

        // constructors
        // destructors / avoid
        // events


    }

    class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
