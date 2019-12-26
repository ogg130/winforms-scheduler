using System;
using System.Data;

namespace RobertOgden.Data.Models.Reports
{
    internal class Option1 : ReportBase
    {
        public Option1()
        {
        }

        public Option1(DataRow row)
        {
            Type = row.ItemArray[0].ToString();
            Month = row.ItemArray[1].ToString();
            Year = row.ItemArray[2].ToString();
            Appointments = Convert.ToInt32(row.ItemArray[3]);
        }

        public string Type { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int Appointments { get; set; }
    }
}