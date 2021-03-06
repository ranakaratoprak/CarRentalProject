CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] MONEY NULL, 
    [Description] NVARCHAR(50) NOT NULL
)
