Console.WriteLine("Hola, el siguiente prgrama consistirá en que usted adivine un número entre 1 y 15");
Random rnd = new Random();
int numero = rnd.Next(1,15);
int intentos = 0;

Console.WriteLine("Introduzca un número del 1 al 15");
intentos = Convert.ToInt32(Console.ReadLine());
while (intentos != numero && intentos <= 3)
{
    if(intentos < numero)
    {
        Console.WriteLine("El numero es mayor que el que has puesto");
    }
    else
    {
        Console.WriteLine("El numero es menor que el que has puesto");
    }
    Console.WriteLine("Intentalo otra vez");
    intentos = Convert.ToInt32(Console.ReadLine());
}

if (intentos == numero)
{
    Console.WriteLine("Has ganado");
}
else
{
    Console.WriteLine("Has perdido");
}