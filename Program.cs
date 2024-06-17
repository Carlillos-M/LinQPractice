// See https://aka.ms/new-console-template for more information


//Video 1: Que es LINQ

/*
int [] numeros = { 1, 2, 3, 4, 5};}
int [] numeros = Enumerable .Range (1, 100).ToArray ();

//Sintaxis de metodos
var numerosp = numeros.Where(n => n % 2 == 0).ToList();

//Sintaxis de queries
var numerosp2 = (from n in numeros
                where n % 2 == 0
                select n).ToList();
                */



//Video 2: Ejecución Diferida

/*int [] numeros = Enumerable .Range (1, 5).ToArray ();

//Sintaxis de metodos
var numerosp = numeros.Where(n => {
    Console.WriteLine ($"Evaluenado si {n} es par");
    return n % 2 == 0;
    });

foreach (var numero in numerosp)
{
    Console.WriteLine ($"Si, el {numero} es par");
}
*/

//Video 3: Función Where
/*
int [] numeros = Enumerable .Range (1, 20).ToArray ();

var numerosp = numeros.Where(n =>  n % 2 == 1).ToList ();

/*Console.WriteLine ("Los numeros impares son: ");
foreach (var numero in numerosp)
{
    Console.WriteLine (numero);
}*/

//Sintaxis de metodos
//var numerosImparesMayoresQue10 = numeros.Where (n => n % 2 == 1 && n > 10).ToList ();

// Sintaxis de Queries
/*
var numerosImparesMayoresQue10_2 = from n in numeros
where n % 2 == 1 && n > 10
select n;

Console.WriteLine ("Los numeros impares mayores que 10 son: ");
foreach (var numero in numerosImparesMayoresQue10_2)
{
    Console.WriteLine (numero);
}*/

//Video 4: Where con objetos
using System.Linq.Expressions;
using LINQPractice;

/*
var personas = new List<Persona>(){
    new Persona { Nombre = "Carlos", Edad = 29, FechaIngreso = new DateTime(2016,3,26), Soltero = true},
    new Persona { Nombre = "Mariana", Edad = 23, FechaIngreso = new DateTime(2020,4,22), Soltero = false},
    new Persona { Nombre = "Ulises", Edad = 25, FechaIngreso = new DateTime(2022,8,15), Soltero = true},
    new Persona { Nombre = "Melany", Edad = 21, FechaIngreso = new DateTime(2015,1,15), Soltero = true},
    new Persona { Nombre = "Hugo", Edad = 60, FechaIngreso = new DateTime(2010,7,30), Soltero = false},      
};

//var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

//foreach (var persona in personasDe25AñosOMenos)
//{
//    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años");
//}

var solteros = personas.Where(p => p.Soltero && p.Edad <= 25).ToList();

foreach (var persona in solteros)
{
    Console.WriteLine($"{persona.Nombre} es soltero/a");
}

var personasConMasDe2AñosDeIngreso = personas.Where(p => p.FechaIngreso <= DateTime.Now.AddYears (-2)).ToList();

foreach (var persona in personasConMasDe2AñosDeIngreso)
{
    Console.WriteLine($"{persona.Nombre} tiene mas de 2 años de ingreso");
}
*/

//Video 5: First & FirstOrDefault
/*
var personas = new List<Persona>(){
    new Persona { Nombre = "Carlos", Edad = 29, FechaIngreso = new DateTime(2016,3,26), Soltero = true},
    new Persona { Nombre = "Mariana", Edad = 23, FechaIngreso = new DateTime(2020,4,22), Soltero = false},
    new Persona { Nombre = "Ulises", Edad = 25, FechaIngreso = new DateTime(2022,8,15), Soltero = true},
    new Persona { Nombre = "Melany", Edad = 21, FechaIngreso = new DateTime(2015,1,15), Soltero = true},
    new Persona { Nombre = "Hugo", Edad = 60, FechaIngreso = new DateTime(2010,7,30), Soltero = false},      
};


var primeraPersona2 = personas.FirstOrDefault();

var paises = new List<string>();

try
{
    var primerPais = paises.First();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error");
}

var primeraPersona = personas.FirstOrDefault(p => !p.Soltero);
var a = 1;
*/

//Video 6: Last & LastOrDefault
/*
var personas = new List<Persona>(){
    new Persona { Nombre = "Carlos", Edad = 29, FechaIngreso = new DateTime(2016,3,26), Soltero = true},
    new Persona { Nombre = "Mariana", Edad = 23, FechaIngreso = new DateTime(2020,4,22), Soltero = false},
    new Persona { Nombre = "Ulises", Edad = 25, FechaIngreso = new DateTime(2022,8,15), Soltero = true},
    new Persona { Nombre = "Melany", Edad = 21, FechaIngreso = new DateTime(2015,1,15), Soltero = true},
    new Persona { Nombre = "Hugo", Edad = 60, FechaIngreso = new DateTime(2010,7,30), Soltero = false},      
};

var ultimaPersona = personas.Last();
var ultimaPersona2 = personas.LastOrDefault();

var ultimaPersonaSoltera = personas.Last(p => p.Soltero);

// Sintaxis de Query

var ultimaPersonaSoltera_2 = (from p in personas
                            where p.Soltero
                            select p).Last();

*/

