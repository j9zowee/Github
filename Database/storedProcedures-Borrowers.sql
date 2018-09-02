use dbLibraryManagement
-----for tblBorrower----

create PROCEDURE sp_ViewBorrower
AS
BEGIN
	SELECT tblBorrower.brwr_BorrowerNum as BorrowerIDNumber, tblBorrower.brwr_SchoolID as SchoolIDNUmber, tblBorrower.brwr_Firstname as Firstname,
		tblBorrower.brwr_Lastname as Lastname, tblBorrower.brwr_Section as Section, tblBorrower.brwr_Gender as Gender, tblBorrower.brwr_Address as Address, 
		tblBorrower.brwr_ContactNumber as ContactNumber
	FROM dbo.tblBorrower
END

create procedure sp_AddBorrower
@BorrowerNum varchar(50),
@SchoolID varchar(20),
@Firstname varchar(100),
@Lastname varchar(100),
@Section varchar(50),
@Gender varchar(10),
@Address varchar(100),
@ContactNumber varchar(50)
as
begin
	insert into tblBorrower values(@BorrowerNum,@SchoolID,@Firstname,@Lastname,@Section,@Gender,@Address,@ContactNumber)
end

CREATE PROCEDURE sp_UpdateBorrower
@BorrowerNum varchar(50),
@SchoolID varchar(20),
@Firstname varchar(100),
@Lastname varchar(100),
@Section varchar(50),
@Gender varchar(10),
@Address varchar(100),
@ContactNumber varchar(50)
AS
BEGIN
	update dbo.tblBorrower
		set tblBorrower.brwr_SchoolID=@SchoolID, tblBorrower.brwr_Firstname=@Firstname, tblBorrower.brwr_Lastname=@Lastname,
		tblBorrower.brwr_Section=@Section,  tblBorrower.brwr_Gender=@Gender, 
		tblBorrower.brwr_Address=@Address, tblBorrower.brwr_ContactNumber=@ContactNumber 
			from tblBorrower
				where tblBorrower.brwr_BorrowerNum= @BorrowerNum	
END

CREATE PROCEDURE sp_SearchBorrower
@Category varchar(50),
@searchkey varchar(50)
AS
BEGIN
	if @Category = 'Firstname'
		(SELECT tblBorrower.brwr_BorrowerNum as BorrowerIDNumber, tblBorrower.brwr_SchoolID as SchoolIDNUmber, tblBorrower.brwr_Firstname as Firstname,
			tblBorrower.brwr_Lastname as Lastname, tblBorrower.brwr_Section as Section, tblBorrower.brwr_Gender as Gender, tblBorrower.brwr_Address as Address, 
			tblBorrower.brwr_ContactNumber as ContactNumber
		FROM dbo.tblBorrower
		where tblBorrower.brwr_Firstname like '%'+@searchKey+'%')
	else if @Category = 'Lastname'
		(SELECT tblBorrower.brwr_BorrowerNum as BorrowerIDNumber, tblBorrower.brwr_SchoolID as SchoolIDNUmber, tblBorrower.brwr_Firstname as Firstname,
			tblBorrower.brwr_Lastname as Lastname, tblBorrower.brwr_Section as Section, tblBorrower.brwr_Gender as Gender, tblBorrower.brwr_Address as Address, 
			tblBorrower.brwr_ContactNumber as ContactNumber
		FROM dbo.tblBorrower
		where tblBorrower.brwr_Lastname like '%'+@searchKey+'%')
	else
		(SELECT tblBorrower.brwr_BorrowerNum as BorrowerIDNumber, tblBorrower.brwr_SchoolID as SchoolIDNUmber, tblBorrower.brwr_Firstname as Firstname,
			tblBorrower.brwr_Lastname as Lastname, tblBorrower.brwr_Section as Section, tblBorrower.brwr_Gender as Gender, tblBorrower.brwr_Address as Address, 
			tblBorrower.brwr_ContactNumber as ContactNumber
		FROM dbo.tblBorrower
		where tblBorrower.brwr_BorrowerNum like '%'+@searchKey+'%')
END
==================================




