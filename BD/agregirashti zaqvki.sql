SELECT * FROM WizzardDeposits
--1
SELECT COUNT(Id) AS 'CountOfRecords' FROM WizzardDeposits
--2
SELECT MAX(Age) AS 'OldestWizard' FROM WizzardDeposits
--2'
SELECT TOP(1) FirstName,LastName,Age FROM WizzardDeposits
ORDER BY Age DESC
--3
SELECT DepositGroup 
, MAX(AGE) AS 'Max Age'  
FROM WizzardDeposits as d
GROUP BY DepositGroup

--3'
SELECT DepositGroup , 
MAX(AGE) AS 'AgeMax',Min(AGE) AS 'AgeMin',
(MAX(AGE)- MIN(AGE)) AS 'Age Difference'  
FROM WizzardDeposits as d
GROUP BY DepositGroup

--4
SELECT DepositGroup, AVG(DepositAmount) AS 'AverageDepAmmount' FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AverageDepAmmount

--5


--6



--7



--8
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS 'MinDepositCharge' FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY DepositGroup


SELECT 
	CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age BETWEEN 61 AND 70 THEN '[61-70]'
	  WHEN w.Age >= 71 THEN '[71+]'
	END AS [AgeGroup],
COUNT(*) AS [WizardCount]
	FROM WizzardDeposits AS w
GROUP BY CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age BETWEEN 61 AND 70 THEN '[61-70]'
	  WHEN w.Age >= 71 THEN '[71+]'
END