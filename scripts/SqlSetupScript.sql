CREATE DATABASE FootballDb;

USE FootballDb;

CREATE TABLE Players (
    Id            int IDENTITY,
    ShirtNo       int,
    Name          nvarchar(50),
    Appearances   int,
    Goals         int,
    
    CONSTRAINT PK_Players PRIMARY KEY (Id)
);

INSERT INTO FootballDb.dbo.Players (ShirtNo, Name, Appearances, Goals) VALUES(33, 'Michael Jordan', 1, 666);
INSERT INTO FootballDb.dbo.Players (ShirtNo, Name, Appearances, Goals) VALUES(10, 'John Snow', 2, 33);
INSERT INTO FootballDb.dbo.Players (ShirtNo, Name, Appearances, Goals) VALUES(2, 'Stephen Smith', 5, 99);
