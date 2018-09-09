use dbLibraryManagement

---*STORED PROCEDURES*----

----FOR tblBook----
CREATE PROCEDURE sp_LastBookIDNum
AS
begin
	select tblBook.book_BookID from tblBook
end

CREATE PROCEDURE sp_AddBook
@BookNum varchar(50),
@BookType varchar(50),
@ISBN varchar(50),
@AccNum int,
@CallNum varchar(50),
@DateReceived date,
@Title varchar(200),
@Author varchar(50),
@Publisher varchar(100),
@CopyrightYear int,
@Edition varchar(50),
@Volume varchar(50),
@Pages int,
@Status varchar(20),
@Remarks varchar(200)
AS
BEGIN
	insert into tblBook values(@BookNum, @BookType, @ISBN, @CallNum, @Title, @Author, @Publisher, @CopyrightYear,@Edition,
								@Volume,@Pages,@Remarks)
	insert into tblBookCopy values(@AccNum, @DateReceived,@Status, @@IDENTITY)
END

CREATE PROCEDURE sp_AddBookCopy
@BookNum varchar(50),
@AccNum int,
@DateReceived date,
@Status varchar(20)
AS
BEGIN
	DECLARE @ID int
	select @ID = tblBook.book_BookID from dbo.tblBook INNER JOIN dbo.tblBookCopy ON dbo.tblBook.book_BookID = dbo.tblBookCopy.book_BookID
	WHERE tblBook.book_BookNum = @BookNum
	insert into tblBookCopy values(@AccNum, @DateReceived,@Status, @ID)
END

CREATE PROCEDURE sp_ViewBook
AS
BEGIN
	SELECT dbo.tblBook.book_BookNum as BookIDNumber, dbo.tblBook.book_BookType as BookType, dbo.tblBook.book_CallNum as CallNumber, 
		dbo.tblBook.book_Title as Title, dbo.tblBook.book_Author as Author, 
		dbo.tblBook.book_CopyrightYear as CopyrightYear
	FROM dbo.tblBook
	ORDER BY dbo.tblBook.book_BookID DESC
END

CREATE PROCEDURE sp_ViewBookCopy
@BookNum varchar(50)
AS
BEGIN
	SELECT tblBook.book_BookNum as BookIDNumber, tblBookCopy.copy_AccNum as AccessionNumber,
		tblBookCopy.copy_DateReceived as DateReceived, tblBookCopy.copy_Status as Status
	FROM dbo.tblBook INNER JOIN dbo.tblBookCopy ON dbo.tblBook.book_BookID = dbo.tblBookCopy.book_BookID
	WHERE tblBook.book_BookNum = @BookNum
	ORDER BY tblBookCopy.copy_AccNum DESC
END

CREATE PROCEDURE sp_UpdateBook
@BookNum varchar(50),
@BookType varchar(50),
@ISBN varchar(50),
@CallNum varchar(50),
@Title varchar(200),
@Author varchar(50),
@Publisher varchar(100),
@CopyrightYear int,
@Edition varchar(50),
@Volume varchar(50),
@Pages int,
@Remarks varchar(200)
AS
BEGIN
	update tblBook set dbo.tblBook.book_BookType = @BookType, tblBook.book_ISBN = @ISBN, tblBook.book_CallNum = @CallNum, tblBook.book_Title = @Title,
		tblBook.book_Author = @Author, tblBook.book_Publisher = @Publisher, tblBook.book_CopyrightYear = @CopyrightYear,
			tblBook.book_Edition = @Edition, tblBook.book_Volume = @Volume, tblBook.book_Pages = @Pages,
				tblBook.book_Remarks = @Remarks where tblBook.book_BookNum = @BookNum

END

CREATE PROCEDURE sp_UpdateBookStatus
@AccNum varchar(20),
@Status varchar(20)
AS
BEGIN
	update tblBookCopy
	set tblBookCopy.copy_Status = @Status
	where tblBookCopy.copy_AccNum = @AccNum
END

CREATE PROCEDURE sp_SearchBook
@Category varchar(50),
@searchKey varchar(50)
AS
BEGIN
	if @Category = 'QR Code'
	(SELECT dbo.tblBook.book_BookNum as BookIDNumber, dbo.tblBook.book_BookType as BookType, dbo.tblBook.book_CallNum as CallNumber, 
		dbo.tblBook.book_Title as Title, dbo.tblBook.book_Author as Author, 
		dbo.tblBook.book_CopyrightYear as CopyrightYear
	 FROM dbo.tblBook INNER JOIN dbo.tblBookCopy ON dbo.tblBook.book_BookID = dbo.tblBookCopy.book_BookID
	 where tblBookCopy.copy_AccNum like '%'+@searchKey+'%')
	 else if @Category = 'ISBN'
	(SELECT dbo.tblBook.book_BookNum as BookIDNumber, dbo.tblBook.book_BookType as BookType, dbo.tblBook.book_CallNum as CallNumber, 
		dbo.tblBook.book_Title as Title, dbo.tblBook.book_Author as Author, 
		dbo.tblBook.book_CopyrightYear as CopyrightYear
	 FROM dbo.tblBook INNER JOIN dbo.tblBookCopy ON dbo.tblBook.book_BookID = dbo.tblBookCopy.book_BookID
	 where tblBook.book_ISBN like '%'+@searchKey+'%')
	else
	(SELECT dbo.tblBook.book_BookNum as BookIDNumber, dbo.tblBook.book_BookType as BookType, dbo.tblBook.book_CallNum as CallNumber, 
		dbo.tblBook.book_Title as Title, dbo.tblBook.book_Author as Author, 
		dbo.tblBook.book_CopyrightYear as CopyrightYear
	 FROM dbo.tblBook 
	 where tblBook.book_Title like '%'+@searchKey+'%')
END

