CREATE DATABASE A11_2024DB
--USE CarDiary
USE A11_2024DB
CREATE TABLE Candies
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(32) NOT NULL UNIQUE,
	Description NVARCHAR(2048) NOT NULL,
	CaloriesPer100Grams INT,
	Weight INT NOT NULL,
	Price DECIMAL(8,2),
	ImageURL VARCHAR(MAX)
)
INSERT INTO Candies(Name,Description,CaloriesPer100Grams,Weight,Price,ImageURL) VALUES
('Torta s shokolad2','Mnogo sladka shokoladka',535,350,8.53,'https://media-cdn2.greatbritishchefs.com/media/is1brnr2/img77430.whqc_768x512q80.jpg'),
('Sladka Carevica2',N'Царевейшън Витаминейшън Кочанейшън',333,250,5.00,'https://recepti.gotvach.bg/files/lib/400x296/varenacarevicakochan.webp'),
('Experiment2',N'Супер Експерименталния Експеримент',NULL,250,NULL,'https://kartinkaNaEperiment.jpg')

SELECT * FROM Candies
--DROP TABLE Candies