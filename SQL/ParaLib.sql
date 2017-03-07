--Fetch data from Para table
Create PROCEDURE ParaFetch
	@ParaId nvarchar(30) = null
With Encryption As
	SET NOCOUNT ON
	SET XACT_ABORT ON

	select PK, ParaId, ParaName, ParaValue
	from Para
	where (@ParaId is null or ParaId = @ParaId);
Go

--Update a row in Para table
Create PROCEDURE ParaUpdate
	@PK			bigint,
	@ParaName	nvarchar(200),
	@ParaValue	nvarchar(200)
With Encryption As
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	update Para
	set ParaName = @Paraname, ParaValue = @ParaValue
	where PK = @PK;
Go