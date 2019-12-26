using System;
using System.Data;

namespace RobertOgden.Data.Models
{
    public class City : TimeStampBase
    {
        public City()
        {
        }

        public City(DataRow row)
        {
            CityId = Convert.ToInt32(row.ItemArray[0].ToString());
            CityName = row.ItemArray[1].ToString();
            CountryId = Convert.ToInt32(row.ItemArray[2].ToString());
            CreateDate = Convert.ToDateTime(row.ItemArray[3].ToString());
            CreatedBy = row.ItemArray[4].ToString();
            LastUpdate = Convert.ToDateTime(row.ItemArray[5].ToString());
            LastUpdateBy = row.ItemArray[6].ToString();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}