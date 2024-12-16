# TecnicasProgramacionIIIQ
Proyecto 1
Equipo:
Fabiola María Castro Mora y Akane Santamaría Allen

Profesor: 
Luis Felipe Mora Umaña

Sistema de Gestión de Gimnasio
Este proyecto es una plataforma de gestión de gimnasio diseñada para facilitar la administración de usuarios, membresías, clases, reservas, inventario, facturación y generación de reportes. El sistema está estructurado en Epics, Features y Product Backlog Items (PBIs), y proporciona una interfaz intuitiva para clientes, entrenadores y personal administrativo.


Estructura del Proyecto
El proyecto está dividido en varias funcionalidades clave (Epics), cada una con sus respectivas características (Features) y tareas. A continuación se detalla la estructura general del proyecto:

Epics y Features
Epic 1: Gestión de Usuarios

Feature 1.1: Gestión de Clientes y Entrenadores
Permite la creación y gestión de usuarios con roles específicos de cliente y entrenador.
Los entrenadores gestionan horarios y especialidades, mientras que los clientes pueden ver y reservar clases.
Epic 2: Gestión de Membresías

Feature 2.1: Notificaciones de Vencimiento de Membresía
Envía alertas a los clientes cuando su membresía está por expirar.
Epic 3: Gestión de Clases y Reservas

Feature 3.1: Creación y Gestión de Clases
Los entrenadores pueden crear y gestionar clases, incluyendo detalles como horarios, descripciones y niveles de dificultad.
Feature 3.2: Sistema de Reservas
Los clientes pueden reservar clases disponibles a través de un calendario interactivo.
Epic 4: Gestión de Inventario

Feature 4.1: Control de Equipamiento
Gestiona el inventario de equipos disponibles para clases y entrenadores.
Feature 4.2: Seguimiento de Uso de Equipamiento
Registra y realiza un seguimiento del uso de equipamiento durante las clases.
Epic 5: Reportes

Feature 5.1: Generación de Reportes de Clases y Membresías
Permite generar reportes sobre las clases y el estado de las membresías activas.
Epic 6: Facturación

Feature 6.1: Gestión de Facturas
Gestiona la generación automática de facturas mensuales para clientes, almacenándolas y permitiendo su consulta.

°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°

Cómo Usar
1-Registro de Usuarios  

Los administradores pueden crear y gestionar los perfiles de los entrenadores y clientes. Los entrenadores pueden configurar sus horarios y especializaciones, mientras que los clientes pueden visualizar y reservar clases. 

 

2-Gestión de Membresías 

El sistema requiere los datos de almacenamiento necesarios que el usuario debe llenar para crear la membresia. 

A excepcion que falta la parte lógica para almacenar datos y enviar notificaciones a los entrenadores. 

 

3-Gestión de Clases y Reservas  

Los entrenadores y clientes pueden crear nuevas clases, asignando detalles como horarios y niveles de dificultad. Los clientes pueden visualizar un calendario de clases y reservar espacios en las que estén interesados. 

 

4-Gestión de Inventario  

El sistema permite agregar, editar y eliminar equipos de gimnasio. Además, registra el uso de equipamiento en cada clase para mantener un control de los recursos. 

 

5-Generación de Reportes  

Los entrenadores pueden generar reportes detallados sobre las clases, inventario, la asistencia y el crecimiento de las membresías. 

 

6-Facturación   

Los usuarios pueden consultar sus facturas en cualquier momento. 

6-Facturación
El sistema genera facturas automáticamente cada mes para cada cliente, basadas en sus membresías activas.
Los usuarios pueden consultar sus facturas en cualquier momento.

________________________________________________________________________________________________________________________________________


Sistema de Gestión para Gimnasio - Proyecto V2

Equipo:
Fabiola María Castro Mora y Akane Santamaría Allen

Profesor: 
Luis Felipe Mora Umaña


Introducción
Este proyecto corresponde a la segunda iteración del Sistema de Gestión para Gimnasios, desarrollado como parte del curso de Técnicas de Programación en el III cuatrimestre de 2024. Su propósito es optimizar la gestión de gimnasios mediante el uso de tecnologías modernas y prácticas avanzadas de desarrollo.

Las mejoras incluyen la implementación de una base de datos relacional, una nueva interfaz web escalable, generación de reportes, y funcionalidades administrativas que fortalecen la infraestructura y experiencia de usuario.

Funcionalidad del Programa
El sistema de gestión para gimnasios incluye las siguientes características principales:

Gestión de Usuarios: Permite la creación y administración de clientes y entrenadores con sus respectivos horarios y datos relevantes.

Gestión de Membresías: Maneja las membresías de los clientes, notificando vencimientos de manera automatizada.

Reservas de Clases: Los clientes pueden reservar clases como Zumba, CardioDance o sesiones funcionales, gestionadas por entrenadores en tiempo real.

Inventario de Maquinaria: Registra y supervisa el estado del equipamiento del gimnasio, notificando al administrador sobre mantenimiento o reemplazos necesarios.

Generación de Reportes: Proporciona informes sobre métricas clave como membresías activas, asistencia a clases y estado financiero del gimnasio.

Facturación: Genera y almacena facturas automáticamente según las membresías activas, con capacidad de consulta por cliente, fecha o ID.

Tecnologías Utilizadas
Frontend: Interfaz creada con Blazor para garantizar una experiencia web moderna y escalable.
Backend: Lógica desarrollada en C# bajo el patrón MVC para modularidad y mantenimiento.
Base de Datos: SQL Server para almacenamiento eficiente y consultas avanzadas.
Pruebas: Implementación de pruebas unitarias con cobertura de al menos el 60% en los módulos clave.

Decisiones de Diseño
Migración de WinForms a Blazor para aprovechar una arquitectura web más moderna.
Implementación de SQL Server como base de datos para escalar y gestionar grandes volúmenes de datos.
Uso del patrón Modelo-Vista-Controlador (MVC) para separar la lógica de negocio y la interfaz gráfica.

Conclusión
Este proyecto tiene como objetivo proporcionar una herramienta robusta para la gestión integral de gimnasios, respondiendo a las necesidades actuales de escalabilidad, usabilidad y eficiencia. La implementación de las mejoras propuestas asegura un rendimiento óptimo y una experiencia de usuario superior.
