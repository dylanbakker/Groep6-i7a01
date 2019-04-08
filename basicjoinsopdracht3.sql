SELECT
Doctor.DoctorName,
Episode.Title
FROM tblDoctor AS Doctor
INNER join tblEpisode AS Episode
ON Doctor.DoctorId = Episode.DoctorId
WHERE YEAR(Episode.EpisodeDate)= '2010'
