--DROP DATABASE Cinema;

--CREATE DATABASE Cinema;

use Cinema;

-- CREATE TABLE

CREATE TABLE dbRole (
	Role_ID int PRIMARY KEY,
	Name varchar(20) NOT NULL
);

CREATE TABLE Complaint(
	Complaint_ID int PRIMARY KEY,
	Customer_ID int NOT NULL,
	Description varchar(500) NOT NULL,
	Date datetime NOT NULL
);

CREATE TABLE Comment (
	Comment_ID int PRIMARY KEY, 
	Movie_ID int NOT NULL,
	Customer_ID int NOT NULL,
	Description varchar(500) NOT NULL, 
	Date datetime NOT NULL
);

CREATE TABLE Rating(
	Rating_ID int PRIMARY KEY,
	Customer_ID int NOT NULL,
	Movie_ID int NOT NULL,
	Stars int NOT NULL,
	Date datetime NOT NULL
);

CREATE TABLE Genre(
	Genre_ID int PRIMARY KEY,
	Name varchar(20) UNIQUE NOT NULL,
	Description varchar(500)
);

CREATE TABLE Customer(
	Customer_ID int PRIMARY KEY,
	Login varchar(25) UNIQUE NOT NULL,
	Password varchar(25) NOT NULL,
	First_Name varchar(25) NOT NULL,
	Last_Name varchar(25) NOT NULL,
	Birth date NOT NULL,
	Email varchar(30),
	Phone varchar(20),
	Role_ID int NOT NULL
);

CREATE TABLE Movie(
	Movie_ID int PRIMARY KEY,
	Title varchar(250) NOT NULL,
	Release_Date date NOT NULL,
	Description varchar(500),
	Director varchar(50),
	Age_Category int,
	Duration int NOT NULL,
	Genre_ID int
);

CREATE TABLE Ticket(
	Ticket_ID int PRIMARY KEY,
	Showtime_ID int NOT NULL,
	Customer_ID int,
	Seat_ID int NOT NULL,
	Ticket_Type_ID int NOT NULL,
	Status varchar(20) NOT NULL,
	Date datetime NOT NULL
);

CREATE TABLE Showtime(
	Showtime_ID int PRIMARY KEY,
	Movie_ID int NOT NULL,
	Screen_ID int NOT NULL,
	Date datetime NOT NULL,
	Technology varchar(2)
);

CREATE TABLE Ticket_Type(
	Ticket_Type_ID int PRIMARY KEY,
	Name varchar(20) NOT NULL,
	Price int NOT NULL
);

CREATE TABLE Screen(
	Screen_ID int PRIMARY KEY,
	Capacity int NOT NULL,
	Screen_Size varchar(10)
);

CREATE TABLE Seat(
	Seat_ID int PRIMARY KEY,
	Screen_ID int NOT NULL,
	Name varchar(3) NOT NULL
);

--ALTER TABLE

ALTER TABLE Customer
ADD CONSTRAINT FK_Customer_Role
FOREIGN KEY(Role_ID)
REFERENCES dbRole(Role_ID);

ALTER TABLE Movie
ADD CONSTRAINT FK_Movie_Genre
FOREIGN KEY(Genre_ID)
REFERENCES Genre(Genre_ID);

ALTER TABLE Complaint
ADD CONSTRAINT FK_Complaint_Customer
FOREIGN KEY(Customer_ID)
REFERENCES Customer(Customer_ID);

ALTER TABLE Comment
ADD CONSTRAINT FK_Comment_Movie
FOREIGN KEY (Movie_ID)
REFERENCES Movie(Movie_ID);

ALTER TABLE Comment
ADD CONSTRAINT FK_Comment_Customer
FOREIGN KEY (Customer_ID)
REFERENCES Customer(Customer_ID);

ALTER TABLE Rating
ADD CONSTRAINT FK_Rating_Movie
FOREIGN KEY (Movie_ID)
REFERENCES Movie(Movie_ID);

ALTER TABLE Rating
ADD CONSTRAINT FK_Rating_Customer
FOREIGN KEY (Customer_ID)
REFERENCES Customer(Customer_ID);

ALTER TABLE Seat
ADD CONSTRAINT FK_Seat_Screen
FOREIGN KEY (Screen_ID)
REFERENCES Screen(Screen_ID);

ALTER TABLE Showtime
ADD CONSTRAINT FK_Showtime_Movie
FOREIGN KEY (Movie_ID)
REFERENCES Movie(Movie_ID);

ALTER TABLE Showtime
ADD CONSTRAINT FK_Showtime_Screen
FOREIGN KEY (Screen_ID)
REFERENCES Screen(Screen_ID);

