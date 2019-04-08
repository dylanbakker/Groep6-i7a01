SELECT 
tblEvent.EventName,
LEN( tblEvent.EventName) AS 'Length of name'
FROM tblEvent
ORDER BY 'Length of name' ASC
