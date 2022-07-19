USE [FOOTBALLSTARZ]
GO

/****** Object: Table [dbo].[Clubs] Script Date: 7/12/2022 2:11:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

TRUNCATE TABLE ClubsSRC

SET IDENTITY_INSERT ClubsSRC ON
INSERT INTO ClubsSRC
(
    [ClubId]    ,
    [ClubLogo]  ,
    [ClubName]  ,
    [Founded]   ,
    [StadiumId] ,
    [Liga],
    [Version],
    [TouchedStamp]

)
SELECT
   [ClubId]    ,
    [ClubLogo]  ,
    [ClubName]  ,
    [Founded]   ,
    [StadiumId] ,
    [Liga],
    [Version],
    [TouchedStamp]

FROM BAC_ClubsSRC
SET IDENTITY_INSERT ClubsSRC OFF
