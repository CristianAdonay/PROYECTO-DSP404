Create database Veterinaria_Sistema;

use Veterinaria_Sistema;

/*El registro para los Datos del Animal*/
Create table ANIMAL(
Registro_Veterinario int primary key,
IdAnimal varchar(45),
Tipo_Animal varchar(45),
Nombre_Animal varchar(45),
Raza_Animal varchar(45),
Edad_Animal int,
Nombre_Dueño varchar(45),
);
select*from ANIMAL;

/*EL registro para los Diagnosticos*/
Create table Diagnostico(
Registro_Veterinario int primary key,
Fecha datetime,
Descripcion varchar(45),
Receta varchar(45),
);
select*from Diagnostico;

/*EL registro para el Auxiliar*/
Create table Auxiliar(
Registro_Veterinario int primary key,
IdAuxiliar Varchar(45),
Registro varchar(45),
Cita varchar(45),
Dueño varchar(45),
Animal varchar(45),
);
select*from Auxiliar;

/*El registro para la cita */
Create table Cita(
Registro_Veterinario int primary key,
IdCita varchar(45),
Hora datetime,
Fecha datetime,
Tipo_Animal varchar(45),
Nombre_Animal varchar(45),
Raza_Animal varchar(45),
);
select*from Cita;

/*El registro del Dueño del Animal*/
Create table Dueño(
Registro_Veterinario int primary key,
IdDueño varchar(45),
Nombre_Dueño varchar(45),
Numero_Dui int,
Direccion varchar(45),
Edad int,
Email varchar(45),
Numero_Telefono int,
);
select*from Dueño;

/*El registro para saber si entrara como veterinario o Auxiliar al menu*/
Create table Personal(
Registro_Veterinario int primary key,
IdPersonal int,
Indentificacion int,
Veterinario varchar(35), /*Debera poner su nombre el veterianario para acceder*/
Auxiliar varchar(35),    /*Debera poner su numbre el Auxiliar para acceder*/
);
select*from Personal;

/* El registro personal  para informacion personal de Usuario*/
Create table Registro_Personal(
Registro_Veterinario int primary key,
IdPersona int,                           /*para saber la persona que ingresa*/
personal varchar(35),                  
Nombre_Usuario varchar(45),
Contraseña int,
Edad int,
Nombre_Completo varchar(45),
Fecha_Ingreso datetime,
Email varchar(45),
);
select*from Registro_Personal;
