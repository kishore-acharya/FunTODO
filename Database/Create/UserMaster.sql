use FuntodoDB;
go
CREATE TABLE UserMaster (
    ID int NOT NULL PRIMARY KEY,
    username varchar(255) NOT NULL,
    password varchar(255),
    firstname varchar(255),
    lastname varchar(255)
);