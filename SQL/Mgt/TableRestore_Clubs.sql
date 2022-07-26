USE [FOOTBALLSTARZ]
GO

/****** Object: Table [dbo].[Clubs] Script Date: 7/12/2022 2:11:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

TRUNCATE TABLE Clubs

SET IDENTITY_INSERT Clubs ON
INSERT INTO Clubs
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

FROM BAC_Clubs
SET IDENTITY_INSERT Clubs OFF
