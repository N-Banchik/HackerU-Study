namespace DataBase.Models
{
    public class Address_Employees
    {

        public int Address_ID { get; set; }
        public int Employee_ID { get; set; }
        public string Street_Name { get; set; }
        public int House_Number { get; set; }
        public int Apartment_Number { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }

        public Employees employee { get; set; }


        public override string ToString()
        {
            return $"{Street_Name} {House_Number} {Apartment_Number}, {Zipcode} {City} ";
        }

    }
}
