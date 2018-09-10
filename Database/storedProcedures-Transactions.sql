use dbLibraryManagement

------------BORROW-------------
CREATE PROCEDURE sp_LastBorrowNumber
AS
begin
	select tblBorrow.borrow_BorrowID from tblBorrow
end

CREATE PROCEDURE sp_BorrowBook
@BorrowNum varchar(50),
@SchoolID varchar(50),
@AccNum varchar(50),
@BorrowedDate datetime,
@DueDate date,
@CurrentSchoolYear varchar(50)
AS
BEGIN
	DECLARE @libUserID int
	Declare @copyID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID and tblLibraryUser.lib_SchoolYear = @CurrentSchoolYear
	select @copyID = dbo.tblBookCopy.copy_CopyID FROM dbo.tblBookCopy where tblBookCopy.copy_AccNum = @AccNum
	insert into tblBorrow values(@BorrowNum,@libUserID,@copyID,@BorrowedDate,@DueDate)
END
select * from tblBookCopy

CREATE PROCEDURE sp_BorrowedBooks
@SchoolID varchar(50)
AS
BEGIN
	DECLARE @libUserID int
	declare @currentSY datetime
	select @currentSY = max(tblLibraryUser.lib_SchoolYear) from tblLibraryUser
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID and dbo.tblLibraryUser.lib_SchoolYear = @currentSY
	
	select tblBookCopy.copy_AccNum, tblBook.book_Title, tblBook.book_Author,
	tblBook.book_CopyrightYear, tblBorrow.borrow_BorrowedDate,tblBorrow.borrow_DueDate
	FROM dbo.tblBorrow INNER JOIN dbo.tblBookCopy ON dbo.tblBorrow.copy_CopyID = dbo.tblBookCopy.copy_CopyID 
	INNER JOIN dbo.tblBook ON dbo.tblBookCopy.book_BookID = dbo.tblBook.book_BookID
	 where tblBorrow.lib_UserID = @libUserID and tblBookCopy.copy_Status = 'Borrowed'
END

CREATE PROCEDURE sp_GetBorrowIDForReturn
@SchoolID varchar(50),
@BookNum varchar(50)
AS
BEGIN
	DECLARE @libUserID int
	Declare @bookID int
	Declare @borrowID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID
	select @bookID = dbo.tblBook.book_BookID FROM dbo.tblBook where tblBook.book_BookNum = @BookNum
	select @borrowID=tblBorrow.borrow_BorrowID from tblBorrow where tblBorrow.lib_UserID = @libUserID and tblBorrow.book_BookID = @bookID
	return @borrowID
	
END
select *from tblBookCopy
-------------END OF BORROW------------

--------------ATTENDANCE--------------
CREATE PROCEDURE sp_Attendance
@StudentID varchar(50),
@Firstname varchar(50),
@Lastname varchar(50),
@LoginTime datetime

AS
BEGIN
	insert into tblAttendance values(@StudentID,@Firstname,@Lastname,@LoginTime)
END
---------------END OF ATTENDANCE-------------

----------------------RETURN-----------------
CREATE PROCEDURE sp_ReturnIDnumber
AS
DECLARE @ID int
SELECT @ID=IDENT_CURRENT('tblReturn')
RETURN @ID;

create PROCEDURE sp_ReturnBook
@ReturnNum varchar(50),
@SchoolID varchar(50),
@BookNum varchar(50),
@ReturnDate date,
@NumOfDaysUnreturned int,
@Penalty decimal,
@PenaltyRemarks varchar(20)
AS
BEGIN
	DECLARE @libUserID int
	Declare @bookID int
	Declare @borrowID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID
	select @bookID = dbo.tblBook.book_BookID FROM dbo.tblBook where tblBook.book_BookNum = @BookNum
	select @borrowID=tblBorrow.borrow_BorrowID from tblBorrow where tblBorrow.lib_UserID = @libUserID and tblBorrow.book_BookID = @bookID

	insert into tblReturn values(@ReturnNum,@borrowID,@ReturnDate)
	insert into tblPenalty values(@NumOfDaysUnreturned,@Penalty,@PenaltyRemarks,@@IDENTITY)
END
-----------------END OF RETURN---------------


-------------USER LOGIN---------------
create procedure sp_Login
@username varchar(50),
@password varchar(50)
as 
begin
	select * from tblUserAccount where tblUserAccount.user_Username = @username and tblUserAccount.user_Password = @password

end
--------------END OF USER LOGIN

----this is not yet created
CREATE PROCEDURE sp_GetBorrowedBooks
@SchoolID varchar(50)
AS
BEGIN
	DECLARE @libUserID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID
	SELECT        dbo.tblBorrow.borrow_BorrowNum, dbo.tblBook.book_Title, dbo.tblBook.book_Author, dbo.tblBook.book_CopyrightYear, dbo.tblBorrow.borrow_BorrowedDate, 
                         dbo.tblBorrow.borrow_DueDate
	FROM            dbo.tblLibraryUser INNER JOIN
                         dbo.tblBorrow ON dbo.tblLibraryUser.lib_UserID = dbo.tblBorrow.lib_UserID INNER JOIN
                         dbo.tblBook ON dbo.tblBorrow.book_BookID = dbo.tblBook.book_BookID
	
END
---------------


------------------------ NEW - Non Reading Materials --------------------
CREATE PROCEDURE sp_AddNonReadingMaterial
@nrm_MaterialNum varchar(50),
@nrm_MaterialType varchar(20),
@nrm_Title varchar(100),
@nrm_Volume varchar(20),
@nrm_Issue varchar(20),
@nrm_CopyrightYear int,
@nrm_Author varchar(100),
@nrm_Publisher varchar(100),
@nrm_Page int,
@nrm_NumberOfCopies int
AS
BEGIN
	INSERT INTO tblNonReadingMaterial
		VALUES (@nrm_MaterialNum, @nrm_MaterialType, @nrm_Title, @nrm_Volume, @nrm_Issue
			,@nrm_CopyrightYear, @nrm_Author, @nrm_Publisher, @nrm_Page, @nrm_NumberOfCopies)
END


CREATE PROCEDURE sp_ViewNonReadingMaterial
AS
BEGIN
	SELECT * FROM tblNonReadingMaterial
END

CREATE PROCEDURE sp_UpdateNonReadingMaterial
@nrm_MaterialNum varchar(50),
@nrm_MaterialType varchar(20),
@nrm_Title varchar(100),
@nrm_Volume varchar(20),
@nrm_Issue varchar(20),
@nrm_CopyrightYear int,
@nrm_Author varchar(100),
@nrm_Publisher varchar(100),
@nrm_Page int,
@nrm_NumberOfCopies int
AS
BEGIN
	UPDATE tblNonReadingMaterial
		SET nrm_MaterialNum = @nrm_MaterialNum, nrm_MaterialType = @nrm_MaterialType, nrm_Title = @nrm_Title
			, nrm_Volume = @nrm_Volume, nrm_Issue = @nrm_Issue, nrm_CopyrightYear = @nrm_CopyrightYear
				, nrm_Author = @nrm_Author, nrm_Publisher = @nrm_Publisher, nrm_Page = @nrm_Page
					, nrm_NumberOfCopies = @nrm_NumberOfCopies
		WHERE @nrm_MaterialNum = nrm_MaterialNum
END
------------------------ NEW - Non Reading Materials --------------------