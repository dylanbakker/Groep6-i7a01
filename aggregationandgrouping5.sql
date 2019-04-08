SELECT tblAuthor.AuthorName,
tblDoctor.DoctorName,
COUNT(tblEpisode.EpisodeId) AS Episodes
FROM tblDoctor
INNER JOIN tblEpisode ON tblEpisode.DoctorId = tblDoctor.DoctorId
INNER JOIN tblAuthor ON tblAuthor.AuthorId = tblEpisode.AuthorId
GROUP BY tblAuthor.AuthorName,tblDoctor.DoctorName
HAVING COUNT (tblEpisode.EpisodeId) >5

