SELECT tblEvent.EventName,
tblCountry.CountryName
FROM tblCountry
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
WHERE tblEvent.EventID > (SELECT 
tblCountry.CountryName,
COUNT(tblEvent.EventName)

FROM tblEvent
INNER JOIN tblCountry ON tblCountry.CountryID = tblEvent.CountryID
GROUP BY tblCountry.CountryName)