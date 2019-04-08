SELECT tblAuthor.AuthorName,

COUNT(tblEpisode.EpisodeId) AS Episodes
FROM tblAuthor
INNER JOIN tblEpisode ON tblEpisode.AuthorId = tblAuthor.AuthorId
GROUP BY tblAuthor.AuthorName
ORDER BY COUNT(tblEpisode.EpisodeId) DESC