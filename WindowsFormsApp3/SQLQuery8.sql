select * from PERSONA p
join PERSONA_TITULO pp on p.ID = pp.ID_P
join TITULO t on pp.ID_T = t.ID