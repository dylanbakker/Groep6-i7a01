select e.EnemyName,EpisodeNumber,AuthorName
from dbo.tblEpisodeEnemy as epe
inner join tblEnemy as e
on epe.EnemyId= e.EnemyId
inner join tblEpisode as e1
on epe.EpisodeId = e1.EpisodeId
inner join tblAuthor as a
on e1.AuthorId= a.AuthorId
where EnemyName like '%Daleks%'