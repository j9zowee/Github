use dbLibraryManagement
----for tblUser---
CREATE PROCEDURE sp_AccountIDnumber
AS
DECLARE @ID int
SELECT @ID=IDENT_CURRENT('tblUserAccount')
RETURN @ID;

create procedure sp_AddAccount
@UserNum varchar(50),
@Firstname varchar(100),
@Lastname varchar(100),
@Username varchar(50),
@Password varchar(50),
@SecretQuestion varchar(100),
@SecretAnswer varchar(100),
@UserType varchar(20),
@Status varchar(10)
as
begin
	insert into tblUser values(@UserNum, @Firstname, @Lastname, @Username, @Password,@SecretQuestion, @SecretAnswer,@UserType, @Status)
end

create PROCEDURE sp_ViewActiveAccount
AS
BEGIN
	SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType, dbo.tblUser.user_Status as UserStatus
	FROM dbo.tblUserAccount
	where dbo.tblUser.user_Status = 'Active'
END

create PROCEDURE sp_ViewInactiveAccount
AS
BEGIN
	SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
	dbo.tblUser.user_Status as UserStatus
	FROM dbo.tblUser
	where dbo.tblUser.user_Status = 'Inactive' or dbo.tblUser.user_Status = 'Deactivate'
END

create PROCEDURE sp_UpdateAccount
@UserNum varchar(50),
@Firstname varchar(100),
@Lastname varchar(100),
@Username varchar(50),
@Password varchar(50),
@SecretQuestion varchar(100),
@SecretAnswer varchar(100),
@UserType varchar(20),
@Status varchar(10)
AS
BEGIN
	update tblUser
	set tblUser.user_Firstname=@Firstname, tblUser.user_Lastname=@Lastname, tblUser.user_Username=@Username, tblUser.user_Password=@Password, tblUser.user_SecretQuestion=@SecretQuestion,
		tblUser.user_SecretAnswer=@SecretAnswer, tblUser.user_UserType=@UserType, tblUser.user_Status=@Status
	from tblUser
	where tblUser.user_UserNum= @UserNum	
END

create PROCEDURE sp_UpdateAccountStatus
@UserNum varchar(50),
@Status varchar(10)
AS
BEGIN
	update tblUser
	set tblUser.user_Status=@Status from tblUser
	where tblUser.user_UserNum= @UserNum	
END

CREATE PROCEDURE sp_SearchActiveAccount
@Category varchar(50),
@searchkey varchar(50)
AS
BEGIN

	if @Category = 'QR Code'	
	(SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType as UserType, dbo.tblUser.user_Status as UserStatus
	 FROM dbo.tblUser
	 where tblUser.user_UserNum like '%'+@searchKey+'%' and tblUser.user_Status = 'Active')
	else if @Category = 'Lastname'
	(SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType as UserType, dbo.tblUser.user_Status as UserStatus
	 FROM dbo.tblUser
	 where tblUser.user_Lastname like '%'+@searchKey+'%' and tblUser.user_Status = 'Active')
	else
	(SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType as UserType, dbo.tblUser.user_Status as UserStatus
	 FROM dbo.tblUser
	 where tblUser.user_Firstname like '%'+@searchKey+'%' and tblUser.user_Status = 'Active')
	
END

CREATE PROCEDURE sp_SearchInactiveAccount
@Category varchar(50),
@searchkey varchar(50)
AS
BEGIN
	if @Category = 'QR Code'
	(SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType, dbo.tblUser.user_Status as UserStatus
	 FROM dbo.tblUser
	 where tblUser.user_UserNum like '%'+@searchKey+'%' and (dbo.tblUser.user_Status = 'Inactive' or dbo.tblUser.user_Status = 'Deactivate'))
	else if @Category = 'Lastname'
	(SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType, dbo.tblUser.user_Status as UserStatus
	 FROM dbo.tblUser
	 where tblUser.user_Lastname like '%'+@searchKey+'%' and (dbo.tblUser.user_Status = 'Inactive' or dbo.tblUser.user_Status = 'Deactivate'))
	else
	(SELECT dbo.tblUser.user_UserNum, dbo.tblUser.user_Firstname, dbo.tblUser.user_Lastname, 
		dbo.tblUser.user_Username, dbo.tblUser.user_Password, dbo.tblUser.user_SecretQuestion, dbo.tblUser.user_SecretAnswer, 
		 dbo.tblUser.user_UserType, dbo.tblUser.user_Status as UserStatus
	 FROM dbo.tblUser
	 where tblUser.user_Firstname like '%'+@searchKey+'%' and (dbo.tblUser.user_Status = 'Inactive' or dbo.tblUser.user_Status = 'Deactivate'))
	
END

select * from tblAttendance