ALTER TABLE Ticket 
ADD CONSTRAINT FK_Ticket_Showtime
FOREIGN KEY (Showtime_ID)
REFERENCES Showtime(Showtime_ID);

ALTER TABLE Ticket 
ADD CONSTRAINT FK_Ticket_Customer
FOREIGN KEY (Customer_ID)
REFERENCES Customer(Customer_ID);

ALTER TABLE Ticket 
ADD CONSTRAINT FK_Ticket_Seat
FOREIGN KEY (Seat_ID)
REFERENCES Seat(Seat_ID);

ALTER TABLE Ticket 
ADD CONSTRAINT FK_Ticket_Ticket_Type
FOREIGN KEY (Ticket_Type_ID)
REFERENCES Ticket_Type(Ticket_Type_ID);

-- CREATE SEQUENCE

CREATE SEQUENCE SEQ_Ticket_Type_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
MAXVALUE 10
NO CYCLE;

CREATE SEQUENCE SEQ_Showtime_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Screen_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
MAXVALUE 3
NO CYCLE;

CREATE SEQUENCE SEQ_Seat_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
MAXVALUE 80
NO CYCLE;

CREATE SEQUENCE SEQ_Ticket_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Movie_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Customer_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Role_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
MAXVALUE 3
NO CYCLE;

CREATE SEQUENCE SEQ_Complaint_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Comment_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Rating_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
NO MAXVALUE
NO CYCLE;

CREATE SEQUENCE SEQ_Genre_ID
AS INT
START WITH 1
INCREMENT BY 1  
MINVALUE 1
MAXVALUE 50
NO CYCLE;

CREATE VIEW SHOWTIME_VIEW AS
SELECT  Movie.Title AS 'Movie', Movie.Duration, Movie.Age_Category AS 'Age Category', Movie.Director,
		Movie.Description, Genre.Name AS 'Genre', Screen.Screen_ID AS 'Screen', s1.Technology, 
		(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',
			DATEPART(MINUTE, Date)) 
			FROM Showtime s2  
			WHERE s2.Showtime_ID=s1.Showtime_ID) AS 'Date'
FROM Showtime s1
JOIN Movie ON s1.Movie_ID = Movie.Movie_ID
JOIN Screen ON s1.Screen_ID = Screen.Screen_ID
JOIN Genre ON Movie.Genre_ID = Genre.Genre_ID;

CREATE VIEW TICKET_VIEW AS
SELECT CONCAT(Customer.First_Name,' ', Customer.Last_Name) AS 'Client', Movie.Title AS 'Movie', 
	(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',DATEPART(MINUTE, Date)) 
			FROM Showtime Showtime2
			WHERE Showtime.Showtime_ID = Showtime2.Showtime_ID) AS 'Showtime',
	Ticket_Type.Price AS 'Ticket Price',  Ticket.Status,  Seat.Name AS 'Seat', Seat.Screen_ID,
	(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',DATEPART(MINUTE, Date)) 
			FROM Ticket Ticket2
			WHERE Ticket.Ticket_ID = Ticket2.Ticket_ID) AS 'Transaction'
FROM Ticket 
JOIN Customer ON Ticket.Customer_ID = Customer.Customer_ID
JOIN Showtime ON Ticket.Showtime_ID = Showtime.Showtime_ID
JOIN Movie ON Showtime.Movie_ID = Movie.Movie_ID
JOIN Ticket_Type ON Ticket.Ticket_Type_ID = Ticket_Type.Ticket_Type_ID
JOIN Seat ON Ticket.Seat_ID = Seat.Seat_ID
JOIN Screen ON Seat.Screen_ID = Screen.Screen_ID;



CREATE TRIGGER rating_ai ON Rating
         AFTER INSERT 
         AS
           DECLARE @starsMin int ,@starsMax int 
		   SELECT @starsMin=stars, @starsMax=stars FROM inserted
		   IF @starsMIN < 1 
			   UPDATE Rating SET stars=1 WHERE stars<1
			IF @starsMAX > 10 
			   UPDATE Rating SET stars=10 WHERE stars>10

CREATE TRIGGER showtime_technology_ai ON Showtime
         AFTER INSERT 
         AS
           DECLARE @tech2d VARCHAR(2) ,@tech3d VARCHAR(2) 
		   SELECT @tech2d=technology, @tech3d=technology FROM inserted
		   IF @tech3d ='3D' 
			   UPDATE Showtime SET technology='3D' WHERE technology='3D'
			else 
			   UPDATE Showtime SET technology='2D' 
         
