SELECT tblContinent.ContinentName AS ContinentName,
tblCountry.CountryName AS CountryName,
tblEvent.EventDate AS EventDate,
tblEvent.EventName AS EventName
FROM tblCountry
INNER JOIN tblContinent ON tblContinent.ContinentID = tblCountry.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
WHERE tblCountry.CountryName = 'Russia' OR tblContinent.ContinentName = 'Antarctic'