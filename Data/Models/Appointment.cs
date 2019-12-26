using System;
using System.Collections.Generic;
using System.Data;

namespace RobertOgden.Data.Models
{
    public class Appointment : TimeStampBase
    {
        public Appointment()
        {
        }

        public Appointment(Dictionary<string, string> formData)
        {
            AppointmentId = Convert.ToInt32(formData["AppointmentId"]);
            CustomerId = Convert.ToInt32(formData["CustomerId"]);
            UserId = Convert.ToInt32(formData["UserId"]);
            Title = formData["Title"];
            Description = formData["Description"];
            Location = formData["Location"];
            Contact = formData["Contact"];
            Type = formData["Type"];
            Url = formData["Url"];
            Start = Convert.ToDateTime(formData["Start"]);
            End = Convert.ToDateTime(formData["End"]);
            CreateDate = Convert.ToDateTime(formData["CreateDate"]);
            CreatedBy = formData["CreatedBy"];
            LastUpdate = Convert.ToDateTime(formData["LastUpdate"]);
            LastUpdateBy = formData["LastUpdateBy"];
        }

        public Appointment(DataRow row)
        {
            AppointmentId = Convert.ToInt32(row.ItemArray[0].ToString());
            CustomerId = Convert.ToInt32(row.ItemArray[1].ToString());
            UserId = Convert.ToInt32(row.ItemArray[2].ToString());
            Title = row.ItemArray[3].ToString();
            Description = row.ItemArray[4].ToString();
            Location = row.ItemArray[5].ToString();
            Contact = row.ItemArray[6].ToString();
            Type = row.ItemArray[7].ToString();
            Url = row.ItemArray[8].ToString();
            Start = DateTime.Parse(row.ItemArray[9].ToString());
            End = DateTime.Parse(row.ItemArray[10].ToString());
            CreateDate = DateTime.Parse(row.ItemArray[11].ToString());
            CreatedBy = row.ItemArray[12].ToString();
            LastUpdate = DateTime.Parse(row.ItemArray[13].ToString());
            LastUpdateBy = row.ItemArray[14].ToString();
        }

        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}