# 100 Ejercicios de C#

Repo grupal para la tarea de **Programación y Estructura de Datos (UDP)**: los
100 problemas de la guía de sentencias de flujo, y de paso una excusa para
aprender a usar git y GitHub en equipo.

El enunciado completo está en [`enunciado/Guia_100_Problemas_CSharp.pdf`](enunciado/Guia_100_Problemas_CSharp.pdf).
La guía **no trae soluciones a propósito** (para forzar a pensar el algoritmo
solos), así que estos ejercicios se resuelven de verdad, no se copian de acá.

## Reparto del equipo

Cada persona tomó 25 problemas (5 por cada uno de los 5 niveles de la guía):

| Persona | Problemas asignados |
|---|---|
| David Manjarrés | 1–5, 36–40, 51–55, 66–70, 81–85 |
| Francisco Vásquez | 6–10, 21–25, 56–60, 71–75, 86–90 |
| Alex Carrasco | 11–15, 26–30, 41–45, 76–80, 91–95 |
| Kevin Gómez | 16–20, 31–35, 46–50, 61–65, 96–100 |

Cada uno resuelve **sus propios problemas** siguiendo el flujo de
[CONTRIBUTING.md](CONTRIBUTING.md) (rama propia + Pull Request). No editen
carpetas de ejercicios de otra persona.

## Estructura

Cada ejercicio vive en su propia carpeta, con este formato de nombre:

```
EjercicioNN-DescripcionCorta/
```

Ejemplo: `Ejercicio01-CalculoVentaSimple/`

Cada carpeta es un proyecto de consola de .NET independiente (tiene su propio
`.csproj`), así que se puede correr por separado con:

```
dotnet run --project Ejercicio01-CalculoVentaSimple
```

## Cómo crear un ejercicio nuevo

Desde la raíz del repo:

```
dotnet new console -o EjercicioNN-DescripcionCorta -n EjercicioNN
```

Eso crea la carpeta con el `.csproj` y un `Program.cs` de partida.

## Flujo de trabajo (léanlo antes de programar)

Ver [CONTRIBUTING.md](CONTRIBUTING.md) — ahí está el paso a paso de cómo trabajar
con ramas y Pull Requests para que no se pisen el código entre todos.

## Lista de los 100 problemas

Estado: ⬜ pendiente · 🔨 en progreso · ✅ listo

### Nivel 1 — Secuencia y cálculos directos (1–20)

| # | Problema | Área | Autor | Estado |
|---|---|---|---|---|
| 01 | Cálculo de venta simple | Empresa | David Manjarrés | 🔨 |
| 02 | Costo de compra con IVA | Empresa | David Manjarrés | 🔨 |
| 03 | Remuneración por horas | Empresa | David Manjarrés | ⬜ |
| 04 | Área y perímetro de un rectángulo | Matemática | David Manjarrés | ⬜ |
| 05 | Conversión de temperatura | Ciencias | David Manjarrés | ⬜ |
| 06 | Velocidad promedio | Ciencias | Francisco Vásquez | ⬜ |
| 07 | Valor de inventario | Empresa | Francisco Vásquez | ⬜ |
| 08 | Promedio de tres mediciones | Matemática | Francisco Vásquez | ⬜ |
| 09 | Conversión de moneda | Empresa | Francisco Vásquez | ⬜ |
| 10 | Interés simple | Empresa | Francisco Vásquez | ⬜ |
| 11 | Punto de equilibrio unitario | Empresa | Alex Carrasco | ⬜ |
| 12 | Productividad de una línea | Empresa | Alex Carrasco | ⬜ |
| 13 | Consumo eléctrico | Ciencias | Alex Carrasco | ⬜ |
| 14 | Densidad de una muestra | Ciencias | Alex Carrasco | ⬜ |
| 15 | Energía cinética | Ciencias | Alex Carrasco | ⬜ |
| 16 | Concentración molar | Ciencias | Kevin Gómez | ⬜ |
| 17 | Costo de transporte por combustible | Empresa | Kevin Gómez | ⬜ |
| 18 | Volumen de riego | Ciencias | Kevin Gómez | ⬜ |
| 19 | Promedio ponderado | Matemática | Kevin Gómez | ⬜ |
| 20 | Margen unitario y total | Empresa | Kevin Gómez | ⬜ |

