using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Database;

namespace Cinema.Services
{
    public class CommentService
    {
        public void GetCommentsByMovie(DataGridView table, string movieTitle)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.Comment.Join(database.Movie, x => x.Movie_ID, y => y.Movie_ID,
                    (x, y) => new { x.Comment_ID, y.Title, x.Description, x.Date }).
                         Where(x => x.Title.Contains(movieTitle)).ToList();
            }
        }

        public void GetCommentsByCustomer(DataGridView table, string login)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.Comment.Join(database.Customer, x => x.Customer_ID, y => y.Customer_ID,
                        (x, y) => new { x.Comment_ID, y.Login, x.Description, x.Date }).
                        Where(x=> x.Login == login).ToList();
            }
        }

        public void DeleteComment(int commentID)
        {
            using(CinemaEntities database = new CinemaEntities())
            {
                Comment comment = database.Comment.Single(x => x.Comment_ID == commentID);
                database.Comment.Remove(comment);
                database.SaveChanges();
            }
        }

        public void DeleteCommentByCustomer(int customerID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                database.Comment.RemoveRange(database.Comment.Where(x => x.Customer_ID == customerID));
                database.SaveChanges();
            }
        }
    }
}
