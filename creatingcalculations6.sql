SELECT tblEvent.EventName,
tblEvent.EventDate,
CHARINDEX('this',EventDetails)AS thisPosition,
CHARINDEX('that',EventDetails)AS thatPosition,
CHARINDEX('that', EventDetails) - CHARINDEX('this',EventDetails) AS Offset
FROM tblEvent
WHERE EventDetails LIKE '%this%that%'