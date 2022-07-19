--
-- Initial - queries die de begintoestand zetten.

-- 1. Clubs

-- 1.1 Initieer TouchStamp met 01-01-1970

	DECLARE @initts DATETIME = ' 1970-01-01 00:00:00' 

	UPDATE Clubs SET TouchStamp = @initts

	DECLARE @liga int = 1

	UPDATE Clubs SET Liga = @liga

