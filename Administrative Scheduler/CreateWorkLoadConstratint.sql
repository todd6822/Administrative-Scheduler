USE [administrativeServer]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[createNewWorkLoadConstraint]
		@constraintName = N'Test',
		@Relation = N'Not More than',
		@interval = 5,
		@intervalTimeFrame = N'Per',
		@CycleValue = 1,
		@CycleTimeFrame = N'Week'

SELECT	@return_value as 'Return Value'

GO
