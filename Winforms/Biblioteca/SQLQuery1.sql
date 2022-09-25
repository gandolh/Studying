ALTER PROC [dbo].[InitLuna]
@Luna decimal(2,0),
@Anul decimal(4,0)
as
DECLARE @id_pensie bigint,
@id_impozit bigint,
@id_sanatate bigint
INSERT INTO SALARIZARE
(
    [ID_ANGAJAT], 
    [FUNCTIA], 
    [LOCMUNCA],   
    [SALBAZA],    
    [SALEFECTIV],  
    [SALBRUT],    
    [VENITNET],   
    [SALARIUNET],
    [RESTPLATA], 
    [RESTCARD],  
    [LUNA],    
    [ANUL]
)
SELECT id,Functia,locMunca,0,0,0,0,0,0,0,@Luna,@Anul FROM ANGAJATI a
where a.id not in (select id_angajat from salarizare 
where luna = @Luna and anul = @Anul)

insert into pontaj (ID_SALARIZARE, ZL_IN_LUNA,ZEF_LUCRATE )
select id,[dbo].ZileLucratoareInLuna (@Anul, @Luna),
[dbo].ZileLucratoareInLuna (@Anul, @Luna) from salarizare
where id not in (select id from PONTAJ) and luna=@Luna and anul=@Anul

select @id_impozit= id from NOMRETINERI where COD_RETINERE='Impozit'
select @id_pensie = id from NOMRETINERI where COD_RETINERE='Pensie'
select @id_sanatate = id from NOMRETINERI where COD_RETINERE='Sanatate'


insert into VALRETINERI ( ID_SALARIZARE,ID_RETINERI)
select s.id, @id_impozit from SALARIZARE s where s.LUNA = @luna and s.anul =@anul
and id not in 
(select id_salarizare from VALRETINERI where ID_RETINERI=@id_impozit)
insert into VALRETINERI (  ID_SALARIZARE,ID_RETINERI)
select s.id, @id_pensie from SALARIZARE s where s.LUNA = @luna and s.anul =@anul
and id not in 
(select id_salarizare from VALRETINERI where ID_RETINERI=@id_pensie)
insert into VALRETINERI (  ID_SALARIZARE,ID_RETINERI)
select s.id, @id_sanatate from SALARIZARE s where s.LUNA = @luna and s.anul =@anul
and id not in 
(select id_salarizare from VALRETINERI where ID_RETINERI=@id_sanatate)


--select * from VALRETINERI