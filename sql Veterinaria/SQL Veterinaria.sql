Create database Sistema_Veterinaria;

use Sistema_Veterinaria;

/* Registro de Datos de Animal*/ 
Create table Animal(
Linea_Registro int primary key,
IDAnimal varchar(45),
Tipo_Animal varchar(45),
Nombre_Animal varchar(45),
Edad_Animal int,
Nombre_Dueño varchar(45),
);
select*from Animal;

/* Registro de Diagnostico*/ 
Create table Diagnostico(
Linea_Registro int primary key,
Fecha date,
Descripcio varchar(45),
Receta varchar(45),
);
select*from Diagnostico;

/* Registro de Cita*/ 
Create table Cita(
Linea_Registro int primary key,
Hora int,
Fecha date,
Tipo_Animal varchar(45),
Raza_Animal varchar(45),
);
select*from Cita;

/* Registro Personal*/ 
Create table Personal(
Linea_Registro int primary key,
IDNombre_Usuario varchar(45),
Contraseña int,
Edad int,
Nombre_Completo varchar(45),
Fecha_Ingreso date,
Email varchar(45),
);
select*from Personal;

/*Registro  del Dueño del animal*/
Create table Dueño(
Linea_Registro int primary key,
Nombe_Dueño varchar(45),
Numero_Dui int,
Direccion varchar (45),
Edad int,
Email varchar(45),
Numero_Telefono int,
);
select*from Dueño;


