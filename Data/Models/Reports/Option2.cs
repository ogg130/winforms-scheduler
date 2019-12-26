using System;
using System.Data;

namespace RobertOgden.Data.Models.Reports
{
    internal class Option2 : AppointmentBase
    {
        public Option2()
        {
        }

        public Option2(DataRow row)
        {
            UserName = row.ItemArray[0].ToString();
            Title = row.ItemArray[1].ToString();
            Description = row.ItemArray[2].ToString();
            Location = row.ItemArray[3].ToString();
            Contact = row.ItemArray[4].ToString();
            Type = row.ItemArray[5].ToString();
            Url = row.ItemArray[6].ToString();
            Start = DateTime.Parse(row.ItemArray[7].ToString());
            End = DateTime.Parse(row.ItemArray[8].ToString());
        }

        public string UserName { get; set; }
    }
}