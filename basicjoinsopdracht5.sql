SELECT tblEvent.EventName AS EventName,
tblEvent.EventDate AS EventDate,
tblCategory.CategoryName AS CategoryName
FROM tblEvent
FULL OUTER JOIN tblCategory ON tblCategory.CategoryID = tblEvent.CategoryID
WHERE tblEvent.EventName is NULL