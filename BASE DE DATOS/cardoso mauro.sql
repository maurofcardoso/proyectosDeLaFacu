select e.descripcion as nombreEmpresa, v.numero as numeroViaje, v.fechaHoraSalida as fechaSalida, v.numeroUnidad as unidad
from viaje v inner join empresa e on v.empresaID=e.ID
where year(v.fechaHoraSalida)=2020 and
		month(v.fechaHoraSalida)=01 and
   	 e.descripcion='talp' and
   	 time(v.fechaHoraSalida) Between '00.00.00' and '12.00.00'


select e.descripcion as nombreEmpresa, v.numero as numeroViaje, v.fechaHoraSalida as fechaSalida, count(p.ID) as cantidadPasajeros
from viaje v inner join empresa e on v.empresaID=e.ID
				 inner join pasaje p on v.ID=p.viajeID
where year(v.fechaHoraSalida)=2020 and
		month(v.fechaHoraSalida)=01 and
   	 e.descripcion='talp'
group by v.ID
order by v.numero desc


select em.descripcion as nombreEmpresa, v.numero as numeroViaje, v.fechaHoraSalida as fechaSalida, concat(per.nombre, per.apellido) as chofer
from viaje v inner join ciudad co on v.ciudadOrigenID=co.ID
				 inner join ciudad cd on v.ciudadDestinoID=cd.ID
				 inner join empresa em on v.empresaID=em.ID
				 inner join persona per on v.choferID=per.ID
where co.nombre='la plata' and
		cd.nombre='quilmes'


select concat(per.nombre, per.apellido) as pasajero, count(per.ID) as cantidad
from viaje v inner join pasaje p on v.ID=p.viajeID
				  inner join persona per on p.pasajeroID=per.ID
where year(v.fechaHoraSalida)=2020
group by per.ID


select concat(per.nombre, per.apellido) as pasajero, year(v.fechaHoraSalida) as año, count(per.ID) as cantidad
from viaje v inner join pasaje p on v.ID=p.viajeID
				  inner join persona per on p.pasajeroID=per.ID
group by per.ID, year(v.fechaHoraSalida)

