SELECT tblEvent.EventName,
tblEvent.EventDate AS NotFormatted,
FORMAT (tblEvent.EventDate, 'd', 'en-US') AS UsingFormat,  
CONVERT (date,tblEvent.EventDate) AS UsingConvert

FROM tblEvent
WHERE YEAR(tblEvent.EventDate)= '2000'