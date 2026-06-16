# TP4_Amaldonado

Aplicación desarrollada en **Blazor Hybrid con .NET MAUI** para consumir una API REST externa.

El proyecto utiliza la API pública **DummyJSON**, específicamente el recurso de carritos de compra:

```txt
https://dummyjson.com/carts
```

## Funcionalidades

- Listado de carritos.
- Detalle de carrito con productos e imágenes.
- Alta de carrito.
- Edición de carrito.
- Eliminación de carrito con confirmación.

## Métodos implementados

| Método | Endpoint | Uso |
|---|---|---|
| GET | `/carts` | Obtener carritos |
| GET | `/carts/{id}` | Obtener detalle |
| POST | `/carts/add` | Crear carrito |
| PUT | `/carts/{id}` | Editar carrito |
| DELETE | `/carts/{id}` | Eliminar carrito |

> DummyJSON simula las operaciones POST, PUT y DELETE, por lo que los cambios no quedan guardados permanentemente.

## Estructura principal

```txt
Models/
Services/
Components/Pages/
```

- `Models`: clases para representar los datos de la API.
- `Services`: servicio `CartService` con la lógica de conexión mediante `HttpClient`.
- `Components/Pages`: páginas Razor de la aplicación.

## Diseño

La interfaz fue personalizada con **Tailwind CSS**.

Para trabajar sobre los estilos, ejecutar:

```bash
npm install
npx @tailwindcss/cli -i ./wwwroot/css/input.css -o ./wwwroot/css/tailwind.css --watch
```

## Tecnologías

- Blazor Hybrid
- .NET MAUI
- C#
- HttpClient
- DummyJSON API
- Tailwind CSS
- Git / GitHub

## Autor

Agustina Maldonado