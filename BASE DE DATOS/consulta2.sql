create database turismo;

use turismo;

create table if not exists servicioTipo (
	ID int not null auto_increment primary key,
	descripcion varchar (45) not null
	);

create table if not exists empresa (
	ID int not null auto_increment primary key,
	descripcion varchar (45) not null
	);

create table if not exists ciudad (
	ID int not null auto_increment primary key,
	nombre varchar (45) not null,
	codigoPostal int not null
	);

create table if not exists persona (
	ID int not null auto_increment primary key,
	nombre varchar (45) not null,
	apellido varchar (45) not null,
	dni int not null
	);

create table if not exists viaje (
	ID int not null auto_increment primary key,
	numero int not null,
	fechaHoraSalida datetime not null,
	fechaHoraLlegada datetime not null,
	numeroUnidad int not null,
	empresaID int not null,
	ciudadOrigenID int not null,
	ciudadDestinoID int not null,
	choferID int not null,
	index fk_viaje1 (empresaID asc),
	constraint fk_viaje1
		foreign key (empresaID)
		references turismo.empresa (ID)
		on delete no action
		on update no action,
	index fk_viaje2 (ciudadOrigenID asc),
	constraint fk_viaje2
		foreign key (ciudadOrigenID)
		references turismo.ciudad (ID)
		on delete no action
		on update no action,
	index fk_viaje3 (ciudadDestinoID asc),
	constraint fk_viaje3
		foreign key (ciudadDestinoID)
		references turismo.ciudad (ID)
		on delete no action
		on update no action,
	index fk_viaje4 (choferID asc),
	constraint fk_viaje4
		foreign key (choferID)
		references turismo.persona (ID)
		on delete no action
		on update no action
	);

create table if not exists pasaje (
	ID int not null auto_increment primary key,
	codigoBarras varchar (45) not null,
	asiento int not null unique,
	importe decimal (15.2) not null,
	servicioTipoID int not null,
	pasajeroID int not null,
	viajeID int not null,
	index fk_pasaje1 (servicioTipoID asc),
	constraint fk_pasaje1
		foreign key (servicioTipoID)
		references turismo.servicioTipo (ID)
		on delete no action
		on update no action,
	index fk_pasaje2 (pasajeroID asc),
	constraint fk_pasaje2
		foreign key (pasajeroID)
		references turismo.persona (ID)
		on delete no action
		on update no action,
	index fk_pasaje3 (viajeID asc),
	constraint fk_pasaje3
		foreign key (viajeID)
		references turismo.viaje (ID)
		on delete no action
		on update no action
	);








