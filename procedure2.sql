create procedure islem_Procedure
(
@mKimlik nvarchar(11),
@mAd nvarchar(30),
@mSoyad nvarchar(30),
@mTelefon nvarchar(15),
@mAdres nvarchar(50),
@mCinsiyet bit
)

as
begin

insert into Musteri values(@mKimlik,@mAd,@mSoyad,@mTelefon,@mAdres,@mCinsiyet)

end

exec islem_Procedure
@mAd = 'Avni',
@mSoyad = 'Kocaçýnar',
@mKimlik = '15874694212',
@mAdres = 'Istanbul',
@mCinsiyet = true,
@mTelefon = '05341544545'