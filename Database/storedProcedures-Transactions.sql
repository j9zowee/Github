use dbLibraryManagement

CREATE PROCEDURE sp_BorrowIDnumber
AS
DECLARE @ID int
SELECT @ID=IDENT_CURRENT('tblBorrow')
RETURN @ID;
select * from tblBorrow

CREATE PROCEDURE sp_ReturnIDnumber
AS
DECLARE @ID int
SELECT @ID=IDENT_CURRENT('tblReturn')
RETURN @ID;

CREATE PROCEDURE sp_BorrowBook
@BorrowNum varchar(50),
@SchoolID varchar(50),
@BookNum varchar(50),
@BorrowedDate datetime,
@DueDate date
AS
BEGIN
	DECLARE @libUserID int
	Declare @bookID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID
	select @bookID = dbo.tblBook.book_BookID FROM dbo.tblBook where tblBook.book_BookNum = @BookNum
	insert into tblBorrow values(@BorrowNum,@libUserID,@bookID,@BorrowedDate,@DueDate)
END


CREATE PROCEDURE sp_Attendance
@StudentID varchar(50),
@Firstname varchar(50),
@Lastname varchar(50),
@LoginTime datetime

AS
BEGIN
	insert into tblAttendance values(@StudentID,@Firstname,@Lastname,@LoginTime)
END

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
----

create procedure sp_Login
@username varchar(50),
@password varchar(50)
as 
begin
	select * from tblUserAccount where tblUserAccount.user_Username = @username and tblUserAccount.user_Password = @password

end

