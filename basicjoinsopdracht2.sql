
SELECT cy.CountryName AS Country,
ev.EventName AS [What happened],
ev.EventDate AS [When happened]
FROM
tblCountry AS cy
INNER JOIN tblEvent AS ev
ON cy.CountryID = ev.CountryID
ORDER BY
[When happened]
