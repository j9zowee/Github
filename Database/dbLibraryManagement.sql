CREATE database dbLibraryManagement
use dbLibraryManagement

----INDEPENDENT TABLES----
create table tblUserAccount(
user_UserID int identity(1,1) primary key,
user_UserNum varchar(50) not null,
user_Firstname varchar(50) not null,
user_Lastname varchar(50) not null,
user_Username varchar(50)not null,
user_Password varchar(50)not null,
user_SecretQuestion varchar(100)not null,
user_SecretAnswer varchar(100)not null,
user_UserType varchar(20)not null,
user_Status varchar(10) not null)

create table tblLibraryUser(
lib_UserID int identity(1,1) primary key,	
lib_SchoolID varchar(20) not null,
lib_Firstname varchar(100)not null,
lib_Lastname varchar(100)not null,
lib_Gender varchar(10),
lib_Address varchar(100),
lib_ContactNumber varchar(50),
lib_UserType varchar(50) not null,
lib_SchoolYear varchar(50) not null,
lib_WithCard bit)

create table tblBook(
book_BookID int identity(1,1) primary key,
book_BookNum varchar(50)not null,
book_BookType varchar(50) not null,
book_ISBN varchar(50) not null,
book_CallNum varchar(50),
book_Title varchar(200)not null,
book_Author varchar(50),
book_Publisher varchar(100) not null,
book_CopyrightYear int not null,
book_Edition varchar(50),
book_Volume varchar(50),
book_Pages int,
book_Remarks varchar(200))

create table tblBookCopy(
copy_CopyID int identity(1,1) primary key,
copy_AccNum varchar(20) not null,
copy_DateReceived date,
copy_Status varchar(20),
book_BookID int foreign key references tblBook(book_BookID))

create table tblNonReadingMaterial(
nrm_MaterialID int identity(1,1) primary key,
nrm_MaterialNum varchar(50) not null,
nrm_MaterialType varchar(20) not null,
nrm_Title varchar(100) not null,
nrm_Volume varchar(20) not null,
nrm_Issue varchar(20) not null,
nrm_CopyrightYear int not null,
nrm_Author varchar(100) not null,
nrm_Publisher varchar(100) not null,
nrm_Page int not null,
nrm_NumberOfCopies int not null
)

----TRANSACTION TABLES---
create table tblBorrow(
borrow_BorrowID int identity(1,1) primary key,
borrow_BorrowNum varchar(50)not null,
lib_UserID int foreign key references tblLibraryUser(lib_UserID),
copy_CopyID int foreign key references tblBookCopy(copy_CopyID),
borrow_BorrowedDate date not null,
borrow_DueDate date not null)

create table tblReturn(
return_ReturnID int identity(1,1) primary key,
return_ReturnNum varchar(50) not null,
borrow_BorrowID int foreign key references tblBorrow(borrow_BorrowID),
return_ReturnDate date not null)


create table tblPenalty(
penalty_PenaltyID int identity(1,1) primary key,
penalty_NumOfDaysUnreturned int,
penalty_PenaltyFee decimal,
penalty_Remarks varchar(50),
return_ReturnID int foreign key references tblReturn(return_ReturnID))

create table tblAttendance(
attendance_AttendanceID int identity(1,1) primary key,
attendance_StudentIDNum varchar(50) not null,
attendance_Firstname varchar(50),
attendance_Lastname varchar(50),
attendance_LoginTime datetime)
