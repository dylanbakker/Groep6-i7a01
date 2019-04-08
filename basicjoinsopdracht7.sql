SELECT 
    tblAuthor.AuthorName,
    tblEpisode.Title,
    tblDoctor.DoctorName,
    tblEnemy.EnemyName,

    LEN(CONCAT(
    tblAuthor.AuthorName,
    tblEpisode.Title,
    tblDoctor.DoctorName,
    tblEnemy.EnemyName))  AS Totallength

FROM tblEpisodeEnemy

    inner join tblEnemy
    on tblEpisodeEnemy.EnemyId = tblEnemy.EnemyId

    inner join tblEpisode
    on tblEpisodeEnemy.EpisodeId = tblEpisode.EpisodeId

    inner join tblAuthor
    on tblEpisode.AuthorId = tblAuthor.AuthorId

    inner join tblDoctor
    on tblEpisode.DoctorId = tblDoctor.DoctorId

	where LEN(CONCAT(
    tblAuthor.AuthorName,
    tblEpisode.Title,
    tblDoctor.DoctorName,
    tblEnemy.EnemyName)) <40