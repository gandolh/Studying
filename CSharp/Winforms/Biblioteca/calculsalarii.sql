ALTER PROC [dbo].[calculSalarii]
@id_salarizare int
 as
 DECLARE @sal_baza decimal(10,2),
 @val_spor decimal(8,2),
 @val_retinere decimal(10,2),
 @zile_luna decimal(2),
 @zile_lucrate decimal(2),
 @salbrut decimal(10,2),
 @venitNet decimal(10,2)
 /*set @id_salarizare=13*/

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

set @venitNet= @salbrut - isnull(round(@salbrut* n.procent/100,0),0)
update VALRETINERI 
set VALOARE_CALCULATA = isnull(round(@venitNet* n.procent/100,0),0)
from NOMRETINERI n
where n.COD_RETINERE='Impozit'
update VALRETINERI 
set VALOARE_CALCULATA = isnull(round(@salbrut* n.procent/100,0),0)
from NOMRETINERI n
where n.COD_RETINERE='Sanatate'
update VALRETINERI 
set VALOARE_CALCULATA = isnull(round(@salbrut* n.procent/100,0),0)
from NOMRETINERI n
where n.COD_RETINERE='Pensie'
/*
DELETE FROM VALRETINERI WHERE ID_SALARIZARE = @id_salarizare
DELETE FROM VALSPORURI WHERE ID_SALARIZARE = @id_salarizare

*/