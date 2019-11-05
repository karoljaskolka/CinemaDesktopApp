CREATE DATABASE Cinema;

use Cinema;

CREATE TABLE Country (
Country_ID int IDENTITY(1,1) PRIMARY KEY,
Name varchar(255) NOT NULL
);

INSERT INTO Country(Name) VALUES ('Argentina');

SELECT * FROM Country;