CREATE TRIGGER movie_age_category_ai  ON Movie
         AFTER INSERT 
         AS
           DECLARE @ageMin int ,@ageMax int 
		   SELECT @ageMin=Age_Category, @ageMax=Age_Category FROM inserted
		   IF @ageMin < 3 
			   UPDATE Movie SET Age_Category=3 WHERE Age_Category<3
			IF @ageMax > 18 
			   UPDATE Movie SET Age_Category=18 WHERE Age_Category>18
         
CREATE TRIGGER movie_duration_ai  ON Movie
         AFTER INSERT 
         AS
           DECLARE @timeMin int  
		   SELECT @timeMin=Duration FROM inserted
		   IF @timeMin <1 
			   UPDATE Movie SET Duration=1 WHERE Duration<1
			
CREATE TRIGGER ticket_type_price ON ticket_type
         AFTER INSERT 
         AS
           DECLARE @priceMin int ,@priceMax int 
		   SELECT @priceMin=Price, @priceMax=Price FROM inserted
		   IF @priceMin <15 
			   UPDATE ticket_type SET Price=15 WHERE Price<15
			IF  @priceMax>25
			     UPDATE ticket_type SET Price=25 WHERE Price>25

-- INDEXES

CREATE NONCLUSTERED INDEX IX_MOVIE_TITLE ON Movie(Title);
CREATE NONCLUSTERED INDEX IX_TICKET_CUSTOMER ON Ticket(Customer_ID);
CREATE NONCLUSTERED INDEX IX_COMMENT_DATE ON Comment(Date DESC);
CREATE NONCLUSTERED INDEX IX_RATING_MOVIE ON Rating(Movie_ID);
CREATE NONCLUSTERED INDEX IX_SHOWTIME_DATE ON Showtime(Date DESC);
CREATE NONCLUSTERED INDEX IX_CUSTOMER_NAME ON Customer(Last_Name, First_Name);
CREATE NONCLUSTERED INDEX IX_MOVIE_RELEASE ON Movie(Release_Date);
CREATE NONCLUSTERED INDEX IX_CUSTOMER_AUTHENTICATION ON Customer(Login,Password);

-- PROCEDURES

CREATE PROCEDURE sp_showCustomerRatings @Customer_ID int
AS
SELECT Movie.Title AS 'Title',Rating.stars AS 'Rating', Rating.Date AS 'Date'
FROM Rating 
JOIN Customer ON Rating.Customer_ID=Customer.Customer_ID
JOIN Movie ON Rating.Movie_ID=Movie.Movie_ID
WHERE Rating.Customer_ID = @Customer_ID
GO

CREATE PROCEDURE sp_getShowtime_ID @Screen_ID int, @DateOfShowtime varchar
AS
SELECT Showtime.Showtime_ID
FROM Showtime 
WHERE Showtime.Screen_ID = @Screen_ID AND Showtime.Date=(SELECT CONVERT(datetime, @DateOfShowtime, 120))
GO
DROP PROCEDURE sp_getShowtime_ID;

EXEC sp_getShowtime_ID @Screen_ID=3 , @DateOfShowtime= '2011-09-28 18:01:00';
SELECT*FROM SHOWTIME;
SELECT CONVERT(Datetime, '2011-09-28 18:01:00', 120);
CREATE PROCEDURE sp_getMovie_ID @Movie_Title VARCHAR(50)
AS
SELECT Movie.Movie_ID
FROM Movie 
WHERE Movie.Title = @Movie_Title
GO


CREATE PROCEDURE sp_showMovieRatings @Movie_ID int
AS
SELECT Movie.Title, Rating.stars AS 'Rating', concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer'
FROM Rating 
JOIN Customer ON Rating.Customer_ID=Customer.Customer_ID
JOIN Movie ON Rating.Movie_ID=Movie.Movie_ID
WHERE Movie.Movie_ID = @Movie_ID
GO

CREATE PROCEDURE sp_showCustomerTickets @Customer_ID int
AS
SELECT CONCAT(Customer.First_Name,' ', Customer.Last_Name) AS 'Client', Movie.Title AS 'Movie', 
	Showtime.Date AS 'Showtime',
	Ticket_Type.Price AS 'Ticket Price',  Ticket.Status,  Seat.Name AS 'Seat', Seat.Screen_ID AS 'Screen',
	Ticket.Date AS 'Transaction'
	FROM Ticket
