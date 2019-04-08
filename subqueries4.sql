SELECT tblCountry.CountryName,
tblEvent.EventName
FROM tblCountry
INNER JOIN tblContinent ON tblContinent.ContinentID = tblCountry.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
WHERE tblContinent.ContinentName in (SELECT  tblCountry.CountryName

FROM tblCountry
INNER JOIN tblContinent ON tblContinent.ContinentID = tblCountry.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
GROUP BY tblCountry.CountryName
ORDER BY COUNT(tblEvent.EventName))