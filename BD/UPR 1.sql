CREATE DATABASE A11_2024DB
GO
USE A11_2024DB
GO
CREATE TABLE Manufacturer
(
	Id INT PRIMARY KEY ,
	Name NVARCHAR(32) NOT NULL,
	Email NVARCHAR(64) NOT NULL UNIQUE,
	Address NVARCHAR(128), 
)
GO
CREATE TABLE Candies
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(32) NOT NULL UNIQUE,
	Description NVARCHAR(2048) NOT NULL,
	CaloriesPer100Grams INT,
	Weight INT NOT NULL,
	Price DECIMAL(8,2) CONSTRAINT Valid_Price CHECK (Price>0),
	ImageURL VARCHAR(MAX),
	ManufacturerId INT CONSTRAINT FK_Candies_Manufacturers
	FOREIGN KEY REFERENCES Manufacturer(Id) NOT NULL,
)
GO

INSERT INTO Manufacturer(Id,Name,Email,Address) VALUES
(11,'Svoge','svoge2@yahoo.com','Pernik ulica chervena stena 24'),
(12,'Pobeda Burgas','pobeda2@abv.bg','Burgas ulica morska 13')
GO


INSERT INTO Candies(ManufacturerId,Name,Description,CaloriesPer100Grams,Weight,Price,ImageURL) VALUES
(11,'Torta s shokolad2','Mnogo sladka shokoladka',535,350,8.53,'https://media-cdn2.greatbritishchefs.com/media/is1brnr2/img77430.whqc_768x512q80.jpg'),
(12,'Sladka Carevica2',N'Царевейшън Витаминейшън Кочанейшън',333,250,5.00,'https://recepti.gotvach.bg/files/lib/400x296/varenacarevicakochan.webp'),
(11,'Experiment2',N'Супер Експерименталния Експеримент',NULL,250,NULL,'https://kartinkaNaEperiment.jpg')

SELECT * FROM Candies

SELECT * FROM Manufacturer

DROP TABLE Candies


