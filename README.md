# 100 Ejercicios de C#

Repo grupal para la tarea de la universidad: 100 ejercicios de C#, uno por carpeta,
y de paso una excusa para aprender a usar git y GitHub en equipo.

## Estructura

Cada ejercicio vive en su propia carpeta, con este formato de nombre:

```
EjercicioNN-DescripcionCorta/
```

Ejemplo: `Ejercicio01-SumaDeDosNumeros/`

Cada carpeta es un proyecto de consola de .NET independiente (tiene su propio
`.csproj`), así que se puede correr por separado con:

```
dotnet run --project Ejercicio01-SumaDeDosNumeros
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

## Lista de ejercicios

| # | Descripción | Autor | Estado |
|---|---|---|---|
| 01 | Suma de dos números | franvas | ✅ |
