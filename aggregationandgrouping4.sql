SELECT tblContinent.ContinentName,
tblCountry.CountryName,
COUNT(tblEvent.EventID) AS [Number of events]
FROM tblCountry
INNER JOIN tblContinent ON tblContinent.ContinentID = tblCountry.ContinentID
INNER JOIN tblEvent ON tblEvent.CountryID = tblCountry.CountryID
WHERE NOT tblContinent.ContinentName = 'Europe' 

GROUP BY tblContinent.ContinentName,tblCountry.CountryName
HAVING  COUNT(tblEvent.EventID) >5