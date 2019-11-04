SELECT Booking_ID, Showtime_ID, User_ID, Status, Seat_Number FROM Booking;
SELECT Comment_ID, Movie_ID, User_ID, Description FROM Comment;
SELECT Complaint_ID, User_ID, Description FROM Complaint;
SELECT Country_ID, Name FROM Country;
SELECT Genre_ID, Name, Description FROM Genre;
SELECT Movie_ID, Title, Release_Date, Description, Director, Age_Category, Duration, Genre_ID, Country_ID FROM Movie;
SELECT Rating_ID, User_ID, Movie_ID, Stars FROM Rating;
SELECT Role_ID, Name FROM Role;
SELECT Screen_ID, Capacity, Screen_Size, Rows FROM Screen;
SELECT Showtime_ID, Movie_ID, Screen_ID, [Date], Technology FROM Showtime;
SELECT Ticket_ID, Showtime_ID, User_ID, Seat_Number, Price FROM Ticket;
SELECT User_ID, Login, Password, First_Name, Last_Name, Birth, [E-Mail], Phone, Country_ID, Role_ID FROM [User];

