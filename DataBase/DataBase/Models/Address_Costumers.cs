namespace DataBase.Models
{
    public class Address_costumers
    {
        public int Address_ID { get; set; }
        public int costumers_ID { get; set; }
        public string Street_Name { get; set; }
        public int House_Number { get; set; }
        public int Apartment_Number { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }

        public costumers costumers { get; set; }

        public override string ToString()
        {
            return $"{Street_Name} {House_Number} {Apartment_Number}, {Zipcode} {City} ";
        }


    }
}
