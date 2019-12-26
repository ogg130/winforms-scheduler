using System;
using System.Data;

namespace RobertOgden.Data.Models
{
    public class User : TimeStampBase
    {
        public User()
        {
        }

        public User(DataRow row)
        {
            UserId = Convert.ToInt32(row.ItemArray[0].ToString());
            UserName = row.ItemArray[1].ToString();
            Password = row.ItemArray[2].ToString();
            Active = row.ItemArray[3].ToString();
            CreateDate = Convert.ToDateTime(row.ItemArray[4].ToString());
            CreatedBy = row.ItemArray[5].ToString();
            LastUpdate = Convert.ToDateTime(row.ItemArray[6].ToString());
            LastUpdateBy = row.ItemArray[7].ToString();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Active { get; set; }
    }
}