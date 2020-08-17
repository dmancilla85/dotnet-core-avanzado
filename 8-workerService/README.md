# Pasos para registrar un servicio de Windows

* Ejecutar Powershell como administrador.
* Ir a C:\WINDOWS\system32
* .\sc.exe create ServicioCurso binPath=C:\Proyectos\dot-net\core-avanzado\workerService\service\WorkerService.exe

Al ejecutar se puede comprobar que el registro fue correcto, y se puede observar en el administrador de Servicios.