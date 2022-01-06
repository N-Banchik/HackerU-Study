using System.Collections.Generic;


namespace DataBase.Models
{
    public class Categories
    {
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public string Description { get; set; }
        public ICollection<Items> item { get; set; }
    }
}
