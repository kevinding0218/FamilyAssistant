USE [FamilyAssistant]
GO
/****** Object:  StoredProcedure [dbo].[GetNumberOfEntreeByVegeId]    Script Date: 1/12/2018 9:36:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEntreeInfoById]
	@Id INT = NULL,
	@Type NVARCHAR(20) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @Type = 'Vegetable'
	BEGIN
		SELECT e.Id AS EntreeId, e.Name AS EntreeName, 
		ISNULL(ev1.VegetableCount, 0) AS VegetableCount, ISNULL(em.MeatCount, 0) AS MeatCount,
		'' AS EntreeDetailList
		FROM FamilyAssistant.dbo.Entree e
		LEFT JOIN FamilyAssistant.dbo.EntreeVegetable ev ON e.Id = ev.EntreeId
		LEFT JOIN (
			SELECT COUNT(*) AS VegetableCount , EntreeId 
			FROM dbo.EntreeVegetable  
			GROUP BY EntreeId
		) ev1 ON ev1.EntreeId = e.Id
		LEFT JOIN (
			SELECT COUNT(*) AS MeatCount , EntreeId 
			FROM dbo.EntreeMeat  
			GROUP BY EntreeId
		) em ON em.EntreeId = e.Id
		WHERE ev.VegeId = @Id
	END
	ELSE IF @Type = 'Meat'
	BEGIN
		SELECT e.Id AS EntreeId, e.Name AS EntreeName, ISNULL(ev.VegetableCount, 0) AS VegetableCount, ISNULL(em2.MeatCount, 0) AS MeatCount
		FROM FamilyAssistant.dbo.Entree e
		LEFT JOIN FamilyAssistant.dbo.EntreeMeat em ON e.Id = em.EntreeId
		LEFT JOIN (
			SELECT COUNT(*) AS VegetableCount , EntreeId 
			FROM dbo.EntreeVegetable  
			GROUP BY EntreeId
		) ev ON ev.EntreeId = e.Id
		LEFT JOIN (
			SELECT COUNT(*) AS MeatCount , EntreeId 
			FROM dbo.EntreeMeat  
			GROUP BY EntreeId
		) em2 ON em2.EntreeId = e.Id
		WHERE em.MeatId = @Id
	END
	ELSE IF @Type = 'Entree'
	BEGIN
		SELECT e.Id AS EntreeId, e.Name AS EntreeName, ISNULL(ev1.VegetableCount, 0) AS VegetableCount, ISNULL(em.MeatCount, 0) AS MeatCount
		FROM FamilyAssistant.dbo.Entree e
		LEFT JOIN FamilyAssistant.dbo.EntreeVegetable ev ON e.Id = ev.EntreeId
		LEFT JOIN (
			SELECT COUNT(*) AS VegetableCount , EntreeId 
			FROM dbo.EntreeVegetable  
			GROUP BY EntreeId
		) ev1 ON ev1.EntreeId = e.Id
		LEFT JOIN (
			SELECT COUNT(*) AS MeatCount , EntreeId 
			FROM dbo.EntreeMeat  
			GROUP BY EntreeId
		) em ON em.EntreeId = e.Id
	END
	ELSE IF @Type = 'EntreeDetail'
	BEGIN
	    SELECT e.Id AS EntreeId, e.Name AS EntreeName, ISNULL(v.Name, '') AS Vegetable, ISNULL(m.Name, '') AS Meat
		FROM FamilyAssistant.dbo.Entree e
		LEFT JOIN FamilyAssistant.dbo.EntreeVegetable ev ON e.Id = ev.EntreeId
		LEFT JOIN FamilyAssistant.dbo.Vegetable v ON v.Id = ev.VegeId
		LEFT JOIN FamilyAssistant.dbo.EntreeMeat em ON e.Id = em.EntreeId
		LEFT JOIN FamilyAssistant.dbo.Meat m ON m.Id = em.MeatId
		WHERE e.Id = @Id
	END
END
