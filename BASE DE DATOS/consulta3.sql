insert into ciudad (nombre, codigoPostal)                     
values ('quilmes', '190');

insert into ciudad (nombre, codigoPostal)                     
values ('san isidro', '1400');

insert into ciudad (nombre, codigoPostal)                     
values ('florencio varela', '1200');



insert into empresa (descripcion)                     
values ('pepito');

insert into empresa (descripcion)                     
values ('sultanito');

insert into empresa (descripcion)                     
values ('fulanito');


insert into servicioTipo (descripcion)                     
values ('cama');

insert into servicioTipo (descripcion)                     
values ('semi');

insert into servicioTipo (descripcion)                     
values ('vip');



insert into persona (nombre, apellido, dni)                     
values ('mauro', 'cardoso', 31282983);

insert into persona (nombre, apellido, dni)                     
values ('fernando', 'cardoso', 31282983);

insert into persona (nombre, apellido, dni)                     
values ('vanina', 'gomez', 31282983);

insert into persona (nombre, apellido, dni)                     
values ('yamila', 'francia', 31282983);


insert into viaje (numero, fechaHoraSalida, fechaHoraLlegada, numeroUnidad, empresaID, ciudadOrigenID, ciudadDestinoID, choferID)
values (25, '2021-01-29', '2021-02-15', 10, 1, 1, 2, 1);

insert into viaje (numero, fechaHoraSalida, fechaHoraLlegada, numeroUnidad, empresaID, ciudadOrigenID, ciudadDestinoID, choferID)
values (25, '2021-03-29', '2021-04-29', 15, 2, 2, 3, 2);

insert into viaje (numero, fechaHoraSalida, fechaHoraLlegada, numeroUnidad, empresaID, ciudadOrigenID, ciudadDestinoID, choferID)
values (25, '2020-05-29', '2021-05-29', 20, 1, 3, 1, 1);

insert into viaje (numero, fechaHoraSalida, fechaHoraLlegada, numeroUnidad, empresaID, ciudadOrigenID, ciudadDestinoID, choferID)
values (25, '2020-06-29', '2020-07-29', 25, 2, 1, 3, 2);


insert into pasaje (codigoBarras, asiento, importe, servicioTipoID, pasajeroID, viajeID)
values ('2d5ff', 1, 100, 1, 2, 1);

insert into pasaje (codigoBarras, asiento, importe, servicioTipoID, pasajeroID, viajeID)
values ('2d5f', 2, 150, 1, 1, 1);

insert into pasaje (codigoBarras, asiento, importe, servicioTipoID, pasajeroID, viajeID)
values ('2d5fff', 3, 200, 2, 3, 2);

insert into pasaje (codigoBarras, asiento, importe, servicioTipoID, pasajeroID, viajeID)
values ('2d5dff', 4, 250, 3, 2, 3);



select *
from pasaje