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
        
        public void GetMovies(DataGridView table)
        {
            using(CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.Movie.Join(database.Genre, x => x.Genre_ID, y => y.Genre_ID, 
                                    (x, y) => new {
                                        x.Movie_ID, x.Title, x.Director, x.Release_Date, y.Name,
                                            x.Age_Category, x.Duration, x.Description }).ToList();
            }
        }

        public void GetMovieByTitle(DataGridView table, string title)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.Movie.Join(database.Genre, x => x.Genre_ID, y => y.Genre_ID,
                                    (x, y) => new {
                                        x.Movie_ID,
                                        x.Title,
                                        x.Director,
                                        x.Release_Date,
                                        y.Name,
                                        x.Age_Category,
                                        x.Duration,
                                        x.Description
                                    }).Where(x => x.Title.Contains(title)).ToList();
            }
        }

        public void AddMovie(string title, string director, string release, int genreID, int age, int duration, string description)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                Movie newMovie = database.Movie.Create();

                newMovie.Movie_ID = Convert.ToInt32(database.sp_getSeqMovieID().FirstOrDefault());
                newMovie.Title = title;
                newMovie.Director = director;
                newMovie.Age_Category = age;
                newMovie.Duration = duration;
                newMovie.Release_Date = DateTime.Parse(release);
                newMovie.Genre_ID = genreID;
                newMovie.Description = description;

                database.Movie.Add(newMovie);
                database.SaveChanges();
            }
        }

        public void EditMovie(int ID, string title, string director, string release, int genreID, int age, int duration, string description)
        {
            using (CinemaEntities database = new CinemaEntities())
            {

                Movie editMovie = database.Movie.Single(x => x.Movie_ID == ID);

                editMovie.Title = title;
                editMovie.Director = director;
                editMovie.Age_Category = age;
                editMovie.Duration = duration;
                editMovie.Release_Date = DateTime.Parse(release);
                editMovie.Genre_ID = genreID;
                editMovie.Description = description;

                database.SaveChanges();
            }
        }

        public void DeleteMovie(int MovieID)
        {
            using(CinemaEntities database = new CinemaEntities())
            {
                Movie movie = database.Movie.Single(x => x.Movie_ID == MovieID);
                database.Movie.Remove(movie);
                database.SaveChanges();
            }
        }

        public int GetMovieID(string title)
        {
            int ID = 0;
            using (CinemaEntities database = new CinemaEntities())
            {
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

        public void ShowComments(DataGridView table, int movieID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {

                table.DataSource = database.sp_showCommentsMovie(movieID).ToList();

            }
        }

        public void ShowAvgRating(DataGridView table, int movieID)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.sp_showAverageRatingMovie(movieID).ToList();
            }
        }

    }
}
