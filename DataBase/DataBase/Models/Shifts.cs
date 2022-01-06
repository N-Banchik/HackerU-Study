using System;

namespace DataBase.Models
{
    public class Shifts
    {
        public int Shift_ID { 
            get; set; }
        public int Employee_ID { get; set; }
        public DateTime Shift_Start { get; set; }
        public DateTime? Shift_End { get; set; }
        public double Total_Time { get; set; }


        public Employees Employee { get; set; }


    }
}
