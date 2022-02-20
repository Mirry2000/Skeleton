USE [p2573296]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblAddress_SelectAll]

SELECT	@return_value as 'Return Value'

GO
