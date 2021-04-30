select * from equipement where code=1
 drop table equipement
 drop table semble
 create table equipement(matircile varchar(40) primary key,nom varchar(40)  ,code int)
 create table semble(ref int primary key identity,id_artical int foreign key references Artical(ref),id_equipement int foreign key references equipement(ref) )
 create table logine(ref  int primary key identity,user_n varchar(40),passwrd varchar(40))
 alter table equipement
 add code int
 drop proc r_equipement
 --vvvvvvvvvv
 select * from Artical
 DROP TABLE Artical
create table Artical (ref int primary key identity ,Barcode varchar(40),bon_entrer int
,nom varchar(40),description_inter varchar(40),fourniseur varchar(40),descroption_fabrication varchar(40)
,code_fabrication varchar(40),prix float ,Quontitier int ,date_entre date,img image)


alter proc r_Article(@barcode varchar(40), @bon_entrer int,@nom varchar(40),@description_inter varchar(40),@fourniseur varchar(40),@descroption_fabrication varchar(40),@code_fabrication varchar(40),@prix float,@Quontitier int,@date_entre date,@img image) as
begin
insert into Artical 
values(@barcode,@bon_entrer,@nom,@description_inter,@fourniseur,@descroption_fabrication,@code_fabrication,@prix,@Quontitier,@date_entre,@img)
end
drop proc r_Article
  --remplisage de tb LOGIN
  create  proc r_logine(@user_nm varchar(40),@passwrd varchar(40))as
begin
insert into logine 
values(@user_nm,@passwrd) 
end
 
begin
exec  r_logine 'user','poswrod'
select * from  logine
INSERT INTO  logine values ('user','user','admin')
--affichage 

--affichage table login
drop function f_logine
--procedure pour login
create proc f_logine(@user_nm varchar(40),@passwrd varchar(40))
as
begin
   select * from logine where user_n=@user_nm and  passwrd=@passwrd
   end
 --remplisage de tb equipement
create  proc r_equipement(@nom varchar(40),@matircile varchar(40),@code int)as
begin
insert into equipement 
values(@nom,@matircile,@code) 
end
  drop proc Shearch_equipement(@code int)as
begin
select * from equipement where code=@code
end
exec  Shearch_equipement 12
SELECT * from Fourniseur
-------------------------------------
drop table Fourniseur
create table Fourniseur(ref int primary key identity,code int,nom varchar(40),phone int,adress varchar(40),Email varchar(40),fax varchar(40))
drop proc r_Fourniseur
create proc r_Fourniseur(@code int,@nom varchar(40),@phone int,@adress varchar(40),@Email varchar(40),@fax varchar(40)) as
begin
insert into Fourniseur
values(@code,@nom ,@phone,@adress,@Email ,@fax)
end-
select * from Fourniseur
------------------------------
create table Client(ref int primary key identity,code int,nom varchar(40),phone VARCHAR(40),adress varchar(40),Email varchar(40),fax  varchar(40))
create proc r_client(@code int,@nom varchar(40),@phone varchar(40),@adress varchar(40),@Email varchar(40),@fax varchar(40)) as
begin
insert into Client
values(@code,@nom ,@phone,@adress,@Email,@fax )
end

DROP TABLE Client
drop proc r_client
--table  artical sortie
select* from Artical
drop table Artical_Sortee
select * from Artical_Sortee INNER JOIN Artical on Artical.ref = Artical_Sortee.Id_Article


drop table Artical_Sortee
create table Artical_Sortee (ref int primary key identity , Id_Article int foreign key references  Artical(ref)
							,clientId int foreign key references Client(ref),date_sortie date
							,matricul varchar(40) foreign key references  equipement(matircile)
							,Quantity int)




drop proc r_Artical_Sortee
select * from Client
alter proc r_Artical_Sortee(@ArticleId int,@Quontitier int,@date_sortie date ,@matricul varchar(40),@ClientId int,@Quantity int) as
begin
insert into Artical_Sortee 
values(@ArticleId,@ClientId,@date_sortie,@matricul,@Quantity)
DECLARE @nitialQuantity int , @restQuantity int
select @nitialQuantity= Quontitier from Artical
set @restQuantity = @nitialQuantity - @Quontitier
update  Artical set Quontitier = @restQuantity
end

select * from Artical
----procedure donnner sortie par les mois
drop proc  m_r_Artical_Sortee

create proc m_r_Artical_Sortee(@date1 date ,@date2 date )as
begin 

select nom,Quontitier,prix,sum(prix) from Artical_Sortee where  
  year( date_sortie ) between year( @date1) AND year( @date2)
  and
 MONth( date_sortie ) between Month( @date1) AND MONTH( @date2)

 group by nom,Quontitier,prix
end

---procedure donne artical par le mois
create proc m_r_Artical_entre(@date1 date ,@date2 date )as
begin 
select nom,Quontitier,prix from Artical where
year( date_entre ) between year( @date1) AND year( @date2)
  and
 MONth( date_entre ) between Month( @date1) AND MONTH( @date2)

 group by nom,Quontitier,prix
end
