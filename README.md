# API para Gestión de Tiendas de Ropa

## Descripción del Proyecto

Este proyecto es una API diseñada para la gestión de tiendas de ropa, proporcionando una solución integral para la administración de bases de datos y operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre las distintas entidades del negocio.

La API ha sido desarrollada utilizando tecnologías modernas y está estructurada para facilitar la implementación y el mantenimiento de datos relacionados con una tienda de ropa, incluyendo clientes, productos, órdenes y más.

## Características Principales

- **Migraciones de Base de Datos:** Configuración rápida y sencilla para crear y mantener la estructura de la base de datos.
- **CRUD Completo:** Implementación completa de operaciones CRUD para todas las entidades.
- **Endpoints Eficientes:** Endpoints bien organizados para interactuar con los datos de manera intuitiva y eficiente.
- **Diseño Modular:** Estructura del proyecto modular para facilitar la escalabilidad y el mantenimiento.

## Entidades Disponibles

El proyecto incluye soporte para las siguientes entidades:

1. **Cargo:** Gestión de roles o posiciones dentro de la tienda.
   - Endpoint: [http://localhost:5137/Api/Cargo](http://localhost:5137/Api/Cargo)

2. **Cliente:** Administración de información de los clientes.
   - Endpoint: [http://localhost:5137/Api/Cliente](http://localhost:5137/Api/Cliente)

3. **Color:** Gestión de colores para la clasificación de productos.
   - Endpoint: [http://localhost:5137/Api/Color](http://localhost:5137/Api/Color)

4. **Departamento:** Administración de departamentos o áreas dentro de la tienda.
   - Endpoint: [http://localhost:5137/Api/Departamento](http://localhost:5137/Api/Departamento)

5. **Detalle de Orden:** Gestión de los detalles asociados a cada orden de compra.
   - Endpoint: [http://localhost:5137/Api/DetalleOrden](http://localhost:5137/Api/DetalleOrden)

## Configuración Inicial

### Requisitos Previos

1. .NET SDK instalado en el sistema.
2. Base de datos configurada (compatible con EF Core).

### Pasos para Ejecutar el Proyecto

1. Clona el repositorio del proyecto.
   ```bash
   git clone <https://github.com/Alejomdi193/TIENDA-ROPA-PROYECTO.git>
   cd <./Persistencia>
   ```

2. Aplica las migraciones para configurar la base de datos:
   ```bash
   dotnet ef database update --project ./Persistencia --startup-project ./Api
   ```

3. Inicia el servidor:
   ```bash
   dotnet run --project ./Api
   ```

4. Accede a los endpoints de la API a través de tu navegador o herramienta de prueba como Postman.

## Tecnologías Utilizadas

- **Framework:** .NET Core
- **ORM:** Entity Framework Core
- **Base de Datos:** Compatible con SQL Server, PostgreSQL u otros.
- **Servidor Web:** Kestrel


## Licencia

Este proyecto está licenciado bajo la [MIT License](LICENSE).



