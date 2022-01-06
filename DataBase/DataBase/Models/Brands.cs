using System.Collections.Generic;

namespace DataBase.Models
{
    public class Brands
    {
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public string Manufacturing_Country { get; set; }
        public ICollection<Items> Items { get; set; }

    }
}