//Video 7: ElementAt & ElementAtorDefault
/*
var personas = new List<Persona>(){
    new Persona { Nombre = "Carlos", Edad = 29, FechaIngreso = new DateTime(2016,3,26), Soltero = true},
    new Persona { Nombre = "Mariana", Edad = 23, FechaIngreso = new DateTime(2020,4,22), Soltero = false},
    new Persona { Nombre = "Ulises", Edad = 25, FechaIngreso = new DateTime(2022,8,15), Soltero = true},
    new Persona { Nombre = "Melany", Edad = 21, FechaIngreso = new DateTime(2015,1,15), Soltero = true},
    new Persona { Nombre = "Hugo", Edad = 60, FechaIngreso = new DateTime(2010,7,30), Soltero = false},      
};

var terceraPersona = personas.ElementAt(2);

//Sintaxis de Query
var terceraPersona2 = (from p in personas
                        select p).ElementAtOrDefault(2);
*/

//Video 8: Single & SingleOrDefault
/*
var personas = new List<Persona>(){
    new Persona { Nombre = "Carlos", Edad = 29, FechaIngreso = new DateTime(2016,3,26), Soltero = true},
    new Persona { Nombre = "Mariana", Edad = 23, FechaIngreso = new DateTime(2020,4,22), Soltero = false},
    new Persona { Nombre = "Ulises", Edad = 25, FechaIngreso = new DateTime(2022,8,15), Soltero = true},
    new Persona { Nombre = "Melany", Edad = 21, FechaIngreso = new DateTime(2015,1,15), Soltero = true},
    new Persona { Nombre = "Hugo", Edad = 60, FechaIngreso = new DateTime(2010,7,30), Soltero = false},      
};

var personaMayorDe50 = personas.Single(p => p.Edad > 50);

//Sintaxis de Query
var personaMayorDe50_2 = (from p in personas
                            where p.Edad > 50
                            select p).Single();

try
{
    var personaMayorDe100 = personas.Single(p => p.Edad > 100);
} catch (Exception ex)
{
    Console.WriteLine("Hubo un error, arreglo vacio");
}

try
{
    var personaMayorA5 = personas.SingleOrDefault(p => p.Edad > 5);
} catch (Exception ex)
{
    Console.WriteLine("Hubo un error, arreglo con mas de un elemento");
}
*/
//Video 9: Filtrando por TIpo
/*
var listado = new List<object>() {"Carlos", 1, 2, "Ernesto", true};

var strings = listado.OfType<string>();
var numeros = listado.OfType<int>();

//sintaxis de Query
var strings_2 = from s in listado.OfType<string>()
                select s;

// Ejemplo 2: Herencia

var ListadoAnimales = new List<Animal>()
{
    new Perro(){Nombre = "Nitro"},
    new Gato(){Nombre = "Pelusa"},
};

var perros = ListadoAnimales.OfType<Perro>();

public abstract class Animal
{
    public abstract string? Nombre { get; set;}
}

public class Perro : Animal
{
    public override string? Nombre { get; set;}
}

public class Gato : Animal
{
    public override string? Nombre { get; set;}
}
*/

//Video 10: OrderBy & OrderByDescending

var personas = new List<Persona>(){
    new Persona { Nombre = "Carlos", Edad = 29, FechaIngreso = new DateTime(2016,3,26), Soltero = true},
    new Persona { Nombre = "Mariana", Edad = 23, FechaIngreso = new DateTime(2020,4,22), Soltero = false},
    new Persona { Nombre = "Ulises", Edad = 25, FechaIngreso = new DateTime(2022,8,15), Soltero = true},
    new Persona { Nombre = "Melany", Edad = 21, FechaIngreso = new DateTime(2015,1,15), Soltero = true},
    new Persona { Nombre = "Hugo", Edad = 60, FechaIngreso = new DateTime(2010,7,30), Soltero = false},      
};

//var personasOrdenadasPorEdad = personas.OrderBy(x => x.Edad);

//foreach (var persona in personasOrdenadasPorEdad)
//{
//    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
//}

int[] numeros = { 1, 2, 40, 5, 111, 20};

foreach (var numero in numeros.OrderBy(x => x))
{
    Console.WriteLine(numero);
}

//Sintaxis de Query
var numeros_2 = from n in numeros
                orderby n
                select n;

var personasOrdenadasPorEdad_2 = from p in personas
                                orderby p.Edad descending
                                select p;
//Console.WriteLine("Hello, World!");

