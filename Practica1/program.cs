
using Practica1;

// Crear un empleado
MiembroDeLaComunidad miembroDeLaComunidad = new MiembroDeLaComunidad("Elianny", "Maritnez", "E12345");
miembroDeLaComunidad.MostrarInformacion();

// Crear un empleado
Empleado empleado = new Empleado("Ana", "Mateo", "A12345", "Gerente");
empleado.MostrarInformacion();
empleado.MostrarCargo();

// Crear un estudiante
Estudiante estudiante = new Estudiante("Jesus", "Rodriguez", "J56789", "Ingeniería Civil", "2022-1123");
estudiante.MostrarInformacion();
estudiante.MostrarPrograma();

// Crear un ex alumno
ExAlumno exAlumno = new ExAlumno("Marta", "Figuereo", "M98765", new DateTime(2021, 3, 15));
exAlumno.MostrarInformacion();
exAlumno.MostrarFechaGraduacion();

// Crear un docente
Docente docente = new Docente("Elian", "Pérez", "G12345", "Profesor", "Matemáticas");
docente.MostrarInformacion();
docente.MostrarCargo();
docente.Enseñar();

// Crear un administrativo
Administrativo administrativo = new Administrativo("Sthepany", "Gónzalez", "S54339", "Asistente Administrativo", "Recursos Humanos");
administrativo.MostrarInformacion();
administrativo.MostrarCargo();
administrativo.RealizarTareasAdministrativas();

// Crear un administrador
Administrador administrador = new Administrador("Junior", "Valdez", "JV12345", "Administrador", "Contabilidad", "Finanzas");
administrador.MostrarInformacion();
administrador.MostrarCargo();
administrador.Enseñar();
administrador.GestionarRecursos();

// Crear un maestro
Maestro maestro = new Maestro("Juan", "Pérez", "M56789", "Maestro", "Matemáticas", "Noveno");
maestro.MostrarInformacion();
maestro.MostrarCargo();
maestro.Enseñar();
maestro.EvaluarEstudiantes();