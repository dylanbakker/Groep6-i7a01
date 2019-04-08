SELECT tblEvent.EventName, len(eventname)
from tblEvent
where len(eventname) > (
SELECT AVG(LEN(tblEvent.EventName)) 
					 FROM tblEvent)