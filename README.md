<h1>Blazor CRUD Project with Entity Framework</h1>
<p>Este proyecto es una aplicación web desarrollada con Blazor, una tecnología de Microsoft que permite crear aplicaciones web interactivas utilizando C# en lugar de JavaScript. En este proyecto, estamos aprendiendo a utilizar Blazor para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en una base de datos utilizando Entity Framework.</p>

<h2>Funcionalidades</h2>
<ul>
    <li><strong>Crear:</strong> Permite al usuario agregar nuevos elementos a la base de datos.</li>
    <li><strong>Leer:</strong> Muestra los elementos almacenados en la base de datos.</li>
    <li><strong>Actualizar:</strong> Permite al usuario editar los elementos existentes.</li>
    <li><strong>Eliminar:</strong> Permite al usuario eliminar elementos de la base de datos.</li>
</ul>

<h2>Tecnologías Utilizadas</h2>
<ul>
    <li><strong>Blazor:</strong> Un framework de Microsoft para construir aplicaciones web interactivas utilizando C# y .NET.</li>
    <li><strong>Entity Framework Core:</strong> Un ORM (Mapeador Objeto-Relacional) que facilita el acceso y la manipulación de datos en la base de datos utilizando modelos de datos de .NET.</li>
    <li><strong>C#:</strong> Lenguaje de programación utilizado para el desarrollo de la lógica de la aplicación.</li>
    <li><strong>ASP.NET Core:</strong> Framework utilizado para crear aplicaciones web y APIs en .NET.</li>
</ul>

<h2>Configuración del Proyecto</h2>
<ol>
    <li><strong>Clonar el Repositorio:</strong> Clona este repositorio en tu máquina local utilizando el siguiente comando:<br>
        <code>git clone https://github.com/1v4n21/BlazorCRUDEntityFramework</code></li>
    <li><strong>Instalar Dependencias:</strong> Una vez clonado el repositorio, navega hasta el directorio del proyecto y ejecuta el siguiente comando para instalar las dependencias necesarias:<br>
        <code>dotnet restore</code></li>
    <li><strong>Configurar la Base de Datos:</strong> Despues de crear el Context hay que ejecutar en terminal los siguientes comandos
        <code>Add-Migration Initial</code><code>Update-Database</code></li>
    <li><strong>Aplicar Migraciones:</strong> Para crear las tablas en la base de datos, ejecuta las migraciones con el siguiente comando:<br>
        <code>dotnet ef database update</code></li>
    <li><strong>Ejecutar la Aplicación:</strong> Una vez configurada la base de datos, ejecuta la aplicación con el siguiente comando:<br>
        <code>dotnet run</code></li>
</ol>

<h2>Contribuciones</h2>
<p>Las contribuciones son bienvenidas. Si deseas mejorar esta aplicación, no dudes en abrir un issue o enviar un pull request.</p>

<h2>Licencia</h2>
<p>Este proyecto está bajo la licencia <a href="LICENSE">MIT</a>.</p>
