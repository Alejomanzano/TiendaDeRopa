# 🧩 Tienda de Ropa - Aplicación .NET MAUI

Aplicación desarrollada en **.NET MAUI** con **XAML + C#**, sin capas ni MVVM.  
Toda la lógica de negocio se encuentra en los archivos `.xaml.cs`.  
Se utiliza **SQLite** como base de datos local para gestionar productos, usuarios, ventas y reportes.

---

## 🧱 Características principales

- **Login** con validación de usuario y contraseña desde SQLite.  
- **Pantalla principal** con menú de navegación a los módulos.  
- **Módulos funcionales:**
  - 👕 **Productos:** CRUD completo (crear, listar, eliminar productos)
  - 👤 **Usuarios:** CRUD de usuarios locales
  - 💰 **Ventas:** Registro de ventas con cálculo automático del total
  - 📊 **Reportes:** Visualización de todas las ventas y total general
- **Base de datos SQLite**, creada automáticamente al iniciar la aplicación
- **Navegación** usando `NavigationPage` y `PushAsync`
- **Sin MVVM ni capas**, toda la lógica está en los `.xaml.cs`

---

## 🗄️ Base de datos SQLite

Se utiliza el paquete [`sqlite-net-pcl`](https://www.nuget.org/packages/sqlite-net-pcl).  

Tablas creadas automáticamente:

| Tabla     | Campos                 |
|-----------|-----------------------|
| Usuarios  | Id, Nombre, Password  |
| Productos | Id, Nombre, Precio    |
| Ventas    | Id, Producto, Cantidad, Total |

> La base de datos se almacena en:  
> `FileSystem.AppDataDirectory/tienda.db3`

---

## 🔑 Usuario inicial

| Usuario | Contraseña |
|---------|------------|
| admin   | 1234       |
|---------|------------|
| yue  | 123       |
|---------|------------|
| alejo   | 123       |

> Puedes iniciar sesión con estas credenciales la primera vez que ejecutes la app.

---

## 🧭 Navegación

- **LoginPage → MainPage**  
- **MainPage → Módulos** mediante botones  
- Ejemplo de navegación:
```csharp
await Navigation.PushAsync(new ProductosPage());
🖼️ Layout utilizado
Se utiliza VerticalStackLayout para organizar controles verticalmente.

Las listas se muestran con CollectionView.

Ejemplo de layout base:

xml
Copiar código
<VerticalStackLayout Padding="20" Spacing="10">
    <Entry Placeholder="Nombre" />
    <Button Text="Guardar" />
    <CollectionView>
        ...
    </CollectionView>
</VerticalStackLayout>
⚙️ Instalación y ejecución
Requisitos
Visual Studio 2022 (17.8 o superior)

.NET 8.0 o superior

Workload de .NET MAUI instalado

Pasos
Clonar el repositorio:

bash
Copiar código
git clone https://github.com/tuusuario/TiendaDeRopa.git
Abrir la solución TiendaDeRopa.sln en Visual Studio.

Instalar el paquete NuGet:

bash
Copiar código
Install-Package sqlite-net-pcl
Ejecutar la aplicación (F5).

Iniciar sesión con:

makefile
Copiar código
Usuario: admin
Contraseña: 1234
🧮 Funcionamiento general
LoginPage → Verifica usuario en SQLite.

MainPage → Menú principal.

ProductosPage → CRUD de productos.

UsuariosPage → CRUD de usuarios.

VentasPage → Registro de ventas con cálculo del total.

ReportesPage → Visualiza todas las ventas y total general.

📦 Tecnologías utilizadas
.NET MAUI

SQLite-net-pcl

Lenguajes: C# + XAML

👨‍💻 Autor
Nombre: Alejandro Manzano, Ainhoa Salas
Proyecto: Tienda de Ropa (.NET MAUI)
Fecha: 2025

🧾 Licencia
Este proyecto es de uso académico o demostrativo.
Puedes modificarlo y reutilizarlo libremente con fines educativos.