### Nivel 2 — Decisiones y clasificación (21–40)

| # | Problema | Área | Autor | Estado |
|---|---|---|---|---|
| 21 | Descuento por monto de compra | Empresa | Francisco Vásquez | ⬜ |
| 22 | Horas extraordinarias | Empresa | Francisco Vásquez | ⬜ |
| 23 | Reposición de inventario | Empresa | Francisco Vásquez | ⬜ |
| 24 | Alerta de temperatura | Ciencias | Francisco Vásquez | ⬜ |
| 25 | Número par o impar | Matemática | Francisco Vásquez | ⬜ |
| 26 | Tarifa de estacionamiento | Empresa | Alex Carrasco | ⬜ |
| 27 | Aprobación básica de crédito | Empresa | Alex Carrasco | ⬜ |
| 28 | Control de tolerancia dimensional | Ciencias | Alex Carrasco | ⬜ |
| 29 | Clasificación de pH | Ciencias | Alex Carrasco | ⬜ |
| 30 | Clasificación de IMC | Ciencias | Alex Carrasco | ⬜ |
| 31 | Costo de despacho | Empresa | Kevin Gómez | ⬜ |
| 32 | Mayor de tres números | Matemática | Kevin Gómez | ⬜ |
| 33 | Existencia de raíces reales | Matemática | Kevin Gómez | ⬜ |
| 34 | Año bisiesto | Matemática | Kevin Gómez | ⬜ |
| 35 | Tarifa eléctrica por tramo | Empresa | Kevin Gómez | ⬜ |
| 36 | Comisión de ventas | Empresa | David Manjarrés | ⬜ |
| 37 | Bono por cumplimiento | Empresa | David Manjarrés | ⬜ |
| 38 | Control de velocidad | Empresa | David Manjarrés | ⬜ |
| 39 | Estado de aprobación | Académico | David Manjarrés | ⬜ |
| 40 | Clasificación de triángulo | Ciencias | David Manjarrés | ⬜ |

### Nivel 3 — Repetición, contadores y acumuladores (41–60)

| # | Problema | Área | Autor | Estado |
|---|---|---|---|---|
| 41 | Tabla de multiplicar | Matemática | Alex Carrasco | ⬜ |
| 42 | Suma de los primeros N enteros | Matemática | Alex Carrasco | ⬜ |
| 43 | Factorial | Matemática | Alex Carrasco | ⬜ |
| 44 | Promedio de ventas | Empresa | Alex Carrasco | ⬜ |
| 45 | Conteo de mediciones | Ciencias | Alex Carrasco | ⬜ |
| 46 | Máxima y mínima temperatura | Ciencias | Kevin Gómez | ⬜ |
| 47 | Ventas hasta dato centinela | Empresa | Kevin Gómez | ⬜ |
| 48 | Control de intentos de acceso | Empresa | Kevin Gómez | ⬜ |
| 49 | Producción hasta alcanzar meta | Empresa | Kevin Gómez | ⬜ |
| 50 | Ahorro hasta objetivo | Empresa | Kevin Gómez | ⬜ |
| 51 | Simulación de punto de equilibrio | Empresa | David Manjarrés | ⬜ |
| 52 | Crecimiento de una población | Ciencias | David Manjarrés | ⬜ |
| 53 | Número primo | Matemática | David Manjarrés | ⬜ |
| 54 | Listado de divisores | Matemática | David Manjarrés | ⬜ |
| 55 | Serie de Fibonacci | Matemática | David Manjarrés | ⬜ |
| 56 | Suma de dígitos | Matemática | Francisco Vásquez | ⬜ |
| 57 | Número invertido | Matemática | Francisco Vásquez | ⬜ |
| 58 | Máximo común divisor | Matemática | Francisco Vásquez | ⬜ |
| 59 | Decaimiento hasta umbral | Ciencias | Francisco Vásquez | ⬜ |
| 60 | Inspección hasta cinco rechazos | Empresa | Francisco Vásquez | ⬜ |

### Nivel 4 — Combinación de estructuras (61–80)

