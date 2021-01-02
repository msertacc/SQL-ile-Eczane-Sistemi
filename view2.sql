use EczaneSistemi

create view islem_View 
as

select IslemTip.IslemAd, Personel.PersonelAd, Urun.UrunAd, Urun.UrunFiyat,+' '+Personel.PersonelSoyad as PersonelAdSoyad, OdemeTip.OdemeTipiAd, Musteri.MusteriAd+' '+Musteri.MusteriSoyad as MusteriAdSoyad, IslemUrun.UrunAdet, IslemUrun.IslemTarih, IslemUrun.Aciklama from IslemUrun 
inner join Urun on IslemUrun.UrunBarkod = Urun.UrunBarkod 
inner join Musteri on IslemUrun.MusteriKimlik = Musteri.MusteriKimlik 
inner join IslemTip on IslemUrun.IslemID = IslemTip.IslemID 
inner join Personel on IslemUrun.PersonelID = Personel.PersonelID 
inner join OdemeTip on IslemUrun.OdemeTipiID = OdemeTip.OdemeTipiID