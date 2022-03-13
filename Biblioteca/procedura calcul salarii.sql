ALTER PROC [dbo].[calculSalarii]
@id_salarizare int
 as
 DECLARE @sal_baza decimal(10,2),
 @val_spor decimal(8,2),
 @val_retinere decimal(10,2),
 @zile_luna decimal(2),
 @zile_lucrate decimal(2),
 @salbrut decimal(10,2)
 /*set @id_salarizare=13*/

 select @sal_baza=s.SALBAZA,@val_retinere = vr.VALOARE_CALCULATA ,
 @val_spor= vs.VALOARE_CALCULATA, @zile_luna = p.ZL_IN_LUNA, @zile_lucrate=p.ZEF_LUCRATE
 from salarizare s,VALSPORURI vs,VALRETINERI vr, PONTAJ p
 where s.id = @id_salarizare and vs.ID_SALARIZARE=s.id and vr.ID_SALARIZARE = s.id
 and p.ID_SALARIZARE=s.id

 set @salbrut =@sal_baza+@val_spor-@val_retinere
 update salarizare 
 set salbrut= @salbrut,
restcard= @salbrut
where id=@id_salarizare