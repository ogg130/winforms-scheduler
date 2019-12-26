using System;
using System.Data;

namespace RobertOgden.Data.Models.Reports
{
    internal class Option3 : AppointmentBase
    {
        public Option3()
        {
        }

        public Option3(DataRow row)
        {
            City = (row.ItemArray[0].ToString());
            Title = row.ItemArray[1].ToString();
            Description = row.ItemArray[2].ToString();
            Location = row.ItemArray[3].ToString();
            Contact = row.ItemArray[4].ToString();
            Type = row.ItemArray[5].ToString();
            Url = row.ItemArray[6].ToString();
            Start = DateTime.Parse(row.ItemArray[7].ToString());
            End = DateTime.Parse(row.ItemArray[8].ToString());
        }

        public string City { get; set; }
    }
}