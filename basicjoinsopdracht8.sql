SELECT tblCountry.CountryName,
tblEvent.EventName
FROM tblCountry
FULL OUTER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
 WHERE tblEvent.EventName is Null