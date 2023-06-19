create table Providers
(
	Id int not null primary key,
	Name varchar(50) not null,
	Phone varchar(13) not null
)

create table Products
(
	Id int not null primary key,
	Name varchar(max) not null,
	Quantity int not null,
	CostPrice money not null,
	DeliveryDate date not null,
	ProviderId int not null,

	foreign key (ProviderId) references Providers (Id) 
)

create table ProductsPictures
(
	Id int not null primary key,
	Picture varbinary(max) not null,
	ProductId int not null,

	foreign key (ProductId) references Products (Id)
)