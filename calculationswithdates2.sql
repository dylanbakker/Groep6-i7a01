SELECT tblEvent.EventName,
FORMAT (tblEvent.EventDate, 'd', 'en-US') AS 'Event date',
DATEDIFF(DAY,tblEvent.EventDate,'06/03/2000') AS 'Days offset',
ABS(DATEDIFF(DAY,tblEvent.EventDate,'06/03/2000')) AS 'Days difference'
FROM tblEvent
