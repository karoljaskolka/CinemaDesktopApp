using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Services
{
    class MoviesService
    {
        public void ShowMovies(DataGridView table)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.sp_showMovies().ToList();
            }


        }
        
        public int GetMovieID(string title)
        {

            int ID = 0;
            using (CinemaEntities database = new CinemaEntities())
            {
                // pobranie ID użytkownika o podanym loginie
                Movie movie = database.Movie.Single(x => x.Title == title);
                ID = movie.Movie_ID;
            }
            return ID;



        }

        public void CreateComment(int customerID, string description, int movieID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                Comment newComment = database.Comment.Create();

                //obecna data
                DateTime myDateTime = DateTime.Now;
                //format daty poprawny do sql
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm");

                newComment.Comment_ID = Convert.ToInt32(database.sp_getSeqCommentID().FirstOrDefault());
                newComment.Customer_ID = customerID;
                newComment.Movie_ID = movieID;
                newComment.Description = description;
                newComment.Date = DateTime.Parse(sqlFormattedDate);

                database.Comment.Add(newComment);
                database.SaveChanges();


            }
        }
        public void CreateRating(int customerID, int rating, int movieID)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Rating newRating = database.Rating.Create();

                //obecna data
                DateTime myDateTime = DateTime.Now;
                //format daty poprawny do sql
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm");

                newRating.Rating_ID = Convert.ToInt32(database.sp_getSeqRatingID().FirstOrDefault());
                newRating.Customer_ID = customerID;
                newRating.Movie_ID = movieID;
                newRating.Stars = rating;
                newRating.Date = DateTime.Parse(sqlFormattedDate);

                database.Rating.Add(newRating);
                database.SaveChanges();
            }


        }

        public bool AlreadyRated(int customerID, int movieID)
        {
            
            using (CinemaEntities database = new CinemaEntities())
            {
                
                // pobranie ID użytkownika o podanym loginie
                Rating ratings = database.Rating.Where(x => x.Customer_ID == customerID && x.Movie_ID == movieID).SingleOrDefault();
                if( ratings!=null)
                 {
                    return true;
                }
            }
            


            return false;
        }

    }
}
