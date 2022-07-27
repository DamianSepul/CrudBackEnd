Para poder correr el back-end, debe tener instalada las dependencias con Nuget():

EntityFramework
EntityFramework SQL SERVER
EntityFramework Core Tools
OJO. Para poder realizar la conexión la base de datos de manera local (SQL Server) se debe editar la cadena de conección la cual se encuentra en appsettings.json Cambie el apartado que dice "DefaultConnection", poner en Server el nombre de su server de SQL Server (Es que viene arriba al iniciar el SQL Server)

Ahora para poder hacer la migración y crear la base de datos de manera dinamica, se debe ir en el menu de arriba a Herramientas -> Administrador de paquetes NuGet -> Consola de Paquetes. Aqui se abrira una pequeña consola, poner los siguientes comandos:

Add-Migration FirstMigration
Update-database
Si todos sale bien deberia haber creado la base de datos de manera correcta.
