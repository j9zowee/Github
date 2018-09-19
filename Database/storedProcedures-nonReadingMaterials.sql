------------------------ NEW - Non Reading Materials --------------------
CREATE PROCEDURE sp_LastNonReadingIDNumber
AS
BEGIN
	select * from tblNonReadingMaterial
END

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
	SELECT nrm_MaterialNum as MaterialNumber, nrm_MaterialType as MaterialType, nrm_Title as Title, nrm_Volume as Volume, nrm_Issue as Issue, nrm_CopyrightYear as CopyrightYear,
		nrm_Author as Author, nrm_Publisher as Publisher, nrm_Page as Page, nrm_NumberOfCopies as NumberOfCopies
	FROM tblNonReadingMaterial
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

CREATE PROCEDURE sp_SearchNonReadingMaterial
@searchKey varchar(100)
AS
BEGIN
	SELECT nrm_MaterialNum as MaterialNumber, nrm_MaterialType as MaterialType, nrm_Title as Title, nrm_Volume as Volume, nrm_Issue as Issue, nrm_CopyrightYear as CopyrightYear,
		nrm_Author as Author, nrm_Publisher as Publisher, nrm_Page as Page, nrm_NumberOfCopies as NumberOfCopies
	FROM tblNonReadingMaterial
		WHERE tblNonReadingMaterial.nrm_Title like '%'+@searchKey+'%'
END


------------------------ NEW - Non Reading Materials --------------------