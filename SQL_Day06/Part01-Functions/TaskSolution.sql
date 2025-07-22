USE [ITI]
GO

-- Q1. Create a scalar function that takes date and returns Month name of that date.

	CREATE OR ALTER FUNCTION GetMonthNameUsingDate(@date DateTime2)
	RETURNS varchar(max)
	BEGIN

		 RETURN DATENAME(MONTH, @date)
	
	END
	GO

	SELECT [dbo].GetMonthNameUsingDate(GETDATE()) As [MonthName]
	GO

-- Q2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them. 

	CREATE OR ALTER FUNCTION GetValuesBetweenTwoInts(@Num1 int, @Num2 int)
	RETURNS @Result TABLE 
	(
		Number int
	)
	AS 
	BEGIN

		IF @Num1 IS NULL OR @Num2 IS NULL
        RETURN;

		DECLARE @Start INT, @End INT

		IF @Num1 <= @Num2
		BEGIN
			SET @Start = @Num1;
			SET @End = @Num2;
		END
		ELSE
		BEGIN
			SET @Start = @Num2;
			SET @End = @Num1;
		END

		WHILE @Start < @End - 1
		BEGIN
			SET @Start = @Start + 1;

			INSERT INTO @Result (Number)
			VALUES (@Start);
        
		END
		RETURN;

	END
	GO

	SELECT Number
	FROM dbo.GetValuesBetweenTwoInts(5, 8);

	SELECT Number
	FROM dbo.GetValuesBetweenTwoInts(8, 5);

	SELECT Number
	FROM dbo.GetValuesBetweenTwoInts(NULL, 8);
	GO

-- Q3: Create a tabled valued function that takes Student No and returns Department Name with Student full name. 

	
	CREATE OR ALTER FUNCTION GetDeptAndFullNameUsingStudentId (@StudentId int)
	RETURNS @Result TABLE 
	(
		DeptId INT,
		[Full Name] VARCHAR(max)
	)
	AS 
	BEGIN

		IF @StudentId IS NULL
			RETURN;

		INSERT INTO @Result (DeptId, [Full Name])
		SELECT D.Dept_Id, CONCAT(S.[St_Fname], ' ', S.[St_Lname]) AS [Full Name]
		FROM [dbo].[Student] S
		INNER JOIN [dbo].[Department] D
		ON S.Dept_Id = D.Dept_Id
		WHERE S.[St_Id]= @StudentId

		RETURN
	END
	GO

	
	SELECT DeptId, [Full Name]
	FROM dbo.GetDeptAndFullNameUsingStudentId(1);

	
	SELECT DeptId, [Full Name]
	FROM dbo.GetDeptAndFullNameUsingStudentId(NULL);
	Go

-- Q4: Create a scalar function that takes Student ID and returns a message to user 
--			a. If first name and Last name are null then display 'First name & last name are null' 
--			b. If First name is null then display 'first name is null'
--			c. If Last name is null then display 'last name is null'
--			d. Else display 'First name & last name are not null'

	CREATE OR ALTER FUNCTION GetStudentNameByStudentId(@StudentId int)
	RETURNS varchar(max)
	BEGIN

		 DECLARE @FirstName varchar(200), @SecondName varchar(200)

		 SELECT @FirstName = [St_Fname], @SecondName = [St_Lname]
		 FROM [dbo].[Student]
		 WHERE [St_Id] = @StudentId

		 IF @FirstName IS NULL AND @SecondName IS NULL
			 RETURN 'First name & last name are null';
		 ELSE IF @FirstName IS NULL
			 RETURN 'first name is null';
		 ELSE IF @SecondName IS NULL
			 RETURN 'last name is null';
		 ELSE
			 RETURN 'First name & last name are not null';

		 RETURN '' 
	END
	GO

	SELECT [dbo].GetStudentNameByStudentId(13) As [Result]
	GO

-- Q5: Create a function that takes integer which represents the format of the 
--     Manager hiring date and displays department name, Manager Name and 
--     hiring date with this format. 

