use dbLibraryManagement

CREATE PROCEDURE sp_BorrowIDnumber
AS
DECLARE @ID int
SELECT @ID=IDENT_CURRENT('tblBorrow')
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

CREATE PROCEDURE sp_SelectBooks
@BookNum varchar(50),
@Title varchar(100),
@DueDate date

AS
BEGIN
	
	insert into tblSelectedBooks values(@BookNum, @Title, @DueDate)
END

CREATE PROCEDURE sp_DeleteSelectedBooks
@BookIDNum varchar(50)
AS
BEGIN
	delete from tblSelectedBooks where tblSelectedBooks.sb_BookIDNum = @BookIDNum
END

CREATE PROCEDURE sp_ViewSelectedBooks

AS
BEGIN
	SELECT dbo.tblSelectedBooks.sb_BookIDNum as BookIDNum, dbo.tblSelectedBooks.sb_Title as Title, dbo.tblSelectedBooks.sb_DueDate as DueDate
	FROM dbo.tblSelectedBooks
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

select * from tblAttendance

select * from tblBorrow