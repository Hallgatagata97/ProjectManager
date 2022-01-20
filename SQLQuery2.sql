select 
--count(1) as mennyiseg 
*
FROM [dbo].[projektek] WHERE hatarido < CURRENT_TIMESTAMP AND projektek.statusz = 'Új' AND projektek.statusz = 'Folyamat'