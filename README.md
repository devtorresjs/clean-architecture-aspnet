# Clean Architecture

Esta aplicación está basada en la **Clean Architecture** propuesta por Robert C. Martin. La decisión de implementarla se tomó porque permite desarrollar el **core del sistema sin depender de frameworks externos**, además de ofrecer una estructura organizada por **casos de uso**.

## Arquitectura

Internamente, la solución sigue el modelo planteado por Uncle Bob:  
**controllers → input ports → interactors → output ports → presenters**, etc.

Si bien cada caso de uso no está estrictamente separado en carpetas como `domain`, `application` o `infrastructure`, **la regla fundamental se cumple completamente: la regla de dependencia**.

### Beneficios principales

- **Escalabilidad y modularidad**: Cada interactor cumple una tarea específica.
- **Claridad y mantenibilidad**: A pesar de que inicialmente puede parecer que existen muchos proyectos, clases o líneas de código, esta inversión evita conflictos futuros.
- **Independencia tecnológica**:  
  El negocio de un caso de uso no depende directamente de una base de datos, un presenter o cualquier servicio externo.
- **Pruebas más sencillas**:  
  Cada caso de uso puede ser testeado de forma modular gracias al aislamiento de dependencias.

##  Pruebas

El proyecto incluye tres tipos de **unit tests**:

1. **InMemory** – Simulación de repositorios y servicios.
2. **BD SQL** – Pruebas reales contra la base de datos.
3. **Specifications** – Validación de reglas de negocio y especificaciones.

##  Organización del código

Cada capa tiene una responsabilidad bien definida, lo que permite mantener una **WebAPI muy limpia**, cuyo rol se limita prácticamente a **inyectar servicios**.

Cada feature define su propio **endpoint mapping**, facilitando:

- Movilidad de features entre APIs.
- Migración sencilla hacia **microservicios**.
- Independencia entre tecnologías externas.

Si en algún momento se decide independizar la base de datos de una feature específica, el cambio es simple y de bajo impacto.

## Extensibilidad

La arquitectura está lista para escalar e integrar nuevas tecnologías.  
Por ejemplo, para agregar **gRPC**, solo se deben definir los contratos correspondientes, sin modificar el core de la aplicación.

## Por qué Clean Architecture

Clean Architecture es una de mis arquitecturas favoritas porque, aunque requiere un mayor trabajo inicial, ofrece:

- **Control total sobre la aplicación**
- **Escalabilidad rápida**
- **Flexibilidad tecnológica**
- **Pruebas más robustas**
- **Cero dependencias innecesarias en el dominio**

---
## Librerías Incluidas

El proyecto incluye dos librerías externas desarrolladas durante un taller impartido por un **MVP de Microsoft**:

- **DomainValidation**
- **HttpExceptionHandling**

Contamos con el **código fuente completo** de ambas, lo que permite personalizarlas según las necesidades de la empresa.

### Manejo de Excepciones en Debug

En el caso de uso **CreateProduct**, si se ingresan valores incorrectos se lanza una excepción.  
Durante la depuración en Visual Studio, es normal que aparezca la excepción y que sea necesario presionar **Continue** para que los mensajes de error se muestren correctamente.  
Este comportamiento **es esperado durante el debug**.

## Requisitos para ejecutar el proyecto

Para poder ejecutar el proyecto se necesita:

- **Visual Studio 2022 o superior**  
- **.NET SDK 9**
1. Abre **Package Manager Console** en Visual Studio.  
2. Selecciona el proyecto **`Tec.ProductCatalog.EFCore.Repositories`** como proyecto predeterminado en la consola.  
3. Ejecuta los siguientes comandos:

```bash
Add-Migration AddInitialDB -p Tec.ProductCatalog.EFCore.Repositories -s Tec.ProductCatalog.EFCore.Repositories -c ProductCatalogDbContext

Update-Database -p Tec.ProductCatalog.EFCore.Repositories -s Tec.ProductCatalog.EFCore.Repositories -context ProductCatalogDbContext

Una vez instalados estos requisitos, el proyecto puede ejecutarse directamente desde Visual Studio.
```
## Endpoints y Requests

La definición de los **request** utilizados por los endpoints está ubicada en: la webapi => Tec.ProductCatalog.WebAPI.http

