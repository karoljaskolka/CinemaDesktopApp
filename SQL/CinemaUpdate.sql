UPDATE Booking SET Showtime_ID = ?, User_ID = ?, Status = ?, Seat_Number = ? WHERE Booking_ID = ?;
UPDATE Comment SET Movie_ID = ?, User_ID = ?, Description = ? WHERE Comment_ID = ?;
UPDATE Complaint SET User_ID = ?, Description = ? WHERE Complaint_ID = ?;
UPDATE Country SET Name = ? WHERE Country_ID = ?;
UPDATE Genre SET Name = ?, Description = ? WHERE Genre_ID = ?;
UPDATE Movie SET Title = ?, Release_Date = ?, Description = ?, Director = ?, Age_Category = ?, Duration = ?, Genre_ID = ?, Country_ID = ? WHERE Movie_ID = ?;
UPDATE Rating SET User_ID = ?, Movie_ID = ?, Stars = ? WHERE Rating_ID = ?;
UPDATE Role SET Name = ? WHERE Role_ID = ?;
UPDATE Screen SET Capacity = ?, Screen_Size = ?, Rows = ? WHERE Screen_ID = ?;
UPDATE Showtime SET Movie_ID = ?, Screen_ID = ?, [Date] = ?, Technology = ? WHERE Showtime_ID = ?;
UPDATE Ticket SET Showtime_ID = ?, User_ID = ?, Seat_Number = ?, Price = ? WHERE Ticket_ID = ?;
UPDATE [User] SET Login = ?, Password = ?, First_Name = ?, Last_Name = ?, Birth = ?, [E-Mail] = ?, Phone = ?, Country_ID = ?, Role_ID = ? WHERE User_ID = ?;

