using System;
using System.Data;

namespace RobertOgden.Data.Models
{
    public class Country : TimeStampBase
    {
        public Country()
        {
        }

        public Country(DataRow row)
        {
            CountryId = Convert.ToInt32(row.ItemArray[0].ToString());
            CountryName = row.ItemArray[1].ToString();
            CreateDate = Convert.ToDateTime(row.ItemArray[2].ToString());
            CreatedBy = row.ItemArray[3].ToString();
            LastUpdate = Convert.ToDateTime(row.ItemArray[4].ToString());
            LastUpdateBy = row.ItemArray[5].ToString();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}