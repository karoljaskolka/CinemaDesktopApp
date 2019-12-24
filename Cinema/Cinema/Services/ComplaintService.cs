using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void ShowComplaint(DataGridView table)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = (from r in database.Complaint
                                            select new { ID = r.Complaint_ID, Date = r.Date, Customer_ID = r.Customer_ID }).ToList();

                table.DataSource = bindingSource1;


            }
        }

        public string ShowDescription(int complaintID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                string desc = "";
                Complaint complaint = database.Complaint.Single(x => x.Complaint_ID == complaintID);

                desc = complaint.Description;

                
                return desc;
            }


        }

        
        public void DeleteComplaintByCustomer(int customerID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                database.Complaint.RemoveRange(database.Complaint.Where(x => x.Customer_ID == customerID));
                database.SaveChanges();
            }
        }

        public void DeleteComplaintByID(int complaintID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                database.Complaint.RemoveRange(database.Complaint.Where(x => x.Complaint_ID == complaintID));
                database.SaveChanges();
            }
        }
    }
}