JOIN Customer ON Customer.Customer_ID = @Customer_ID
JOIN Showtime ON Ticket.Showtime_ID = Showtime.Showtime_ID
JOIN Movie ON Showtime.Movie_ID = Movie.Movie_ID
JOIN Ticket_Type ON Ticket.Ticket_Type_ID = Ticket_Type.Ticket_Type_ID
JOIN Seat ON Ticket.Seat_ID = Seat.Seat_ID
JOIN Screen ON Seat.Screen_ID = Screen.Screen_ID;
GO
DROP PROCEDURE sp_showCustomerTickets
EXEC sp_showCustomerTickets @Customer_ID=9;
SELECT * FROM TICKET_VIEW;

CREATE PROCEDURE sp_showCustomerTickets @Customer_ID int
AS
SELECT CONCAT(Customer.First_Name,' ', Customer.Last_Name) AS 'Client', Movie.Title AS 'Movie', 
	(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',DATEPART(MINUTE, Date)) 
			FROM Showtime Showtime2
			WHERE Showtime.Showtime_ID = Showtime2.Showtime_ID) AS 'Showtime',
	Ticket_Type.Price AS 'Ticket Price',  Ticket_Type.Name AS 'Type', Ticket.Status,  Seat.Name AS 'Seat', Seat.Screen_ID AS 'Screen' , 
	(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',DATEPART(MINUTE, Date)) 
			FROM Ticket Ticket2
			WHERE Ticket.Ticket_ID = Ticket2.Ticket_ID) AS 'Transaction'
FROM Ticket 
JOIN Customer ON Customer.Customer_ID = @Customer_ID
JOIN Showtime ON Ticket.Showtime_ID = Showtime.Showtime_ID
JOIN Movie ON Showtime.Movie_ID = Movie.Movie_ID
JOIN Ticket_Type ON Ticket.Ticket_Type_ID = Ticket_Type.Ticket_Type_ID
JOIN Seat ON Ticket.Seat_ID = Seat.Seat_ID
JOIN Screen ON Seat.Screen_ID = Screen.Screen_ID
WHERE Ticket.Customer_ID = @Customer_ID;

DROP PROCEDURE sp_showCustomerTickets


EXEC sp_showCustomerTickets @Customer_ID=3;

CREATE PROCEDURE sp_showAverageRatingMovie @Movie_ID int
AS
SELECT Movie.Title, AVG(Cast(Rating.Stars as Decimal)) AS 'Average Rating'
FROM Rating 
JOIN Movie ON Rating.Movie_ID = Movie.Movie_ID
WHERE Rating.Movie_ID = @Movie_ID
GROUP BY Movie.Title
ORDER BY Movie.Title;
GO

CREATE PROCEDURE sp_showTickets @Showtime_ID int
AS
SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer', Seat.Name AS 'Seat' , Ticket.Status
FROM Ticket
JOIN Customer ON Ticket.Customer_ID = Customer.Customer_ID
JOIN Seat ON Ticket.Seat_ID = Seat.Seat_ID
JOIN Showtime ON Ticket.Showtime_ID = Showtime.Showtime_ID
WHERE Ticket.Showtime_ID = @Showtime_ID
GO

CREATE PROCEDURE sp_showAvailableSeats @Showtime_ID int
AS
-- SELECT ALL SEATS EXCEPT TAKEN ONES
SELECT Seat.Seat_ID, Seat.Name
FROM Seat
JOIN Screen ON Screen.Screen_ID = Seat.Screen_ID
JOIN Showtime ON Showtime.Screen_ID = Screen.Screen_ID
WHERE Showtime.Showtime_ID = @Showtime_ID
EXCEPT 
SELECT Seat.Seat_ID, Seat.Name
FROM Ticket
JOIN Seat ON Ticket.Seat_ID = Seat.Seat_ID
JOIN Showtime ON Ticket.Showtime_ID = Showtime.Showtime_ID
WHERE Showtime.Showtime_ID = @Showtime_ID
GO

CREATE PROCEDURE sp_showGenre @Movie_ID int
AS
SELECT Movie.Title,Genre.Name AS 'Genre'
FROM Movie
JOIN Genre ON Genre.Genre_ID=Movie.Genre_ID
WHERE Movie.Movie_ID = @Movie_ID
GO

CREATE PROCEDURE sp_showCommentsCustomer @Customer_ID int
AS
SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer',Movie.Title,Comment.Description AS 'Comment'
FROM Comment
JOIN Customer ON Customer.Customer_ID=Comment.Customer_ID
JOIN Movie ON Movie.Movie_ID=Comment.Movie_ID
WHERE Customer.Customer_ID = @Customer_ID
GO

