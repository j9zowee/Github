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
select * from tblAttendance
select * from tblBorrow

CREATE PROCEDURE sp_BorrowedBooks
@SchoolID varchar(50)
AS
BEGIN
	SELECT dbo.tblBookCopy.copy_AccNum as AccessionNumber, dbo.tblBook.book_Title as Title, dbo.tblBook.book_Author as Author, 
	dbo.tblBook.book_Publisher as Publisher, dbo.tblBook.book_CopyrightYear as CopyrightYear, 
        dbo.tblBorrow.borrow_BorrowedDate as BorrowedDate, dbo.tblBorrow.borrow_DueDate as DueDate
		FROM dbo.tblLibraryUser INNER JOIN dbo.tblBorrow ON dbo.tblLibraryUser.lib_UserID = dbo.tblBorrow.lib_UserID INNER JOIN
        dbo.tblBookCopy ON dbo.tblBorrow.copy_CopyID = dbo.tblBookCopy.copy_CopyID INNER JOIN
        dbo.tblBook ON dbo.tblBookCopy.book_BookID = dbo.tblBook.book_BookID
		where tblLibraryUser.lib_SchoolID=@SchoolID and tblBookCopy.copy_Status = 'Borrowed'
END

CREATE PROCEDURE sp_GetBorrowIDForReturn
@SchoolID varchar(50),
@AccNum varchar(50)
AS
BEGIN
	
	Declare @borrowID int
	SELECT @borrowID=dbo.tblBorrow.borrow_BorrowID
	FROM dbo.tblLibraryUser INNER JOIN dbo.tblBorrow ON dbo.tblLibraryUser.lib_UserID = dbo.tblBorrow.lib_UserID INNER JOIN
    dbo.tblBookCopy ON dbo.tblBorrow.copy_CopyID = dbo.tblBookCopy.copy_CopyID
	where tblLibraryUser.lib_SchoolID = @SchoolID and tblBookCopy.copy_AccNum = @AccNum
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
CREATE PROCEDURE sp_LastReturnNumber
AS
begin
	select tblReturn.return_ReturnID from tblReturn
end

create PROCEDURE sp_ReturnBook
@ReturnNum varchar(50),
@SchoolID varchar(50),
@AccNum varchar(50),
@ReturnDate date,
@NumOfDaysUnreturned int,
@Penalty decimal,
@PenaltyRemarks varchar(20)
AS
BEGIN
	DECLARE @libUserID int
	Declare @copyID int
	Declare @borrowID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID
	select @copyID = dbo.tblBookCopy.copy_CopyID FROM dbo.tblBookCopy where tblBookCopy.copy_AccNum = @AccNum
	select @borrowID=tblBorrow.borrow_BorrowID from tblBorrow where tblBorrow.lib_UserID = @libUserID and tblBorrow.copy_CopyID = @copyID

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
drop PROCEDURE sp_ViewBorrowedBooks
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


