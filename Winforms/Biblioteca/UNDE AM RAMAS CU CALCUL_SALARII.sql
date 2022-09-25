ALTER PROC [dbo].[calculSalarii]
@id_salarizare int
 as
 DECLARE @sal_baza decimal(10,2),
 @val_spor decimal(8,2),
 @val_retinere decimal(10,2),
 @zile_luna decimal(2),
 @zile_lucrate decimal(2),
 @salbrut decimal(10,2),
 @procent_impozit decimal(2),
 @procent_pensie decimal(2),
 @procent_sanatate decimal(2)
 /*set @id_salarizare=13*/

 select @procent_impozit=procent 
	from nomretineri
	where id = 7
 select @procent_pensie=procent 
	from nomretineri
	where id = 8
	 select @procent_sanatate=procent 
	from nomretineri
	where id = 9

 select @sal_baza=s.SALBAZA ,
 @zile_luna = p.ZL_IN_LUNA, @zile_lucrate=p.ZEF_LUCRATE
 from salarizare s, PONTAJ p
 where s.id = @id_salarizare and p.ID_SALARIZARE=s.id

 select @val_retinere = sum(vr.VALOARE_CALCULATA) from VALRETINERI vr
 where vr.ID_SALARIZARE = @id_salarizare

 select @val_spor= sum(vs.VALOARE_CALCULATA) from VALSPORURI vs 
 where vs.ID_SALARIZARE = @id_salarizare

 set @val_spor = isnull(@val_spor,0)
 set @val_retinere = isnull(@val_retinere,0)
 set @salbrut = isnull(@sal_baza+@val_spor,@sal_baza)

update salarizare 
 set salbrut= @salbrut,
restcard= @salbrut
where id=@id_salarizare

 

 update valretineri
	set VALOARE_CALCULATA= @salbrut * @procent_pensie/100
	where ID_RETINERI=8

update valretineri
	set VALOARE_CALCULATA= @salbrut * @procent_sanatate/100
	where ID_RETINERI=9

update SALARIZARE 
set VENITNET = SALBRUT - sum(VALOARE_CALCULATA) from valretineri 
where ID_RETINERI in (8,9) and ID_SALARIZARE = @id_salarizare


update valretineri
	set VALOARE_CALCULATA= [VENITNET ]* @procent_impozit/100 FROM salarizare s
	where ID_RETINERI =7 and ID_SALARIZARE = @id_salarizare and s.id= @id_salarizare


update salarizare
set salariunet = venitnet - valoare_calculata - @val_retinere,
from salarizare s, valretineri v
where ID_RETINERI =7 and ID_SALARIZARE = @id_salarizare and s.id= @id_salarizare

update salarizare
set restcard = salariunet
/*
DELETE FROM VALRETINERI WHERE ID_SALARIZARE = @id_salarizare
DELETE FROM VALSPORURI WHERE ID_SALARIZARE = @id_salarizare

*/