SELECT
tblEvent.EventName,
tblEvent.EventDate,
tblCountry.CountryName
FROM tblEvent
INNER JOIN tblCountry ON tblCountry.CountryID = tblEvent.CountryID
WHERE tblEvent.EventDate >(SELECT MAX(tblEvent.EventDate)
							FROM tblEvent
							WHERE tblEvent.CountryID = 21
						  )
ORDER BY tblEvent.EventDate DESC