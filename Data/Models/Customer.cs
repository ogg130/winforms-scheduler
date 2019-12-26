using System;
using System.Collections.Generic;
using System.Data;

namespace RobertOgden.Data.Models
{
    public class Customer : TimeStampBase
    {
        public Customer()
        {
        }

        public Customer(Dictionary<string, string> formData)
        {
            CustomerId = Convert.ToInt32(formData["CustomerId"]);
            CustomerName = formData["CustomerName"];
            AddressId = Convert.ToInt32(formData["AddressId"]);
            Active = Convert.ToBoolean(formData["Active"]);
            CreateDate = Convert.ToDateTime(formData["CreateDate"]);
            CreatedBy = formData["CreatedBy"];
            LastUpdate = Convert.ToDateTime(formData["LastUpdate"]);
            LastUpdateBy = formData["LastUpdateBy"];
        }

        public Customer(DataRow row)
        {
            CustomerId = Convert.ToInt32(row.ItemArray[0].ToString());
            CustomerName = row.ItemArray[1].ToString();
            AddressId = Convert.ToInt32(row.ItemArray[2].ToString());
            Active = Convert.ToBoolean(row.ItemArray[3].ToString());
            CreateDate = Convert.ToDateTime(row.ItemArray[4].ToString());
            CreatedBy = row.ItemArray[5].ToString();
            LastUpdate = Convert.ToDateTime(row.ItemArray[6].ToString());
            LastUpdateBy = row.ItemArray[7].ToString();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
    }
}