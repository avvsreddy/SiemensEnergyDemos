namespace OODemo1
{
    internal class Program //: Customer
    {
        static void Main(string[] args)
        {

            //Employee e = new Employee();

            //Employee e1 = new Employee();
            //e1.EmpID = 1;
            //e1.Name = "Test";
            //e1.Salary = 20000;

            //Employee e2 = new Employee(111, "Suresh");

            // Object Initialization Syntax

            var e22 = new { EmpID = 111, Name = "Suresh" };

            var e3 = new { EmpID = 123, Name = "Ravi", Salary = 60000 };

            var e4 = new { Salary = 670000, EmpID = 345 };


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
            //set { this.discount = value; }
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

    //class Employee
    //{

    //    public int EmpID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }


    //    //public Employee()
    //    //{

    //    //}
    //    //public Employee(int id)
    //    //{
    //    //    EmpID = id;
    //    //}

    //    //public Employee(int id, string name) : this(id) 
    //    //{
    //    //    //EmpID = id;
    //    //    Name = name;
    //    //}

    //    //public Employee(int id, string name, int sal) : this(id,name)
    //    //{
    //    //    //EmpID = id;
    //    //    //Name = name;
    //    //    Salary = sal;
    //    //}
    //}
}
