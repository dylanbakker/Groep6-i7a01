SELECT
tblEvent.EventName + ' (category '+CAST(tblCategory.CategoryID as varchar(20))+')' AS 'Event (cacategory)',
tblEvent.EventDate

FROM
tblEvent

inner join tblCategory
on tblCategory.CategoryID = tblEvent.CategoryID

inner join tblCountry
on tblCountry.CountryID = tblEvent.CountryID

WHERE tblCountry.CountryID = 1;