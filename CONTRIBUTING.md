# Cómo trabajar en este repo

Todos van a usar el mismo flujo: **rama propia + Pull Request**. Nadie sube
cambios directo a `main`. Así se practica lo mismo que se usa en trabajos reales.

## 0. Configuración inicial (una sola vez por persona)

1. Crear cuenta en GitHub si no tienen.
2. Instalar git: https://git-scm.com/downloads
3. Configurar su identidad (en una terminal):
   ```
   git config --global user.name "Tu Nombre"
   git config --global user.email "tu-correo@ejemplo.com"
   ```
4. Pedirle a franvas (dueño del repo) que los agregue como colaboradores en
   GitHub (Settings → Collaborators del repo).
5. Aceptar la invitación (llega un correo o aviso en GitHub).
6. Clonar el repo:
   ```
   git clone https://github.com/TitoPanzi/100-ejercicios-csharp.git
   cd 100-ejercicios-csharp
   ```

## 1. Antes de empezar a programar, actualizar main

```
git checkout main
git pull
```

## 2. Crear tu rama

Usen un nombre de rama que diga qué van a hacer, por ejemplo:

```
git checkout -b ejercicio05-nombre
```

## 3. Crear el ejercicio

```
dotnet new console -o Ejercicio05-DescripcionCorta -n Ejercicio05
```

Editen `Program.cs` dentro de esa carpeta con la solución del ejercicio.

## 4. Probar que corre

```
dotnet run --project Ejercicio05-DescripcionCorta
```

## 5. Guardar los cambios (commit)

```
git add Ejercicio05-DescripcionCorta
git commit -m "Agrega ejercicio 05: descripcion corta"
```

## 6. Subir tu rama a GitHub

```
git push -u origin ejercicio05-nombre
```

## 7. Abrir un Pull Request

1. Entrar al repo en GitHub, va a aparecer un botón "Compare & pull request".
2. Escribir un título corto y, si quieren, una descripción de qué hicieron.
3. Pedir que alguien del equipo lo revise (opcional pero recomendable) y
   luego apretar "Merge pull request".

## 8. Volver a sincronizar

Después de que su PR se mergea, o antes de empezar el siguiente ejercicio:

```
git checkout main
git pull
```

Y arrancan de nuevo desde el paso 2.

## Reglas básicas para no chocar

- **Un ejercicio = una rama = un PR.** No mezclen varios ejercicios en la misma rama.
- No editen carpetas de ejercicios de otra persona salvo que se pongan de acuerdo.
- Si `git pull` en `main` trae cambios nuevos y su rama quedó atrás, pueden
  actualizarla con `git merge main` estando parados en su rama.
- Si algo se traba (conflictos de merge, dudas), mejor preguntar antes de
  forzar cambios (`git push --force` NUNCA se usa acá).
