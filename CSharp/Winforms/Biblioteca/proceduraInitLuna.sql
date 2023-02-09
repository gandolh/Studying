alter PROC [dbo].[InitLuna]
@Luna decimal(2,0),
@Anul decimal(4,0)
with encryption as
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
SELECT id,Functia,locMunca,0,0,0,0,0,0,0,@Luna,@Anul FROM ANGAJATI