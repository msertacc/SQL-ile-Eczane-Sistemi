create view satis_View
as
select IslemUrun.UrunBarkod, IslemUrun.PersonelID as PersonelNo,Personel.PersonelAd+' '+Personel.PersonelSoyad as PersonelAdSoyad,sum(IslemUrun.UrunAdet) as SatilanMiktar,count(1) as SatisIslemSayi from IslemUrun  
inner join Urun on IslemUrun.UrunBarkod = Urun.UrunBarkod
inner join Personel on IslemUrun.PersonelID = Personel.PersonelID where IslemID = 1
group by IslemUrun.UrunBarkod, IslemUrun.PersonelID,Personel.PersonelAd, Personel.PersonelSoyad 
