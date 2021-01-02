create trigger trig_StokEksiArti on IslemUrun
for insert as
begin

declare @urunBarkod nvarchar(50)
declare @satilanAdet int
declare @islemID tinyint

select  @urunBarkod = UrunBarkod, @satilanAdet = UrunAdet , @islemID = IslemID from inserted 

update Stok SET UrunAdet= UrunAdet - @satilanAdet where UrunBarkod = @urunBarkod and @islemID = 1 and UrunAdet - @satilanAdet>0
update Stok SET UrunAdet= UrunAdet + @satilanAdet where UrunBarkod = @urunBarkod and @islemID = 2 or @islemID=3

end

insert into IslemUrun values ('1','8699809018082','1','1','NoneKimlik',110,2020-12-12,NULL)