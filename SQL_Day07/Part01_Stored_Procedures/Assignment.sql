-- Q1:  Create a stored procedure to show the number of students per department.[use ITI DB]

	USE [ITI]
	GO

	CREATE OR ALTER PROCEDURE SP_GetDepartStudentsByDeptId @DepartId int
	WITH ENCRYPTION
	AS
	BEGIN
		
		IF @DepartId IS NULL
		BEGIN
			SELECT 'ERROR! YOU SENT A NULL VALUE' AS ERROR
			RETURN
		END

		BEGIN TRY

			SELECT *
			FROM [dbo].[Student]
			WHERE [Dept_Id] = @DepartId

			IF @@ROWCOUNT = 0
			BEGIN
				SELECT 'NO DEPARTMENT CORRESPONDS TO THIS ID!' AS [NOT FOUND]
				RETURN
			END

		END TRY
		BEGIN CATCH

			SELECT
			CONVERT(VARCHAR(50), ERROR_NUMBER()) + ', ' + ERROR_MESSAGE()  AS ERROR

		END CATCH

	END
	GO

	EXEC SP_GetDepartStudentsByDeptId @DepartId = 10
	EXEC SP_GetDepartStudentsByDeptId @DepartId = 1
	EXEC SP_GetDepartStudentsByDeptId @DepartId = NULL
	GO

-- Q2:

	/*

	Create a stored procedure that will check for the Number of employees in 
	the project p1 if they are more than 3 print message to the user “'The 
	number of employees in the project p1 is 3 or more'” if they are less display 
	a message to the user “'The following employees work for the project p1'” 
	in addition to the first name and last name of each one. [MyCompany DB] 

	*/

	USE [MyCompany]
	GO

	CREATE OR ALTER PROCEDURE SP_GetProjectEmployeesByProjectName @ProjectName varchar(50)
	WITH ENCRYPTION
	AS
	BEGIN
		
		IF @ProjectName IS NULL OR @ProjectName = ''
		BEGIN
			SELECT 'ERROR! YOU SENT EITHER A NULL OR EMPTY VALUE' AS ERROR
			RETURN
		END

		BEGIN TRY

		DECLARE @EmployeeCount INT

		SELECT @EmployeeCount = COUNT(*)
		FROM [dbo].[Works_for] WF
		INNER JOIN [dbo].[Project] P ON WF.[Pno] = P.[Pnumber]
		WHERE P.[Pname] = @ProjectName

		IF @EmployeeCount >= 3
			SELECT 'The number of employees in the project p1 is 3 or more' AS Message
		ELSE
			SELECT e.[Fname], e.[Lname], 
				   'The following employees work for the project p1' + @ProjectName AS Message
			FROM [dbo].[Employee] e
			INNER JOIN [dbo].[Works_for] WF ON e.[SSN] = WF.[ESSn]
			INNER JOIN [dbo].[Project] P ON WF.[Pno] = P.[Pnumber]
			WHERE P.[Pname] = @ProjectName

			IF @@ROWCOUNT = 0
			BEGIN
				SELECT 'NO PROJECT CORRESPONDS TO THIS NAME!' AS [NOT FOUND]
				RETURN
			END

		END TRY
		BEGIN CATCH

			SELECT
			CONVERT(VARCHAR(50), ERROR_NUMBER()) + ', ' + ERROR_MESSAGE()  AS ERROR

		END CATCH

	END
	GO

	EXEC SP_GetProjectEmployeesByProjectName @ProjectName = 'AL Solimaniah'
	EXEC SP_GetProjectEmployeesByProjectName @ProjectName = 'Al Rowad'
	EXEC SP_GetProjectEmployeesByProjectName @ProjectName = ''
	EXEC SP_GetProjectEmployeesByProjectName @ProjectName = NULL
	GO

-- Q3: 

	/*
	
	Create a stored procedure that will be used in case there is an old 
	employee has left the project and a new one become instead of him. The 
	procedure should take 3 parameters (old Emp. number, new Emp. number 
	and the project number) and it will be used to update works_on table. 
	[MyCompany DB] 

	*/

	CREATE OR ALTER PROCEDURE SP_UpdateProjectEmployee @OldEmployeeId int,
													   @NewEmployeeId int,
													   @ProjectNumber int
	WITH ENCRYPTION
	AS
	BEGIN
		
		IF @OldEmployeeId IS NULL OR @OldEmployeeId = ''
		BEGIN
			SELECT 'ERROR! YOU SENT EITHER A NULL OR EMPTY OLD EMPLOYEE ID' AS ERROR
			RETURN
		END

		IF @NewEmployeeId IS NULL OR @NewEmployeeId = ''
		BEGIN
			SELECT 'ERROR! YOU SENT EITHER A NULL OR EMPTY NEW EMPLOYEE ID' AS ERROR
			RETURN
		END

		IF @ProjectNumber IS NULL OR @ProjectNumber = ''
		BEGIN
			SELECT 'ERROR! YOU SENT EITHER A NULL OR EMPTY PROJECT NUMBER' AS ERROR
			RETURN
		END

		BEGIN TRY
					
		UPDATE [dbo].[Works_for]
		SET [ESSn] = @NewEmployeeId
		WHERE [ESSn] = @OldEmployeeId AND [Pno] = @ProjectNumber;


		IF @@ROWCOUNT = 0
		BEGIN
			SELECT 'NO ROW FOUND!' AS [NOT FOUND]
			RETURN
		END

		END TRY
		BEGIN CATCH

			SELECT
			CONVERT(VARCHAR(50), ERROR_NUMBER()) + ', ' + ERROR_MESSAGE()  AS ERROR

		END CATCH

	END
	GO

	INSERT INTO [dbo].[Employee] (SSN, Fname, Lname)
	VALUES (1, 'John', 'Doe'), (2, 'Jane', 'Smith');
	INSERT INTO [dbo].[Works_for] (ESSn, Pno)
	VALUES (1, 500)

	EXEC SP_UpdateProjectEmployee @OldEmployeeId = 1, @NewEmployeeId = 2, @ProjectNumber = 500;
	GO