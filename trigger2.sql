create TRIGGER trigger_IslemKayit ON IslemUrun
AFTER INSERT
AS 
BEGIN

 select cast(Personel.PersonelID as nvarchar)+' Nolu Personel '+ Personel.PersonelAd+' '+PersonelSoyad+' taraf�ndan '+CAST(GETDATE() as nvarchar)+' tarihinde '+Cast(IslemUrun.GeneralID as nvarchar)+' ��lem Nolu '+IslemAd+' i�lemi ger�ekle�tirilmi�tir.' as Islem from IslemUrun inner join inserted as ins on IslemUrun.GeneralID = ins.GeneralID inner join Personel on Personel.PersonelID = IslemUrun.PersonelID inner join IslemTip on IslemTip.IslemID = IslemUrun.IslemID

 insert into [dbo].[Log] values((select cast(Personel.PersonelID as nvarchar)+' Nolu Personel '+ Personel.PersonelAd+' '+PersonelSoyad+' taraf�ndan '+CAST(GETDATE() as nvarchar)+' tarihinde '+Cast(IslemUrun.GeneralID as nvarchar)+' ��lem Nolu '+IslemAd+' i�lemi ger�ekle�tirilmi�tir.' as IslemLog from IslemUrun inner join inserted as ins on IslemUrun.GeneralID = ins.GeneralID inner join Personel on Personel.PersonelID = IslemUrun.PersonelID inner join IslemTip on IslemTip.IslemID = IslemUrun.IslemID))

END 


insert into IslemUrun values(1,'8699293012660',2,2,'NoneKimlik',10,GETDATE(),'-')