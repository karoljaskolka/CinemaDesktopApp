using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    class ComplaintService
    {
        public void CreateComplaint(int customerID, string description)
        {
            using(CinemaEntities database= new CinemaEntities())
            {
                Complaint newComplaint = database.Complaint.Create();
                
                //obecna data
                DateTime myDateTime = DateTime.Now;
                //format daty poprawny do sql
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm");

                newComplaint.Complaint_ID = Convert.ToInt32(database.sp_getSeqComplaintID().FirstOrDefault());
                newComplaint.Customer_ID = customerID;
                newComplaint.Description = description;
                newComplaint.Date = DateTime.Parse(sqlFormattedDate);

                database.Complaint.Add(newComplaint);
                database.SaveChanges();
            }

        }
    }
}
