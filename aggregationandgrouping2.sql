SELECT tblCategory.CategoryName,
COUNT(tblEvent.EventID) AS [Number of events]
FROM tblCategory
INNER JOIN tblEvent ON tblEvent.CategoryID = tblCategory.CategoryID
GROUP BY tblCategory.CategoryName
ORDER BY COUNT(tblEvent.EventID) DESC