/*
101: MM/DD/YYYY (e.g., 07/16/2025)
103: DD/MM/YYYY (e.g., 16/07/2025)
104: DD.MM.YYYY (e.g., 16.07.2025)
120: YYYY-MM-DD (e.g., 2025-07-16)
*/


	CREATE OR ALTER FUNCTION [dbo].GetDeptManagerInfoByHiringDateFormat(@DateFormat int)
	RETURNS @Result TABLE 
	(
		DeptName nvarchar(100),
		ManagerName nvarchar(200),
		HireDate nvarchar(50)
	)
	AS 
	BEGIN

		IF @DateFormat IS NULL OR @DateFormat NOT IN (101, 103, 104, 120)
			SET @DateFormat = 103

		INSERT INTO @Result (DeptName, ManagerName, HireDate)
		SELECT D.[Dept_Name], I.[Ins_Name], CONVERT(nvarchar(50), D.[Manager_hiredate], @DateFormat)
		FROM [dbo].[Department] D
		LEFT JOIN [dbo].[Instructor] I
		ON D.[Dept_Manager]= I.[Ins_Id]

		RETURN
	END
	GO


	SELECT DeptName, ManagerName, HireDate
	FROM dbo.GetDeptManagerInfoByHiringDateFormat(101);

	SELECT DeptName, ManagerName, HireDate
	FROM dbo.GetDeptManagerInfoByHiringDateFormat(103);

	SELECT DeptName, ManagerName, HireDate
	FROM dbo.GetDeptManagerInfoByHiringDateFormat(NULL);

	SELECT DeptName, ManagerName, HireDate
	FROM dbo.GetDeptManagerInfoByHiringDateFormat(999);
	GO

-- Q6: Create multi-statements table-valued function that takes a string 
--			If string='first name' returns student first name 
--			If string='last name' returns student last name 
--			If string='full name' returns Full Name from student table 
--			Note: Use “ISNULL” function 

	CREATE OR ALTER FUNCTION GetStudentNameFirstLastOrFull(@Query nvarchar(50))
	RETURNS @Result TABLE 
	(
		StudentName nvarchar(200)
	)
	AS 
	BEGIN

		IF @Query = 'first name'
			INSERT INTO @Result (StudentName)
			SELECT ISNULL(St_Fname, '')
			FROM [dbo].[Student]

		ELSE IF @Query = 'last name'
			INSERT INTO @Result (StudentName)
			SELECT ISNULL(St_Lname, '')
			FROM [dbo].[Student]

		ELSE IF @Query = 'full name'
			INSERT INTO @Result (StudentName)
			SELECT ISNULL(CONCAT(St_Fname, ' ', St_Lname), '')
			FROM [dbo].[Student]

		RETURN
	END
	GO

	SELECT StudentName
	FROM dbo.GetStudentNameFirstLastOrFull('first name');

	SELECT StudentName
	FROM dbo.GetStudentNameFirstLastOrFull('last name');

	SELECT StudentName
	FROM dbo.GetStudentNameFirstLastOrFull('full name');

	SELECT StudentName
	FROM dbo.GetStudentNameFirstLastOrFull(NULL);
	GO

USE [MyCompany]
GO

-- Q1: Create function that takes project number and display all employees in this project

	CREATE OR ALTER FUNCTION GetEmployeesByProjectNumber(@ProjectNumber int)
	RETURNS @Result TABLE 
	(
		EmployeeName nvarchar(200)
	)
	AS 
	BEGIN

		IF @ProjectNumber IS NULL
			RETURN

		INSERT INTO @Result (EmployeeName)
		SELECT CONCAT(E.[Fname], ' ', E.[Lname]) AS [Employee Name]
		FROM [dbo].[Works_for] WF
		INNER JOIN [dbo].[Employee] E
		ON WF.[ESSn] = E.[SSN]
		WHERE WF.[Pno] = @ProjectNumber

		RETURN
	END
	GO

	SELECT EmployeeName
	FROM dbo.GetEmployeesByProjectNumber(100);

	SELECT EmployeeName
	FROM dbo.GetEmployeesByProjectNumber(200);

	SELECT EmployeeName
	FROM dbo.GetEmployeesByProjectNumber(NULL);
	GO