select 
Continentid, continentName, Summary, 
ISNULL(Summary,'No Summary') as 'Using IsNull',
Coalesce(Summary,'No Summary') as 'Using COALESCE',
case 
when summary is null then 'No Summary'
else summary
end
as 'Using Case'
from tblContinent