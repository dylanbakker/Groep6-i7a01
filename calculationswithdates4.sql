SELECT tblEvent.EventName,
DATENAME(DW, tblEvent.EventDate) + ' ' +
DATENAME(DD, tblEvent.EventDate) + 'th ' +
DATENAME(MM, tblEvent.EventDate) + ' ' +
DATENAME(YY, tblEvent.EventDate) AS 'Full date'

FROM tblEvent