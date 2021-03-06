USE [FamilyAssistant]
GO
/****** Object:  StoredProcedure [dbo].[GetNumberOfEntreeByVegeId]    Script Date: 1/14/2018 3:22:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetNumberOfEntreeById]
	@Id INT,
	@Type NVARCHAR(20) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @Type = 'Vegetable'
	BEGIN
		SELECT COUNT(*) AS TotalEntrees FROM EntreeVegetable WHERE VegeId = @Id
	END
	ELSE IF @Type = 'Meat'
	BEGIN
		SELECT COUNT(*) AS TotalEntrees FROM dbo.EntreeMeat WHERE MeatId = @Id
	END
END
