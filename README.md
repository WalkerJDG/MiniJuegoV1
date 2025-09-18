Programa de Bienvenida en C#

Este es un sencillo programa en C# que solicita al usuario su nombre y edad, y luego muestra un mensaje personalizado de bienvenida.

📋 Descripción

El programa realiza lo siguiente:

Muestra un mensaje de inicio en consola.

Solicita al usuario su nombre.

Solicita al usuario su edad.

Genera un mensaje de bienvenida personalizado utilizando la información proporcionada.

Ejemplo de ejecución:

¡Bienvenido al programa en C#!
Por favor, escribe tu nombre: Ana
Ahora escribe tu edad: 25
Bienvenido Ana, tienes 25 años.

🚀 Requisitos

.NET SDK instalado (versión 6.0 o superior recomendada).

Un editor o IDE compatible, como Visual Studio Code o Visual Studio.

🛠️ Compilación y Ejecución

Guarda el archivo con nombre Producto.cs.

Abre una terminal en la carpeta donde está el archivo.

Compila el programa con:

csc Producto.cs

Esto generará un archivo ejecutable llamado Producto.exe.

Ejecuta el programa con:

./Producto.exe

(En Windows puedes ejecutarlo con doble clic o desde la terminal).

📦 Alternativa con .NET CLI

Si prefieres usar la CLI de .NET:

Crea un proyecto de consola:

dotnet new console -n MiPrograma


Reemplaza el contenido de Program.cs con el código del programa.

Ejecuta el proyecto con:

dotnet run
