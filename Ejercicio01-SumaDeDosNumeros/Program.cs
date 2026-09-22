// Ejercicio 01: Suma de dos números
// Pide dos números al usuario y muestra el resultado de sumarlos.

Console.Write("Ingresa el primer número: ");
double numero1 = double.Parse(Console.ReadLine()!);

Console.Write("Ingresa el segundo número: ");
double numero2 = double.Parse(Console.ReadLine()!);

double resultado = numero1 + numero2;

Console.WriteLine($"El resultado de la suma es: {resultado}");
