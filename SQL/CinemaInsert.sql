INSERT INTO Booking(Booking_ID, Showtime_ID, User_ID, Status, Seat_Number) VALUES (?, ?, ?, ?, ?);
INSERT INTO Comment(Comment_ID, Movie_ID, User_ID, Description) VALUES (?, ?, ?, ?);
INSERT INTO Complaint(Complaint_ID, User_ID, Description) VALUES (?, ?, ?);
INSERT INTO Country(Country_ID, Name) VALUES (?, ?);
INSERT INTO Genre(Genre_ID, Name, Description) VALUES (?, ?, ?);
INSERT INTO Movie(Movie_ID, Title, Release_Date, Description, Director, Age_Category, Duration, Genre_ID, Country_ID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?);
INSERT INTO Rating(Rating_ID, User_ID, Movie_ID, Stars) VALUES (?, ?, ?, ?);
INSERT INTO Role(Role_ID, Name) VALUES (?, ?);
INSERT INTO Screen(Screen_ID, Capacity, Screen_Size, Rows) VALUES (?, ?, ?, ?);
INSERT INTO Showtime(Showtime_ID, Movie_ID, Screen_ID, [Date], Technology) VALUES (?, ?, ?, ?, ?);
INSERT INTO Ticket(Ticket_ID, Showtime_ID, User_ID, Seat_Number, Price) VALUES (?, ?, ?, ?, ?);
INSERT INTO [User](User_ID, Login, Password, First_Name, Last_Name, Birth, [E-Mail], Phone, Country_ID, Role_ID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?);

