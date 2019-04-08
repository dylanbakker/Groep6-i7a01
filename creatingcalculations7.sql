SELECT * FROM (
SELECT EventName
        , CASE
            WHEN LOWER(LEFT(EventName,1)) IN ('a','e','i','o','u') AND LOWER(RIGHT(EventName,1)) IN ('a','e','i','o','u')
                THEN 'Begins and ends with vowle'
            WHEN LOWER(LEFT(EventName,1)) = LOWER(RIGHT(EventName,1))
                THEN 'Same letter'
          END AS Verdict
FROM tblEvent ) AS T
WHERE Verdict IS NOT NULL