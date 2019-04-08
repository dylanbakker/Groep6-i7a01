SELECT tblEvent.EventName,
tblEvent.EventDate,
DATENAME(WEEKDAY,tblEvent.EventDate) AS [Day of week],
DAY(tblEvent.EventDate) AS [Day number]
FROM tblEvent
/*WHERE DAY(tblEvent.EventDate)= 12 AND  DATENAME(WEEKDAY,tblEvent.EventDate) ='Thursday' */
/*WHERE DAY(tblEvent.EventDate)= 14 AND DATENAME(WEEKDAY,tblEvent.EventDate) ='Saturday'*/
WHERE DAY(tblEvent.EventDate)= 13 AND DATENAME(WEEKDAY,tblEvent.EventDate) ='Friday'