CREATE PROCEDURE sp_showCommentsMovie @Movie_ID int
AS
SELECT Movie.Title,concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer',Comment.Description AS 'Comment'
FROM Comment
JOIN Customer ON Customer.Customer_ID=Comment.Customer_ID
JOIN Movie ON Movie.Movie_ID = Comment.Movie_ID
WHERE Movie.Movie_ID=@Movie_ID
GO

CREATE PROCEDURE sp_showComplaints @Customer_ID int
AS
SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer',Complaint.Description AS 'Complaint'
FROM Complaint
JOIN Customer ON Customer.Customer_ID=Complaint.Customer_ID
WHERE Complaint.Customer_ID = @Customer_ID
GO

CREATE PROCEDURE sp_showMovie @Movie_ID int
AS
SELECT Movie.Title,Movie.Director,Genre.Name AS 'Genre',Movie.Release_Date AS 'Release date', Movie.Age_Category AS 'Age category'
FROM Movie
JOIN Genre ON Genre.Genre_ID=Movie.Genre_ID
WHERE Movie.Movie_ID = @Movie_ID
GO

CREATE PROCEDURE sp_showMovies
AS
SELECT Movie.Title,Movie.Director,Genre.Name AS 'Genre',Movie.Release_Date AS 'Release date', Movie.Age_Category AS 'Age category'
FROM Movie
JOIN Genre ON Genre.Genre_ID=Movie.Genre_ID
GO

CREATE PROCEDURE sp_showCustomer @Customer_ID int
AS
SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer', Customer.Login,Customer.Birth AS 'Birth date',Customer.Email, Customer.Phone
FROM Customer
WHERE Customer.Customer_ID = @Customer_ID
GO

CREATE PROCEDURE sp_showCustomers
AS
SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer', Customer.Login,Customer.Birth AS 'Birth date',Customer.Email, Customer.Phone
FROM Customer
GO

CREATE PROCEDURE sp_getSeqCustomerID
AS
SELECT NEXT VALUE FOR SEQ_CUSTOMER_ID;
GO


CREATE PROCEDURE sp_getSeqTicketTypeID
AS
SELECT NEXT VALUE FOR SEQ_Ticket_Type_ID;
GO


CREATE PROCEDURE sp_getSeqShowtimeID
AS
SELECT NEXT VALUE FOR SEQ_Showtime_ID;
GO


CREATE PROCEDURE sp_getSeqScreenID
AS
SELECT NEXT VALUE FOR SEQ_Screen_ID;
GO

CREATE PROCEDURE sp_getSeqSeatID
AS
SELECT NEXT VALUE FOR SEQ_Seat_ID;
GO


CREATE PROCEDURE sp_getSeqTicketID
AS
SELECT NEXT VALUE FOR SEQ_Ticket_ID;
GO


CREATE PROCEDURE sp_getSeqMovieID
AS
SELECT NEXT VALUE FOR SEQ_Movie_ID;
GO


CREATE PROCEDURE sp_getSeqRoleID
AS
SELECT NEXT VALUE FOR SEQ_Role_ID;
GO


CREATE PROCEDURE sp_getSeqComplaintID
AS
SELECT NEXT VALUE FOR SEQ_Complaint_ID;
GO


CREATE PROCEDURE sp_getSeqCommentID
AS
SELECT NEXT VALUE FOR SEQ_Comment_ID;
GO


CREATE PROCEDURE sp_getSeqRatingID
AS
SELECT NEXT VALUE FOR SEQ_Rating_ID;
GO


CREATE PROCEDURE sp_getSeqGenreID
AS
SELECT NEXT VALUE FOR SEQ_Genre_ID;
GO


-- SELECT for views

SELECT * FROM TICKET_VIEW;
SELECT * FROM SHOWTIME_VIEW WHERE Date LIKE '2019-11-26%' ORDER BY DATE ASC;

--EXEC instruction for procedures
EXEC sp_showCustomerRatings @Customer_ID=1;
EXEC sp_showMovieRatings @Movie_ID=3;
EXEC sp_showAverageRatingMovie @Movie_ID=1;
EXEC sp_showTickets @Showtime_ID=4;
EXEC sp_showAvailableSeats @Showtime_ID=4;
EXEC sp_showGenre @Movie_ID=1;
EXEC sp_showCommentsCustomer @Customer_ID=1;
EXEC sp_showCommentsMovie @Movie_ID=1;
EXEC sp_showComplaints @Customer_ID=1;
EXEC sp_showCustomer @Customer_ID=1;
EXEC sp_showCustomers;
EXEC sp_showMovie @Movie_ID=1;
EXEC sp_showMovies;
EXEC sp_getSeqCustomerID;
EXEC sp_getMovie_ID @Movie_Title='Frozen 2';
EXEC sp_getShowtime_ID @Screen_ID=3, @DateOfShowtime= '2019-11-26 20:15';
SELECT * FROM SHowtime;
--INSERT INTO
SELECT * FROM SHOWTIME_VIEW;
INSERT INTO dbRole VALUES (NEXT VALUE FOR SEQ_ROLE_ID, 'Client');
INSERT INTO dbRole VALUES (NEXT VALUE FOR SEQ_ROLE_ID, 'Employee');
INSERT INTO dbRole VALUES (NEXT VALUE FOR SEQ_ROLE_ID, 'Admin');

