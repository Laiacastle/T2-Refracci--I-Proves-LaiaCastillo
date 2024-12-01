# T2. PR2. Proves i refacció

## 1.Quines són les característiques i els escenaris d'ús de les metodologies   àgils de desenvolupament de programari? Explica amb detall i posa un exemple

Las metodologías ágiles son un _conjunto de técnicas_ que se aplican a la hora del desarrollo de un proyecto, con el objetivo de que la entrega de este sea __más eficiente__.

Así, con cada etapa completada, ya se pueden entregar avances y se deja de lado la necesidad de esperar hasta el término del proyecto.

Son fundamentales sobre todo en proyectos de _software_ porque permiten gestionar los proyectos de manera más _flexible y eficiente_, mejorando la calidad del software y asegurando que cumpla con las expectativas del cliente.

Se caracterizan sobre todo por ser __iterativas, incrementales y adaptativas__. El desarrollo se suele dividir en ciclos cortos llamados iteraciones.

__Otras características claves de las metodologías ágiles son:__

- __Facilitar la colaboración entre equipos y clientes__; al entregar cada menos tiempo el trabajo avanzado, podemos tener más feedback para acercarnos más al resultado esperado por el cliente

- __Adaptarse a cambios en los requisitos__; ya que al tener mas feedbacks podemos trabajar en mejorar el código aún más.

- __Entregar valor rápidamente__; normalmente se hace cada 2-3 semanas.

- __Mejorar la calidad del software__

- __Fomentar la motivación del equipo__; ya que normalmente hacen una reunión diaria para expresar a los demás como van con su parte del proyecto y periódicamente el equipo reflexiona sobre cómo ser más efectivo.

__Existen varias metodologías:__
__Scrum:__ Organización de proyectos en sprints (generalmente de 2-4 semanas) y reuniones diarias (daily stand-ups).

__Kanban:__ Visualización del flujo de trabajo en un tablero para identificar cuellos de botella y mejorar la eficiencia.

__Extreme Programming (XP):__ Enfoque en la mejora continua y buenas prácticas de programación, como el desarrollo basado en pruebas y la programación en pares.
Lean Development: Inspirada en la manufactura Lean, busca maximizar el valor y minimizar el desperdicio.

## 2. Què són els dobles de prova? Explica amb detall els diferents tipus i posa un exemple d’ús per a una solució en C#

Los dobles de prueba son objetos que imitan a las dependencias reales en el código. Se utilizan para aislar el código que se está probando del resto.

__Tipos:__

__Dummy (maniqui):__
Los dobles de prueba “Dummy” son aquellos que son utilizados para proporcionar una implementación vacía para una dependencia. Se utilizan cuando necesitamos un objeto para cumplir con una firma de método o una interfaz, pero no vamos a  utilizar ese objeto.

__Stub (talón):__
Los dobles de prueba “Stub” son aquellos que se utilizan para simular el comportamiento de una dependencia. Estos dobles proporcionan respuestas predefinidas a ciertas entradas y son muy útiles para probar cómo nuestra aplicación se comporta en diferentes escenarios.

__Fake (falso):__
Los dobles de prueba “Fake” son aquellos que imitan el comportamiento y la interfaz de una dependencia real, utilizan una implementación simplificada. Estos dobles son muy útiles cuando la dependencia cuesta mucho configurarla para un entorno de pruebas.

__Spy (espia):__
Los dobles de prueba “Spy” son aquellos que miran el comportamiento de una dependencia durante una prueba para poder verificar su funcionamiento.
Estos dobles son muy útiles cuando queremos asegurarnos de que una dependencia está funcionando correctamente.

__Mock (imitador):__
Los dobles de prueba “Mock” son un tipo de doble de prueba que se utiliza para verificar el comportamiento de una dependencia durante una prueba. Al contrario de los “fake” y los “spy”, los mock están totalmente controlados por la prueba y no se basan en la implementación real de la dependencia.
Los mock se utilizan principalmente para asegurar que nuestro código se está comportando de la forma esperada cuando se produce un evento o se invoca una función en una dependencia.

__Como aplicarlo?__

Imaginemos que tenemos una clase(calculadora) que depende de un servicio log (Logger) para funcionar y quieres probar el método de suma. Veamos el código principal`la:
Código principal:

``` c#
//dependencia no necesaria que cambiaremos por el dummy

public interface Logger
{
    Log(string message);
}
public class Calculadora
{
    readonly Logger _logger;

    public Calculadora(Logger logger)
    {
        _logger = logger;
    }

