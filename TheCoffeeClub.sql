CREATE DATABASE CoffeeClubMgtDB;

CREATE TABLE Owner(
No INT PRIMARY KEY NOT NULL,
Coffee VARCHAR(80) NOT NULL,
Price INT NOT NULL,
);

SELECT * FROM Owner ORDER BY No;

INSERT INTO Owner VALUES(13,'Coffee',4000);

UPDATE Owner SET Coffee='Doppto',Price=7000 WHERE No=2;

DELETE FROM Owner WHERE No=13;
