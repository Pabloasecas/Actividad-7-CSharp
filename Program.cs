Console.WriteLine("Hola, el siguiente prgrama consistirá en que usted adivine un número entre 1 y 15");
Random rnd = new Random();
int numero = rnd.Next(1,15);
int intentos = 2;

Console.WriteLine("Introduzca un número del 1 al 15");
int numeroUsuario = Convert.ToInt32(Console.ReadLine());

while (intentos > 0)
{
    if (numeroUsuario == numero)
    {
    Console.WriteLine("Has ganado");
    }
    else if(numero < numeroUsuario)
    {
        Console.WriteLine("El numero es menor que el que ha puesto");
    }
    else
    {
        Console.WriteLine("El numero es mayor que el que ha puesto");
    }
    intentos--;
    Console.WriteLine("Intentalo otra vez");
    numeroUsuario = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Has perdido");
