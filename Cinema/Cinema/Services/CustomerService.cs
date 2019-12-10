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
        public bool LogIn(string login, string password)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                bool access = false;

                var signIn = database.Customer.Where(x => x.Login == login && x.Password == password).Count();

                if (signIn == 1)
                {
                    access = true;

                }

                return access;
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

                Customer newCustomer = database.Customer.FirstOrDefault();

                newCustomer.Customer_ID = Convert.ToInt32(database.sp_getSeqCustomerID());
                newCustomer.Login = login;
                newCustomer.Password = password;
                newCustomer.First_Name = firstName;
                newCustomer.Last_Name = lastName;
                newCustomer.Birth = DateTime.Parse(birth);
                newCustomer.Email = email;
                newCustomer.Phone = phone;

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
