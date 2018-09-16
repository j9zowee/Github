use dbLibraryManagement
----for tblUser---
CREATE PROCEDURE sp_LastAcctIDNum
AS
begin
	select tblUserAccount.user_UserID from tblUserAccount
end

CREATE PROCEDURE sp_CheckUsername
@Username varchar(50)
AS
begin
	select * from tblUserAccount where tblUserAccount.user_Username = @Username
end 

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
	
	insert into tblUserAccount values(@UserNum, @Firstname, @Lastname, @Username, @Password,@SecretQuestion, @SecretAnswer,@UserType, @Status)
end

create PROCEDURE sp_ViewAccount
@acctType varchar(50),
@userType varchar(50)
AS
BEGIN
	if @acctType = 'Inactive' and @userType = 'Admin'
	(SELECT dbo.tblUserAccount.user_UserNum, dbo.tblUserAccount.user_Firstname, dbo.tblUserAccount.user_Lastname, dbo.tblUserAccount.user_Username,
	dbo.tblUserAccount.user_Status as UserStatus
	FROM dbo.tblUserAccount
	where dbo.tblUserAccount.user_Status = 'Inactive' and tblUserAccount.user_UserType != 'SuperAdmin')
	else if @acctType = 'Active' and @userType = 'Admin'
	(SELECT dbo.tblUserAccount.user_UserNum, dbo.tblUserAccount.user_Firstname, dbo.tblUserAccount.user_Lastname, dbo.tblUserAccount.user_Username,
	dbo.tblUserAccount.user_Status as UserStatus
		FROM dbo.tblUserAccount
		where dbo.tblUserAccount.user_Status = 'Active' and tblUserAccount.user_UserType != 'SuperAdmin')
	else if @acctType = 'Active' and @userType = 'SuperAdmin'
	(SELECT dbo.tblUserAccount.user_UserNum, dbo.tblUserAccount.user_Firstname, dbo.tblUserAccount.user_Lastname, dbo.tblUserAccount.user_Username,
	dbo.tblUserAccount.user_Status as UserStatus
		FROM dbo.tblUserAccount
		where dbo.tblUserAccount.user_Status = 'Active')
	else
	(SELECT dbo.tblUserAccount.user_UserNum, dbo.tblUserAccount.user_Firstname, dbo.tblUserAccount.user_Lastname, dbo.tblUserAccount.user_Username,
	dbo.tblUserAccount.user_Status as UserStatus
		FROM dbo.tblUserAccount
		where dbo.tblUserAccount.user_Status = 'Inactive')
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
	update tblUserAccount
	set tblUserAccount.user_Firstname=@Firstname, tblUserAccount.user_Lastname=@Lastname, tblUserAccount.user_Username=@Username, tblUserAccount.user_Password=@Password, tblUserAccount.user_SecretQuestion=@SecretQuestion,
		tblUserAccount.user_SecretAnswer=@SecretAnswer, tblUserAccount.user_UserType=@UserType, tblUserAccount.user_Status=@Status
	from tblUserAccount
	where tblUserAccount.user_UserNum= @UserNum	
END

create PROCEDURE sp_UpdatePassword
@Username varchar(50),
@Password varchar(10)
AS
BEGIN
	update tblUserAccount
	set tblUserAccount.user_Password=@Password from tblUserAccount
	where tblUserAccount.user_Username= @Username	
END

create PROCEDURE sp_UpdateAccountStatus
@UserNum varchar(50),
@Status varchar(10)
AS
BEGIN
	update tblUserAccount
	set tblUserAccount.user_Status=@Status from tblUserAccount
	where tblUserAccount.user_UserNum= @UserNum	
END

CREATE PROCEDURE sp_SearchAccount
@AccType varchar(50),
@searchkey varchar(50)
AS
BEGIN

	if @accType = 'Active'	
	(SELECT dbo.tblUserAccount.user_UserNum, dbo.tblUserAccount.user_Firstname, dbo.tblUserAccount.user_Lastname, dbo.tblUserAccount.user_Username,
	dbo.tblUserAccount.user_Status as UserStatus
	FROM dbo.tblUserAccount
	 where (tblUserAccount.user_UserNum like '%'+@searchKey+'%' or tblUserAccount.user_Firstname like '%'+@searchKey+'%' or tblUserAccount.user_Lastname like '%'+@searchKey+'%')and tblUserAccount.user_Status = 'Active' and tblUserAccount.user_UserType != 'SuperAdmin')
	else 
	(SELECT dbo.tblUserAccount.user_UserNum, dbo.tblUserAccount.user_Firstname, dbo.tblUserAccount.user_Lastname, dbo.tblUserAccount.user_Username,
	dbo.tblUserAccount.user_Status as UserStatus
	FROM dbo.tblUserAccount
	 where (tblUserAccount.user_UserNum like '%'+@searchKey+'%' or tblUserAccount.user_Firstname like '%'+@searchKey+'%' or tblUserAccount.user_Lastname like '%'+@searchKey+'%')and (dbo.tblUserAccount.user_Status = 'Inactive' or dbo.tblUserAccount.user_Status = 'Deactivate') and tblUserAccount.user_UserType != 'SuperAdmin')
END

