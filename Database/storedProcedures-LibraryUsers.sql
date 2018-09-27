use dbLibraryManagement

CREATE PROCEDURE sp_AddLibraryUser
@SchoolID varchar(50),
@Firstname varchar(100),
@Lastname varchar(100),
@Gender varchar(10),
@Address varchar(100),
@ContactNumber varchar(50),
@UserType varchar(50),
@SchoolYear varchar(50),
@WithLibraryCard bit

AS
BEGIN
	insert into tblLibraryUser values(@SchoolID,@Firstname,@Lastname,@Gender,@Address,@ContactNumber,@UserType,@SchoolYear,@WithLibraryCard)
END


CREATE PROCEDURE sp_ViewLibraryUser
@WithPenalty bit,
@SchoolYear varchar(50),
@UserType varchar(50)
AS
BEGIN
	if @WithPenalty = 'true'
	(select tblLibraryUser.lib_SchoolID as SchoolID,tblLibraryUser.lib_Firstname as Firstname,tblLibraryUser.lib_Lastname as Lastname,
	tblLibraryUser.lib_Gender as Gender, tblLibraryUser.lib_Address as HomeAddress,tblLibraryUser.lib_ContactNumber as ContactNumber,
	tblLibraryUser.lib_WithCard as WithLibraryCard 
	from dbo.tblLibraryUser INNER JOIN dbo.tblBorrow ON dbo.tblLibraryUser.lib_UserID = dbo.tblBorrow.lib_UserID INNER JOIN
         dbo.tblReturn ON dbo.tblBorrow.borrow_BorrowID = dbo.tblReturn.borrow_BorrowID INNER JOIN
         dbo.tblPenalty ON dbo.tblReturn.return_ReturnID = dbo.tblPenalty.return_ReturnID
	where tblLibraryUser.lib_UserType = 'Student' and penalty_Remarks='Unpaid')
	else
	(select tblLibraryUser.lib_SchoolID as SchoolID,tblLibraryUser.lib_Firstname as Firstname,tblLibraryUser.lib_Lastname as Lastname,
	tblLibraryUser.lib_Gender as Gender, tblLibraryUser.lib_Address as HomeAddress,tblLibraryUser.lib_ContactNumber as ContactNumber,
	tblLibraryUser.lib_WithCard as WithLibraryCard 
	from tblLibraryUser 
	where tblLibraryUser.lib_SchoolYear = @SchoolYear and tblLibraryUser.lib_UserType = @UserType)
END

select * from tblBorrow

create procedure sp_SearchBorrower
@Category varchar(50),
@SchoolYear varchar(50),
@UserType varchar(50),
@SearchKey varchar(100)
as begin
	if @Category = 'QR Code'
		(select tblLibraryUser.lib_SchoolID as SchoolID,tblLibraryUser.lib_Firstname as Firstname,tblLibraryUser.lib_Lastname as Lastname,
		tblLibraryUser.lib_Gender as Gender, tblLibraryUser.lib_Address as HomeAddress,tblLibraryUser.lib_ContactNumber as ContactNumber,
		tblLibraryUser.lib_WithCard as WithLibraryCard 
		from tblLibraryUser 
		where tblLibraryUser.lib_SchoolYear = @SchoolYear and tblLibraryUser.lib_UserType = @UserType and tblLibraryUser.lib_SchoolID  like '%'+@SearchKey+'%')
	else
	(select tblLibraryUser.lib_SchoolID as SchoolID,tblLibraryUser.lib_Firstname as Firstname,tblLibraryUser.lib_Lastname as Lastname,
		tblLibraryUser.lib_Gender as Gender, tblLibraryUser.lib_Address as HomeAddress,tblLibraryUser.lib_ContactNumber as ContactNumber,
		tblLibraryUser.lib_WithCard as WithLibraryCard 
		from tblLibraryUser 
		where tblLibraryUser.lib_SchoolYear = @SchoolYear and tblLibraryUser.lib_UserType = @UserType and 
		(tblLibraryUser.lib_Firstname  like '%'+@SearchKey+'%' or tblLibraryUser.lib_Lastname  like '%'+@SearchKey+'%'))
end

CREATE PROCEDURE sp_UpdateLibraryUser
@SchoolID varchar(50),
@Firstname varchar(100),
@Lastname varchar(100),
@Gender varchar(10),
@Address varchar(100),
@ContactNumber varchar(50),
@SchoolYear varchar(50),
@WithLibraryCard bit

AS
BEGIN
	update tblLibraryUser 
	set lib_Firstname = @Firstname, lib_Lastname = @Lastname, lib_Gender = @Gender, lib_Address = @Address, lib_ContactNumber = @ContactNumber, lib_WithCard = @WithLibraryCard
	where lib_SchoolID = @SchoolID and lib_SchoolYear = @SchoolYear

END



