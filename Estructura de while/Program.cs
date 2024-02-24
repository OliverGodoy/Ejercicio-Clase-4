/*Enunciado 1:
1. Escribe un programa que imprima los primeros 5 número pares.*/

for(int i = 0; i <= 10; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine("Los numeros pares son: " + i);
    }
}
Console.ReadLine();

//2. Crear un programa que calcule la suma de los primeros 10 número naturales

int suma = 0;

for (int i = 1; i <= 10; i++)
{
    suma += i;
}

Console.WriteLine("La suma de los primeros 10 números naturales es: " + suma);
Console.ReadLine();

/*Enunciado 2:
1. Desarrolla un programa que solicite al usuario ingresar números enteros positivos 
hasta que ingrese un número negativo. Luego, imprime la suma de los números 
ingresados.*/

int suma2 = 0;
int numero;

Console.WriteLine("Ingrese un número entero positivo (o un número negativo para salir):");
numero = int.Parse(Console.ReadLine());

while (numero >= 0)
{
    suma2 += numero;

    Console.WriteLine("Ingrese otro número entero positivo (o un número negativo para salir):");
    numero = int.Parse(Console.ReadLine());
}
Console.WriteLine("La suma de los números ingresados es: " + suma2);
Console.ReadLine();

//2. Escribe un programa que encuentre el primer número entero positivo divisible entre 7 y 11
int numeroentero = 1;
while (numeroentero % 7 != 0 || numeroentero % 11 != 0)
{
    numeroentero++;
}
Console.WriteLine("El primer número divisible entre 7 y 11 es: " + numeroentero);
Console.ReadLine();

/*Enunciado 3:
1. Desarrolla un programa que solicite al usuario ingresar una contraseña. El 
programa debe seguir solicitando la contraseña hasta que el usuario ingrese la 
contraseña correcta (jutiapa)*/

string contraseña;

do
{
    Console.WriteLine("Ingrese la contraseña:");
    contraseña = Console.ReadLine();
} while (contraseña != "jutiapa");

Console.WriteLine("¡Contraseña correcta!");
Console.ReadLine();

/*Escribe un programa que genere un número aleatorio entre 1 y 100, y luego 
permita al usuario adivinar el número. El programa debe continuar pidiendo al 
usuario que adivine hasta que ingrese el número correcto.*/

// Generar un número aleatorio entre 1 y 100
Random random = new Random();
int numeroAl = random.Next(1, 101);

int numeroUsuario;

// Bucle para adivinar el número
do
{
    Console.WriteLine("Ingrese un número entre 1 y 100:");
    numeroUsuario = int.Parse(Console.ReadLine());

    if (numeroUsuario < numeroAl)
    {
        Console.WriteLine("El número es mayor");
    }
    else if (numeroUsuario > numeroAl)
    {
        Console.WriteLine("El número es menor");
    }
} while (numeroUsuario != numeroAl);

Console.WriteLine("¡Felicidades! Adivinaste el número");
Console.ReadLine();


/*Escribe un programa que determine si un estudiante puede graduarse. Para 
graduarse, el estudiante debe cumplir con las siguientes condiciones:
 Haber aprobado todas las asignaturas.
 Tener un promedio general mayor o igual a 70.
 No haber sido sancionado por mal comportamiento*/

// Asignar valores de prueba
bool asignaturasAprobadas = true;
double promedioGeneral = 85.5;
bool sancionado = false;

// Evaluar si el estudiante puede graduarse
if (asignaturasAprobadas && promedioGeneral >= 70 && !sancionado)
{
    Console.WriteLine("¡El estudiante puede graduarse!");
}
else
{
    Console.WriteLine("El estudiante no puede graduarse.");
}

/*Desarrolla un programa para una biblioteca que determine si un libro puede ser 
prestado a un usuario. El libro puede ser prestado si cumple con al menos una de 
las siguientes condiciones:
 Es un libro de ficción y está disponible.
 Es un libro de no ficción y el usuario es mayor de 18 años.
 Es un libro de referencia y el usuario es miembro premium. Además, el usuario no 
puede tener más de 3 libros prestados actualmente*/

string tipoLibro = "no_ficcion";
bool libroDisponible = true;
int edadUsuario = 20;
bool esMiembroPremium = true;
int librosPrestados = 2;

// Evaluar si el libro puede ser prestado
bool puedePrestarse = false;

if (tipoLibro == "ficcion" && libroDisponible)
{
    puedePrestarse = true;
}
else if (tipoLibro == "no_ficcion" && edadUsuario >= 18)
{
    puedePrestarse = true;
}
else if (tipoLibro == "referencia" && esMiembroPremium)
{
    puedePrestarse = true;
}

// Validar la cantidad de libros prestados
if (puedePrestarse && librosPrestados < 3)
{
    Console.WriteLine("¡El libro puede ser prestado!");
}
else
{
    Console.WriteLine("El libro no puede ser prestado.");
}