-- (ID, Login, Password, First_Name, Last_Name, Birth, Email, Phone, Role_ID)
INSERT INTO Customer VALUES(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'Jan83','123456','Jan','Kowalski','1983-04-22','kowal@gmail.com','615234004',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'AtomicPulga','qwerty','Leo','Messi','1989-10-26','lmessi@gmail.com','215488975',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'kinglj','lakers','LeBron','James','1987-08-05','ljames@gmail.com','443258971',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'hazardeden','chelsea','Eden','Hazard','1992-07-11','ehazard@gmail.com','784525641',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'cr7','juveshit','Cristiano','Ronaldo','1988-08-01','cronaldo@gmail.com','756285341',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'captainamerica','trueblue','Christian','Pulisic','1998-02-27','cpulisic@gmail.com','697854231',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'flampard','bestcoach','Frank','Lampard','1984-12-04','flampard@gmail.com','795648231',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'jmourinho','specialone','Jose','Mourinho','1962-04-13','jmourinho@gmail.com','315478945',1);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'admin','admin','admin','admin','1998-12-13',null,null,3);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'hannahBaker','note','Hannah','Baker','2000-01-19','hbaker@gmail.com','465892320',2);
INSERT INTO Customer Values(NEXT VALUE FOR SEQ_CUSTOMER_ID, 'clayJensen','helmet','Clay','Jensen','2000-02-15','cjensen@gmail.com','685321457',2);

INSERT INTO Ticket_Type VALUES (NEXT VALUE FOR SEQ_TICKET_TYPE_ID, 'Reduced', 15);
INSERT INTO Ticket_Type VALUES (NEXT VALUE FOR SEQ_TICKET_TYPE_ID, 'Regular', 20);

INSERT INTO Screen VALUES (NEXT VALUE FOR SEQ_SCREEN_ID, 20, 'small');
INSERT INTO Screen VALUES (NEXT VALUE FOR SEQ_SCREEN_ID, 20, 'medium');
INSERT INTO Screen VALUES (NEXT VALUE FOR SEQ_SCREEN_ID, 40, 'big');

INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Action', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Adventure', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Animation', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Comedy', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Crime', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Drama', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Fantasy', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Historical', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Horror', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Romance', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Sci-Fi', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Thriller', NULL);
INSERT INTO Genre VALUES (NEXT VALUE FOR SEQ_GENRE_ID, 'Western', NULL);

-- (ID, Title, Release_Date, Description, Director, Age_Category, Duration, Genre_ID)
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Joker', '2019-10-04', NULL, 'Todd Phillips', 16, 122, 5);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Once Upon a Time... in Hollywood', '2019-08-16', NULL, 'Quentin Tarantino', 16, 161, 5);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Frozen 2', '2019-11-22', NULL, 'Jennifer Lee', 3, 103, 3);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Star Wars: The Rise of Skywalker', '2019-12-19', NULL, 'J.J. Abrams', 12, 155, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Parasite', '2019-09-20', NULL, 'Joon-Ho Bong', 12, 132, 6);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Whiplash', '2015-01-02', NULL, 'Damien Hazielle', 3, 105, 6);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Alien', '1979-05-25', NULL, 'Ridley Scott', 16, 117, 9);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Silent Hill', '2006-05-26', NULL, 'Christophe Gans', 16, 125, 9);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'It', '2017-09-08', NULL, 'Andy Muschietti', 16, 135, 9);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'The Conjuring', '2013-07-26', NULL, 'James Wan', 16, 112, 9);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'I am Legend', '2008-01-11', NULL, 'Francis Lawrence', 12, 101, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Iron Man', '2008-04-30', NULL, 'Jon Favreau', 3, 126, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Thor Ragnarok', '2017-10-25', NULL, 'Taika Waititi', 3, 130, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Guardians of the Galaxy', '2014-08-01', NULL, 'James Gunn', 3, 121, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Avengers', '2012-05-11', NULL, 'Josh Whedon', 3, 142, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Avengers Age of Ultron', '2015-05-07', NULL, 'Josh Whedon', 3, 141, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Avengers Infinity War', '2018-04-26', NULL, 'Anthony Russo', 3, 149, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Avengers End Game', '2019-04-25', NULL, 'Anthony Russo', 3, 182, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'The Dark Knight', '2008-08-08', NULL, 'Christopher Nolan', 12, 152, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Django Unchained', '2013-01-18', NULL, 'Quentin Tarantino', 12, 165, 6);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Spiderman Far From Home', '2019-07-05', NULL, 'Jon Watts', 3, 129, 11);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Deadpool', '2016-02-12', NULL, 'Tim Miller', 12, 108, 4);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Intouchables', '2011-09-23', NULL, 'Olivier Nakache', 3, 108, 4);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Forrest Gump', '1994-06-23', NULL, 'Robert Zemeckis', 3, 142, 6);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'The Lord of the Rings: The Return of the King', '2003-12-01', NULL, 'Peter Jackson', 3, 201, 7);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'The Lord of the Rings: The Two Towers', '2002-12-05', NULL, 'Peter Jackson', 3, 179, 7);

