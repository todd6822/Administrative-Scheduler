﻿USE [administrativeServer]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[returnMemberNotOnLeave]
		@scheduleDay = NULL

SELECT	@return_value as 'Return Value'

GO
