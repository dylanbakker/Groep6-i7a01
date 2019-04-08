SELECT tblContinent.ContinentName,
tblEvent.EventName
FROM tblCountry
INNER JOIN tblContinent ON tblContinent.ContinentID = tblCountry.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
WHERE tblContinent.ContinentName in (SELECT TOP 3 tblContinent.ContinentName

FROM tblCountry
INNER JOIN tblContinent ON tblContinent.ContinentID = tblCountry.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
GROUP BY tblContinent.ContinentName
ORDER BY COUNT(tblEvent.EventName))