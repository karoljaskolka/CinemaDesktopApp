using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Services
{
    class CustomerService
    {
        public bool LogIn(string login, string password, int roleID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                bool access = false;

                var signIn = database.Customer.Where(x => x.Login == login 
                    && x.Password == password && x.Role_ID == roleID).Count();

                if (signIn == 1)
                {
                    access = true;
                }

                return access;
            }
        }

        public Customer GetCustomer(string login)
        {
            using(CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Where(x => x.Login == login).FirstOrDefault();
                return customer;
            }
        }

        public void DeleteCustomer(int customerID)
        {
            using(CinemaEntities database = new CinemaEntities())
            {

                // before delete customer 
                // must delete all records with his foreign key

                CommentService commentService = new CommentService();
                ComplaintService complaintService = new ComplaintService();
                TicketService ticketService = new TicketService();
                RatingsService ratingsService = new RatingsService();

                commentService.DeleteCommentByCustomer(customerID);
                complaintService.DeleteComplaintByCustomer(customerID);
                ticketService.DeleteTicketByCustomer(customerID);
                ratingsService.DeleteRatingByCustomer(customerID);

                // now delete customer

                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                database.Customer.Remove(customer);
                database.SaveChanges();
            }
        }

        public int GetCustomerID(string login)
        {
            int ID = 0;
            using (CinemaEntities database = new CinemaEntities())
            {
                // pobranie ID użytkownika o podanym loginie
                Customer customer = database.Customer.Single(x => x.Login == login);
                ID = customer.Customer_ID;
            }
            return ID;
        }

        public string GetLogin(int customerID)
        {
            string login;
            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                login = customer.Login;
            }
            return login;
        }


        public string GetPassword(int customerID)
        {
            string password;
            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                password = customer.Password;
            }
            return password;
        }
        public string GetName(int customerID)
        {
            string name;
            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                name = customer.First_Name;
            }
            return name;
        }

        public string GetSurname(int customerID)
        {
            string surname;
            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                surname = customer.Last_Name;
            }
            return surname;
        }

        public string GetEmail(int customerID)
        {
            string email;
            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                email = customer.Email;
            }
            return email;
        }
        public string GetPhone(int customerID)
        {
            string phone;
            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                phone = customer.Phone;
            }
            return phone;
        }


        public void SetLogin(int customerID, string login)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                customer.Login = login;
                database.SaveChanges();
            }

        }


        public void SetPassword(int customerID, string password)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                customer.Password = password;
                database.SaveChanges();
            }

        }

        public void SetName(int customerID, string name)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                customer.First_Name = name;
                database.SaveChanges();
            }

        }

        public void SetSurname(int customerID, string surname)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                customer.Last_Name = surname;
                database.SaveChanges();
            }

        }

        public void SetEmail(int customerID, string email)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                customer.Email = email;
                database.SaveChanges();
            }

        }

        public void SetPhone(int customerID, string phone)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Customer customer = database.Customer.Single(x => x.Customer_ID == customerID);
                customer.Phone = phone;
                database.SaveChanges();
            }

        }

        public bool CustomerExist(string login)
        {
            using (CinemaEntities context = new CinemaEntities())
            {
                var checkCustomerExist = context.Customer.Where(x => x.Login == login).Count();
                if (checkCustomerExist < 1) { return false; }
                else { return true; }
            }
        }

        public void SignUp(string login, string password, string firstName, string lastName, string birth, string email, string phone)
        {
            using (CinemaEntities database = new CinemaEntities())
            {

                Customer newCustomer = database.Customer.Create();

                newCustomer.Customer_ID = Convert.ToInt32(database.sp_getSeqCustomerID().FirstOrDefault());
                newCustomer.Login = login;
                newCustomer.Password = password;
                newCustomer.First_Name = firstName;
                newCustomer.Last_Name = lastName;
                newCustomer.Birth = DateTime.Parse(birth);
                newCustomer.Email = email;
                newCustomer.Phone = phone;
                newCustomer.Role_ID = 1;

                // jeśli zajęty
                if (CustomerExist(login))
                {
                    MessageBox.Show("User name is already taken");
                }
                // jeśli nie jest zajęty
                else
                {
                    database.Customer.Add(newCustomer);
                    database.SaveChanges();
                    MessageBox.Show("Account created");
                }
            }
        }
    }
}