INSERT INTO Comment VALUES (NEXT VALUE FOR SEQ_COMMENT_ID, 1, 1,'Amazing!','2019-11-25 22:11');

INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '1A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '2A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '3A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '4A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '5A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '1B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '2B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '3B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '4B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '5B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '1C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '2C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '3C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '4C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '5C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '1D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '2D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '3D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '4D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 1, '5D');

INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '1A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '2A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '3A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '4A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '5A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '1B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '2B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '3B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '4B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '5B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '1C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '2C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '3C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '4C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '5C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '1D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '2D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '3D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '4D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 2, '5D');

INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '1A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '2A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '3A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '4A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '5A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '6A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '7A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '8A');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '1B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '2B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '3B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '4B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '5B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '6B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '7B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '8B');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '1C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '2C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '3C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '4C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '5C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '6C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '7C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '8C');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '1D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '2D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '3D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '4D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '5D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '6D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '7D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '8D');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '1E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '2E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '3E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '4E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '5E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '6E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '7E');
INSERT INTO Seat VALUES (NEXT VALUE FOR SEQ_SEAT_ID, 3, '8E');

-- (ID, Customer_ID, Movie_ID, Stars, Date)
INSERT INTO Rating Values(NEXT VALUE FOR SEQ_RATING_ID, 1,1,5,'2019-12-03');
INSERT INTO Rating Values(NEXT VALUE FOR SEQ_RATING_ID, 1,2,-5,'2019-12-03');
INSERT INTO Rating Values(NEXT VALUE FOR SEQ_RATING_ID, 2,1,10,'2019-12-03');

-- (ID, Movie_ID, Screen_ID, Date, Technology)
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 1, 3, '2019-11-26 20:15', '2D');
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 4, 3, '2019-12-19 20:45', '3D');
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 2, 1, '2019-11-26 17:45', '2D');
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 3, 2, '2019-11-26 15:15', '3D');

-- (ID, Showtime_ID, Customer_ID, Seat_ID, Ticket_Type_ID, Status, Date)
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 1, 1, 41, 2, 'Paid', '2019-11-25 22:35');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 4, 3, 22, 2, 'Booked', '2019-11-25 22:48');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 4, 4, 24, 2, 'Paid', '2019-11-25 22:48');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 4, 5, 25, 2, 'Paid', '2019-11-25 23:41');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 4, 6, 27, 2, 'Booked', '2019-11-25 19:22');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 4, 7, 28, 2, 'Paid', '2019-11-25 17:36');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 2, 2, 51, 1, 'Paid', '2019-11-25 14:36');

--EXECUTE AS USER = 'CINEMA_ADMIN'; 
--EXECUTE AS USER = 'CINEMA_CUSTOMER'; 
--EXECUTE AS USER = 'CINEMA_EMPLOYEE'; 

--SELECT CURRENT_USER; 

-- CINEMA CUSTOMER GRANT & DENY

