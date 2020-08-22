USE [administrativeServer]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[returnConstraintsByWorkloadNameWithRowNUmber]
		@workLoadName = N'G Line'

SELECT	@return_value as 'Return Value'

GO