| # | Problema | Área | Autor | Estado |
|---|---|---|---|---|
| 61 | Resumen anual de ventas | Empresa | Kevin Gómez | ⬜ |
| 62 | Liquidación de varios trabajadores | Empresa | Kevin Gómez | ⬜ |
| 63 | Revisión de stock de varios productos | Empresa | Kevin Gómez | ⬜ |
| 64 | Encuesta de satisfacción | Empresa | Kevin Gómez | ⬜ |
| 65 | Monitoreo diario de temperatura | Ciencias | Kevin Gómez | ⬜ |
| 66 | Tabla de productos de 1 a 10 | Matemática | David Manjarrés | ⬜ |
| 67 | Primos en un intervalo | Matemática | David Manjarrés | ⬜ |
| 68 | Triángulo numérico | Matemática | David Manjarrés | ⬜ |
| 69 | Números perfectos | Matemática | David Manjarrés | ⬜ |
| 70 | Números Armstrong de tres cifras | Matemática | David Manjarrés | ⬜ |
| 71 | Evaluación de solicitudes de crédito | Empresa | Francisco Vásquez | ⬜ |
| 72 | Despacho de pedidos | Empresa | Francisco Vásquez | ⬜ |
| 73 | Control de lotes de producción | Empresa | Francisco Vásquez | ⬜ |
| 74 | Movimientos de inventario | Empresa | Francisco Vásquez | ⬜ |
| 75 | Caja hasta cierre | Empresa | Francisco Vásquez | ⬜ |
| 76 | Cobro de estacionamiento para varios vehículos | Empresa | Alex Carrasco | ⬜ |
| 77 | Registro de precipitaciones | Ciencias | Alex Carrasco | ⬜ |
| 78 | Tres lecturas consecutivas válidas | Ciencias | Alex Carrasco | ⬜ |
| 79 | Crecimiento con cambio de tasa | Ciencias | Alex Carrasco | ⬜ |
| 80 | Cumplimiento de entregas | Empresa | Alex Carrasco | ⬜ |

### Nivel 5 — Problemas integradores (81–100)

| # | Problema | Área | Autor | Estado |
|---|---|---|---|---|
| 81 | Informe de ventas por transacciones | Empresa | David Manjarrés | ⬜ |
| 82 | Nómina con reglas de pago | Empresa | David Manjarrés | ⬜ |
| 83 | Simulación de cuenta bancaria | Empresa | David Manjarrés | ⬜ |
| 84 | Control de calidad por lotes y muestras | Ciencias | David Manjarrés | ⬜ |
| 85 | Eficiencia de una flota | Empresa | David Manjarrés | ⬜ |
| 86 | Costo energético por horario | Empresa | Francisco Vásquez | ⬜ |
| 87 | Monitoreo de invernadero | Ciencias | Francisco Vásquez | ⬜ |
| 88 | Simulación diaria de inventario | Empresa | Francisco Vásquez | ⬜ |
| 89 | Comisiones mensuales con meta | Empresa | Francisco Vásquez | ⬜ |
| 90 | Trayectoria vertical por pasos de tiempo | Ciencias | Francisco Vásquez | ⬜ |
| 91 | Decaimiento exponencial discreto | Ciencias | Alex Carrasco | ⬜ |
| 92 | Aproximación de raíz cuadrada | Matemática | Alex Carrasco | ⬜ |
| 93 | Aproximación de área por rectángulos | Matemática | Alex Carrasco | ⬜ |
| 94 | Cajero automático con menú | Empresa | Alex Carrasco | ⬜ |
| 95 | Pedido de restaurante | Empresa | Alex Carrasco | ⬜ |
| 96 | Tarjeta de transporte | Empresa | Kevin Gómez | ⬜ |
| 97 | Resultados de un curso | Académico | Kevin Gómez | ⬜ |
| 98 | Serie de ensayos válidos | Ciencias | Kevin Gómez | ⬜ |
| 99 | Evaluación de entregas y penalizaciones | Empresa | Kevin Gómez | ⬜ |
| 100 | Sistema básico de ventas e inventario | Empresa | Kevin Gómez | ⬜ |
