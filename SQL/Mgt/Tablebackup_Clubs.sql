USE [FOOTBALLSTARZ]
GO

/****** Object: Table [dbo].[Clubs] Script Date: 7/12/2022 2:11:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('BAC_Clubs', 'U') IS NOT NULL
	DROP TABLE [dbo].[BAC_Clubs]
GO

CREATE TABLE [dbo].[BAC_Clubs] (
    [ClubId]    INT            IDENTITY (1, 1) NOT NULL,
    [ClubLogo]  NVARCHAR (MAX) NOT NULL,
    [ClubName]  NVARCHAR (MAX) NOT NULL,
    [Founded]   DATETIME2 (7)  NOT NULL,
    [StadiumId] INT            NOT NULL
    --[Liga]      INT            NOT NULL DEFAULT 0,
    --[Version]   INT             NOT NULL DEFAULT 0,
    --[TouchedStamp] DateTime     NULL
);

SET IDENTITY_INSERT BAC_Clubs ON
INSERT INTO BAC_Clubs
(
    [ClubId]    ,
    [ClubLogo]  ,
    [ClubName]  ,
    [Founded]   ,
    [StadiumId] 
    --[Liga],
    --[Version],
    --[TouchedStamp]

)
SELECT
   [ClubId]    ,
    [ClubLogo]  ,
    [ClubName]  ,
    [Founded]   ,
    [StadiumId] 
    --[Liga],
    --[Version],
    --[TouchedStamp]
FROM Clubs
SET IDENTITY_INSERT BAC_Clubs OFF

