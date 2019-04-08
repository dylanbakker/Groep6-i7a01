SELECT 
COUNT(tblEvent.EventID) AS [Number of events],
MAX(tblEvent.EventDate) AS [Last date],
MIN(tblEvent.EventDate) AS [First date]
FROM tblEvent