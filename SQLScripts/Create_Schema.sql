-- First Create a DB locally and name it aspnet-ImmanuelNews.WebApi-20160708145718
-- Run the db in sql server express before running these scripts

-- CREATE TABLES

CREATE TABLE Users
(
UserId int IDENTITY(1,1) PRIMARY KEY,
Firstname varchar(255),
Lastname varchar(255),
Email varchar(255) NOT NULL,
Password varchar(255) NOT NULL
);

CREATE TABLE Feeds
(
FeedId int IDENTITY(1,1) PRIMARY KEY,
Title varchar(255),
Content varchar(255),
ContentImageUrl varchar(255),
BaseUrl varchar(255) NOT NULL,
ViewCount int
);

-- INSERTING DATA
INSERT INTO Users VALUES ('Fredy','Whatley', 'fredywhatley@gmail.com', 'password');
INSERT INTO Users VALUES ('Cesar','Whatley', 'wahat@gd.com', 'haha');
INSERT INTO Users VALUES ('Someone','some', 'some@gmail.com', '12345');

INSERT INTO Feeds (BaseUrl) VALUES ('http://rss.upi.com/news/news.rss');
INSERT INTO Feeds (BaseUrl) VALUES ('http://rss.upi.com/news/bn_si.rss');
INSERT INTO Feeds (BaseUrl) VALUES ('http://www.eurekalert.org/rss/technology_engineering.xml');