GRANT SELECT, INSERT, UPDATE, DELETE ON Comment TO CINEMA_CUSTOMER;
GRANT SELECT, INSERT, UPDATE, DELETE ON Rating TO CINEMA_CUSTOMER;
GRANT SELECT, INSERT, UPDATE ON Complaint TO CINEMA_CUSTOMER;
GRANT SELECT, INSERT, UPDATE ON Ticket TO CINEMA_CUSTOMER;
GRANT SELECT, INSERT, UPDATE ON Customer TO CINEMA_CUSTOMER;
GRANT SELECT ON Genre TO CINEMA_CUSTOMER;
GRANT SELECT ON Movie TO CINEMA_CUSTOMER;
GRANT SELECT ON Ticket_Type TO CINEMA_CUSTOMER;
GRANT SELECT ON Seat TO CINEMA_CUSTOMER;
GRANT SELECT ON Screen TO CINEMA_CUSTOMER;
GRANT SELECT ON Showtime TO CINEMA_CUSTOMER;
GRANT SELECT  ON TICKET_VIEW TO CINEMA_CUSTOMER;
GRANT SELECT  ON  SHOWTIME_VIEW TO CINEMA_CUSTOMER;

GRANT EXEC ON  sp_showCustomerRatings TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showMovieRatings TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showAverageRatingMovie TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showTickets TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showAvailableSeats TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showGenre TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showCommentsCustomer TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showCommentsMovie TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showComplaints TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showCustomer TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showCustomers TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showMovie TO CINEMA_CUSTOMER;
GRANT EXEC ON  sp_showMovies TO CINEMA_CUSTOMER;

DENY DELETE ON Complaint TO CINEMA_CUSTOMER;
DENY DELETE ON Ticket TO CINEMA_CUSTOMER;
DENY DELETE ON Customer TO CINEMA_CUSTOMER;
DENY INSERT, UPDATE, DELETE ON Genre TO CINEMA_CUSTOMER;
DENY INSERT, UPDATE, DELETE ON Movie TO CINEMA_CUSTOMER;
DENY INSERT, UPDATE, DELETE ON Ticket_Type TO CINEMA_CUSTOMER;
DENY INSERT, UPDATE, DELETE ON Seat TO CINEMA_CUSTOMER;
DENY INSERT, UPDATE, DELETE ON Screen TO CINEMA_CUSTOMER;
DENY INSERT, UPDATE, DELETE ON Showtime TO CINEMA_CUSTOMER;
DENY SELECT ON dbRole TO CINEMA_CUSTOMER;

-- CINEMA EMPLOYEE GRANT & DENY

GRANT SELECT, INSERT, UPDATE, DELETE ON Comment TO CINEMA_EMPLOYEE;
GRANT SELECT, INSERT, UPDATE, DELETE ON Rating TO CINEMA_EMPLOYEE;
GRANT SELECT, INSERT, UPDATE ON Complaint TO CINEMA_EMPLOYEE;
GRANT SELECT, INSERT, UPDATE, DELETE ON Ticket TO CINEMA_EMPLOYEE;
GRANT SELECT, INSERT, UPDATE ON Customer TO CINEMA_EMPLOYEE;
GRANT SELECT ON Genre TO CINEMA_EMPLOYEE;
GRANT SELECT ON Movie TO CINEMA_EMPLOYEE;
GRANT SELECT ON Ticket_Type TO CINEMA_EMPLOYEE;
GRANT SELECT ON Seat TO CINEMA_EMPLOYEE;
GRANT SELECT ON Screen TO CINEMA_EMPLOYEE;
GRANT SELECT ON Showtime TO CINEMA_EMPLOYEE;
GRANT SELECT  ON TICKET_VIEW TO CINEMA_EMPLOYEE;
GRANT SELECT  ON  SHOWTIME_VIEW TO CINEMA_EMPLOYEE;

GRANT EXEC ON  sp_showCustomerRatings TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showMovieRatings TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showAverageRatingMovie TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showTickets TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showAvailableSeats TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showGenre TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showCommentsCustomer TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showCommentsMovie TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showComplaints TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showCustomer TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showCustomers TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showMovie TO CINEMA_EMPLOYEE;
GRANT EXEC ON  sp_showMovies TO CINEMA_EMPLOYEE;

DENY DELETE ON Complaint TO CINEMA_EMPLOYEE;
DENY DELETE ON Customer TO CINEMA_EMPLOYEE;
DENY INSERT, UPDATE, DELETE ON Genre TO CINEMA_EMPLOYEE;
DENY INSERT, UPDATE, DELETE ON Movie TO CINEMA_EMPLOYEE;
DENY INSERT, UPDATE, DELETE ON Ticket_Type TO CINEMA_EMPLOYEE;
DENY INSERT, UPDATE, DELETE ON Seat TO CINEMA_EMPLOYEE;
DENY INSERT, UPDATE, DELETE ON Screen TO CINEMA_EMPLOYEE;
DENY INSERT, UPDATE, DELETE ON Showtime TO CINEMA_EMPLOYEE;
DENY SELECT ON dbRole TO CINEMA_EMPLOYEE;


Select * from SHOWTIME where Showtime_ID=4;
