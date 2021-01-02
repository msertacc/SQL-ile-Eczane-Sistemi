create procedure stok_Procedure(
@sBarkod nvarchar(50),
@sAdet int
)
as 

begin 

update Stok set Stok.UrunAdet = @sAdet, Stok.SonGuncelTarih = GETDATE() where Stok.UrunBarkod = @sBarkod 

end 

exec stok_Procedure
@sBarkod = '8699809018042',
@sAdet = 1000
