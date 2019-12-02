--DROP DATABASE Cinema;

--CREATE DATABASE Cinema;

use Cinema;

-- CREATE TABLE

CREATE TABLE Role (
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
	Name varchar(20) NOT NULL,
	Description varchar(500)
);

CREATE TABLE Customer(
	Customer_ID int PRIMARY KEY,
	Login varchar(25) NOT NULL,
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
REFERENCES Role(Role_ID);

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
		Screen.Screen_ID AS 'Screen', Seat.Name AS 'Seat', Ticket_Type.Price AS 'Ticket Price', 
		(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',DATEPART(MINUTE, Date)) 
			FROM Showtime s2
			WHERE s2.Showtime_ID = s1.Showtime_ID) AS 'Shotime Date', 
		(SELECT CONCAT(DATEPART(year, Date),'-',DATEPART(month, Date),'-',DATEPART(day, Date),' ',DATEPART(hour, Date), ':',DATEPART(MINUTE, Date)) 
			FROM Ticket t2
			WHERE t2.Ticket_ID = t1.Ticket_ID) AS 'Transaction Date'
FROM Ticket t1
JOIN Customer ON t1.Customer_ID = Customer.Customer_ID
JOIN Showtime s1 ON t1.Showtime_ID = s1.Showtime_ID
JOIN Movie ON s1.Movie_ID = Movie.Movie_ID
JOIN Ticket_Type ON t1.Ticket_Type_ID = Ticket_Type.Ticket_Type_ID
JOIN Seat ON t1.Seat_ID = Seat.Seat_ID
JOIN Screen ON Seat.Seat_ID = Screen.Screen_ID;

--SELECT * FROM TICKET_VIEW;
--SELECT * FROM SHOWTIME_VIEW;

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
		   IF @tech3d ='3d' 
			   UPDATE Showtime SET technology='3d' WHERE technology='3d'
			else 
			   UPDATE Showtime SET technology='2d' 
         
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


CREATE NONCLUSTERED INDEX IX_MOVIE_TITLE ON Movie(Title);
CREATE NONCLUSTERED INDEX IX_TICKET_CUSTOMER ON Ticket(Customer_ID);
CREATE NONCLUSTERED INDEX IX_COMMENT_DATE ON Comment(Date DESC);
CREATE NONCLUSTERED INDEX IX_RATING_MOVIE ON Rating(Movie_ID);
CREATE NONCLUSTERED INDEX IX_SHOWTIME_DATE ON Showtime(Date DESC);
CREATE NONCLUSTERED INDEX IX_CUSTOMER_NAME ON Customer(Last_Name, First_Name);
CREATE NONCLUSTERED INDEX IX_MOVIE_RELEASE ON Movie(Release_Date);
CREATE NONCLUSTERED INDEX IX_CUSTOMER_AUTHENTICATION ON Customer(Login,Password);

--INSERT INTO

INSERT INTO Role VALUES (NEXT VALUE FOR SEQ_ROLE_ID, 'Client');
INSERT INTO Role VALUES (NEXT VALUE FOR SEQ_ROLE_ID, 'Employee');
INSERT INTO Role VALUES (NEXT VALUE FOR SEQ_ROLE_ID, 'Admin');

-- (ID, Login, Password, First_Name, Last_Name, Birth, Email, Phone, Role_ID)
INSERT INTO Customer VALUES (NEXT VALUE FOR SEQ_CUSTOMER_ID, 'Jan83','123456','Jan','Kowalski','1983-04-22','kowal@gmail.com','615234004',1);
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
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Frozen 2', '2019-11-22', NULL, 'Jennifer Lee', NULL, 103, 3);
INSERT INTO Movie VALUES (NEXT VALUE FOR SEQ_MOVIE_ID, 'Star Wars: The Rise of Skywalker', '2019-12-19', NULL, 'J.J. Abrams', 12, 155, 11);

INSERT INTO Comment VALUES (NEXT VALUE FOR SEQ_COMMENT_ID, 1, 1,'Amazing!','2019-11-25 22:11');

-- (ID, Movie_ID, Screen_ID, Date, Technology)
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 1, 3, '2019-11-26 20:15', '2D');
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 4, 3, '2019-12-19 20:45', '3D');
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 2, 1, '2019-11-26 17:45', '2D');
INSERT INTO Showtime VALUES (NEXT VALUE FOR SEQ_SHOWTIME_ID, 3, 2, '2019-11-26 15:15', '3D');

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

-- (ID, Customer_ID, Movie_ID, Stars, Date)
INSERT INTO Rating Values(NEXT VALUE FOR SEQ_RATING_ID, 1,1,5,'2019-12-15');
INSERT INTO Rating Values(NEXT VALUE FOR SEQ_RATING_ID, 1,1,-5,'2019-12-15');

-- (ID, Showtime_ID, Customer_ID, Seat_ID, Ticket_Type_ID, Status, Date)
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 1, 1, 1, 2, 'Paid', '2019-11-25 22:35');
INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID, 4, 3, 2, 2, 'Booked', '2019-11-25 22:48');