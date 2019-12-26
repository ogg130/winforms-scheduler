using System;
using System.Collections.Generic;
using System.Data;

namespace RobertOgden.Data.Models
{
    public class Address : TimeStampBase
    {
        public Address()
        {
        }

        public Address(Dictionary<string, string> formData)
        {
            AddressId = Convert.ToInt32(formData["AddressId"]);
            Address1 = formData["Address1"];
            Address2 = formData["Address2"];
            CityId = Convert.ToInt32(formData["CityId"]);
            PostalCode = formData["PostalCode"];
            Phone = formData["Phone"];
            CreateDate = Convert.ToDateTime(formData["CreateDate"]);
            CreatedBy = formData["CreatedBy"];
            LastUpdate = Convert.ToDateTime(formData["LastUpdate"]);
            LastUpdateBy = formData["LastUpdateBy"];
        }

        public Address(DataRow row)
        {
            AddressId = Convert.ToInt32(row.ItemArray[0].ToString());
            Address1 = row.ItemArray[1].ToString();
            Address2 = row.ItemArray[2].ToString();
            CityId = Convert.ToInt32(row.ItemArray[3].ToString());
            PostalCode = row.ItemArray[4].ToString();
            Phone = row.ItemArray[5].ToString();
            CreateDate = Convert.ToDateTime(row.ItemArray[6].ToString());
            CreatedBy = row.ItemArray[7].ToString();
            LastUpdate = Convert.ToDateTime(row.ItemArray[8].ToString());
            LastUpdateBy = row.ItemArray[9].ToString();
        }

        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
    }
}