    public int Add(int a, int b)
    {
        _logger.Log($"Adding {a} and {b}");
        return a + b;
    }
}
```

__Prueba con Dummy:__
Ya que el logger no es necesario para la prueba, pero necesitamos su dependencia utilizaremos un dummy para emularla.

``` c#
public class CalculatorTests
{
    public void Add_TwoNumbers_ReturnsTheirSum()
    {
        // Arrange: Creamos un dummy para ILogger
        var dummyLogger = new Mock<ILogger>(); 
        // Pasamos el dummy al constructor
        var calculator = new Calculator(dummyLogger.Object);
        // Act: Llamamos al método Add
        int result = calculator.Add(3, 5);
        // Assert: Verificamos el resultado
        Assert.Equal(8, result);
    }
}
```
## 5.Defineix els casos de prova i implements els tests unitaris pel següent problema:

La llibreria PersonaHelper ha estat creada per ajudar en l'anàlisi de dades personals.
Proporciona mètodes per classificar l'edat d'una persona, comprovar si un nombre és parell, analitzar les característiques d'un nom, verificar la categoria d'un color, i determinar la preferència de personalitat d'acord amb el moment del dia. 

L'objectiu és testar aquests mètodes amb classes d'equivalència, valors límit i casos de prova per assegurar-ne el correcte funcionament.

Les restriccions són les següents:

- public int ClassifyAge(int age): edats vàlides [0-120]
- public bool IsEven(int age): retorna si l’edat és parell o senar
- public (bool IsShort, bool IsPalindrome) NameAnalyser(string name):

    < 5 caràcters: és un nom curt

    ≥ 5 caràcters: no és un nom curt

    retorna si el nom és palíndrom o no

- public int VerifyColour(string colour):

    -1: invàlid

    0: calmant [blau, verd]

    1: exclusiu

- public int PersonalityTest(string preference):

    “matí”: retorna 0 [personalitat Matinal]

    “nit”:  retorna 1 [personalitat Nocturna]

    qualsevol altre cas: retorna 2 [personalitat Imprevista]

### Clases de equivalencia:

### Con la edad:

0-120 = edades válidas

-infinito - -1 = edades no válidas por debajo del límite

121-infinito = edades no válidas por encima del límite

1,3,5,7,9,11,13,15,17…119 = edades válidas e impares

2,4,6,8,10,12,14,16,18…120 = edades válidas y pares

-infinito…-77, -75, -73, -71…-1 = edades no válidas,  por debajo del límite e impares

-infinito-...-70, -68, -66, -64…-2 = edades no válidas por debajo del límite y pares

120, 122, 124, 126, 128…infinito = edades no válidas por encima del límite y pares

121, 123, 1235, 127, 129…infinito = edades no válidas por encima del límite e impares

### Con el nombre:

0-4 = nombre corto

5-infinito = nombre largo

palíndromo

no palíndromos

### Con el color:

-1 =  invàlido

0 = azul, verde

1 = exclusivo

otros

### Con la personalidad:

“mati” = 0

“nit” = 1

-infinito - -1 = 2

2-infinito = 2

### Valores límite:

### EDAD:

0

119

1

-1

121

120

### NOMBRE:

0

6

6+palíndromo

4

4+palíndromo

5

5+palíndromo

### color:

“”

“Blau”

“maracuyá”

### personalidad:

mati

nit

diferente a mati y nit

### Casos de prova

| nombre | descripción | input | resultado esperado | resultado final |
| :---- | :---- | :---- | :---- | :---- |
| **EdadZero** | comprueba si la edad es valida y si es par | 0 | valido, par \= true | true |
| **Edad119** | comprueba si la edad es valida y si es par | 119 | valido, par \= false | false |
| **Edad1** | comprueba si la edad es valida y si es par | 1 | valida, par \= false | false |
| **EdadNegative** | comprueba si la edad es valida y si es par | -1  | invalida, par=false | false |
| **Edad121** | comprueba si la edad es valida y si es par | 121 | invalida, par=false | false |
| **Edad120** | comprueba si la edad es valida y si es par | 120 | valida, par=true | true |
| **NombreCharNull** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | - | invalido, palindromo = false | false |
| **NombreCharNumero** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | 4 | nombre corto, palíndromo = true | true |
| **NombreChar6** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | “macarr” | nombre largo, palíndromo = false | false |
| **NombreChar6P** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | “raraarar” | nombre largo, palíndromo = true | true |
| **NombreChar4** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | “taco” | nombre corto, palíndromo = false | false |
| **NombreChar4P** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | “taat” | nombre corto, palíndromo = true | true |
| **NombreChar5** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | “tomar” | nombre largo, palíndromo = false | false |
| **NombreChar5P** | comprueba si el nombre tiene menos de 5 caracteres y si es palindromo | “taoat” | nombre largo, palíndromo = true | true |
| **ColorInvalid** | Comprueba que color es | “ ” | -1 | -1 |
| **ColorCalmant** | Comprueba que color es | “blau” | 0 | *0 |
| **ColorExclusiu** | Comprueba que color es** | “rosa” | 1 | 1 |
| **PersonalidadMati** | Comprueba que personalidad tiene | “mati” | 0 | 0 |
| **PersonalidadNit** | Comprueba que personalidad tiene | “nit” | 1 | 1 |
| **PersonalidadOtro** | Comprueba que personalidad tiene | “Macarrones” | 2 | 2 |

