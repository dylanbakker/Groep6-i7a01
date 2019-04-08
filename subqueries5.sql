SELECT EventName,EventDetails
FROM tblCountry
INNER JOIN tblEvent
ON tblCountry.CountryID=tblEvent.CountryID
INNER JOIN tblCategory
ON tblCategory.CategoryID=tblEvent.CategoryID
WHERE tblCountry.CountryID  NOT IN       
(SELECT TOP 30 tblCountry.CountryID
FROM tblCountry
ORDER BY CountryName DESC)
AND
tblCategory.CategoryID NOT IN
(SELECT TOP 15 tblCategory.CategoryID
FROM tblCategory
ORDER BY tblCategory.CategoryName DESC)
ORDER BY EventName DESC