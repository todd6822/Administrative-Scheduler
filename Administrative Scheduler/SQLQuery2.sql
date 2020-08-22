USE [administrativeServer]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[selectTimerValuesAndDateFromView]
		@memberNumber = 7,
		@constraintNumber = 2

SELECT	@return_value as 'Return Value'

GO
