# EducacionIt-C#-introduction

## Educacion IT - Introduccion a C#

Este proyecto es parte del trabajo integrador propuesto por Educación IT para demostrar y aplicar los conocimientos adquiridos en el curso de introducción a C#. El objetivo principal es desarrollar un sistema de inscripciones para una institución educativa, utilizando una aplicación de consola que permite a los alumnos ingresar sus datos, confirmar su corrección y elegir cursos.

## Elementos aplicados en etapas previas del proyecto

### 1.- Solicitud de Datos del Alumno:

* Nombre
* Apellido
* Edad
* Correo electrónico

### 2.- Validación de Datos:

* Verificación de la corrección de los datos ingresados por el usuario.

### 3.- Selección de Cursos:

* Se presenta al alumno una lista de cursos disponibles para elegir.
* Utilización de un bucle do-while para permitir al usuario seleccionar múltiples cursos.
* Verificación de la entrada del usuario para seleccionar cursos válidos.
* Almacenamiento de los cursos seleccionados en una lista.

### 4.- Presentación de Datos:

* Despliegue de los datos del alumno (nombre, apellido, correo electrónico).
* Despliegue de los cursos seleccionados por el alumno.

### Cambios Implementados en esta versión:

* Se modificaron los nombres de las propiedades de la clase `Student` a `FirstName`, `LastName`, `Age` y `Email`.
* Se agregaron métodos `Get` y `Set` para acceder y modificar los datos del estudiante de manera controlada.
* Se encapsuló la lógica para la solicitud y presentación de datos del estudiante dentro de métodos privados `SetStudentData` y `ShowStudentData`.
* Se actualizó el método `SignUpToCourse` para manejar excepciones de formato al ingresar el número del curso.
* Se añadió el método `ShowCourses` para mostrar los detalles de los cursos en los que el estudiante está inscrito.
----------------------------------------------------------------------------------------------------------------------------------------------------------

## Educacion IT - Introduction to C#

This project is part of the integrative work proposed by Educación IT to demonstrate and apply the knowledge gained in the Introduction to C# course. The main objective is to develop an enrollment system for an educational institution using a console application that allows students to enter their information, confirm its correctness, and choose courses.

## Elements applied in previous stages of the project

### 1.- Student Data Request:

* Name
* Last Name
* Age
* Email

### 2.- Data Validation:

* Verification of the correctness of the data entered by the user.

### 3.- Course Selection:

* A list of available courses is presented to the student for selection.
* Use of a do-while loop to allow the user to select multiple courses.
* Verification of user input to select valid courses.
* Storage of selected courses in a list.

### 4.- Data Presentation:

* Display of student data (name, last name, email).
* Display of courses selected by the student.

### Changes Implemented on this version:


- Property names of the `Student` class were changed to `FirstName`, `LastName`, `Age`, and `Email`.
- `Get` and `Set` methods were added to access and modify student data in a controlled manner.
- Logic for student data request and presentation was encapsulated within private methods `SetStudentData` and `ShowStudentData`.
- The `SignUpToCourse` method was updated to handle format exceptions when entering the course number.
- The `ShowCourses` method was added to display details of the courses the student is enrolled in.
